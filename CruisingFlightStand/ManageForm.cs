using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Forms;

namespace CruisingFlightStand
{
    public partial class ManageForm : Form
    {
        struct ConnectionData
        {
            public string PortName;
            public int BaudRate;
        }

        private bool IsExit = false;                     // Если программа закрывается

        private static string logPath = "log.txt";       // Имя файла с логом 
        private FileStream logFileStream;                // Поток работы с файлом
        private bool DynamicLog = false;                 // Если динамичный лог доступен
        private uint DynamicLogString = 0;               // Текущая строка динамичного лога
        private uint dLog_num = 1;
        private string logSplitter = "|";

        private const string gramm = "гр.";
        private const string kpa = "кПа";

        DateTime dateTime;

        private delegate void TenzoSetter(string val, int id);
        private TenzoSetter SetTenzo;

        private delegate void PitoSetter(string val);
        private PitoSetter SetPito;

        public ManageForm()
        {
            InitializeComponent();

            SetTenzo = new TenzoSetter(SetNewTenzoVal);
            SetPito = new PitoSetter(SetNewPitoVal);
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            string rawData = "";
            bool IsFileExisting = false;

            try
            {
                // чтение из файла
                using (FileStream fstream = File.OpenRead("cnt.json"))
                {
                    byte[] array = new byte[fstream.Length];

                    fstream.Read(array, 0, array.Length);
                    rawData = System.Text.Encoding.Default.GetString(array);

                    IsFileExisting = true;
                }
            }
            catch (FileNotFoundException ex)
            {
                IsFileExisting = false;

                Form errorForm = new ErrorForm("Не удаётся найти настроечный файл!");
                errorForm.ShowDialog();
            }

            if (IsFileExisting)
            {
                ConnectionData data = JsonConvert.DeserializeObject<ConnectionData>(rawData);

                serialPort.PortName = data.PortName;
                serialPort.BaudRate = data.BaudRate;    

                // Установка заддержки отправки данных
                serialPort.WriteTimeout = 10;

                try
                {
                    if (!serialPort.IsOpen)
                    {
                        serialPort.Open();
                        serialPort.WriteLine("[Work mode]");
                    }
                    else
                    {
                        Form errorForm = new ErrorForm("Порт занят!");
                        errorForm.ShowDialog();
                    }
                }
                catch (IOException ex)
                {
                    Form errorForm = new ErrorForm("Ошибка при открытии порта!");
                    errorForm.ShowDialog();
                }
            }
        }

        private void AddLog(string message)
        {
            byte[] array = System.Text.Encoding.Default.GetBytes(message);
            logFileStream.Write(array, 0, array.Length);
        }

        // Установить номер строки в логе
        private void SetStringNumber()
        {
            DynamicLogString++;
            AddLog(DynamicLogString.ToString() + ". ");
        }

        private void SetNewPitoVal(string val)
        {
            resist_Data.Text = val + " " + kpa;
        }

        private void SetNewTenzoVal(string val, int id)
        {
            switch(id)
            {
                case 1: 
                    tenzo1_Data.Text = val + " " + gramm;
                    break;
                case 2:
                    tenzo2_Data.Text = val + " " + gramm;
                    break;
                case 3:
                    tenzo3_Data.Text = val + " " + gramm;
                    break;
                case 4:
                    tenzo4_Data.Text = val + " " + gramm;
                    break;
                case 5:
                    tenzo5_Data.Text = val + " " + gramm;
                    break;
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (!serialPort.IsOpen && !IsExit)
                return;

            try
            {
                var data = serialPort.ReadLine();   // Данные
                data = Commands.DeleteSpecSymb(data);   // Очистка от спец. символов

                // 0 - Команда | 1 - значение
                string[] arr_data = data.Split(Commands.SPLITTER);

                // Если не информация
                if (arr_data.Length != 1)
                {
                    string command = arr_data[0];   // Команда
                    string value = arr_data[1];     // Значение

                    if (command == Commands.HX711.tenzo1) // Если тензодатчик
                    {
                        // Установить значение
                        tenzo1_Data.Invoke(SetTenzo, value, 1);
                    }
                    else if (command == Commands.HX711.tenzo2)
                    {
                        // Установить значение
                        tenzo2_Data.Invoke(SetTenzo, value, 2);
                    }
                    else if (command == Commands.HX711.tenzo3)
                    {
                        // Установить значение
                        tenzo3_Data.Invoke(SetTenzo, value, 3);
                    }
                    else if (command == Commands.HX711.tenzo4)
                    {
                        // Установить значение
                        tenzo4_Data.Invoke(SetTenzo, value, 4);
                    }
                    else if (command == Commands.HX711.tenzo5)
                    {
                        // Установить значение
                        tenzo5_Data.Invoke(SetTenzo, value, 5);
                    }
                    else if (command == Commands.Pito.pito) //  Если трубка Пито
                    {
                        // Установить значение
                        resist_Data.Invoke(SetPito, value);
                    }

                    if(DynamicLog)
                    {
                        dateTime = DateTime.Now;

                        SetStringNumber();
                        AddLog("Time" + logSplitter + dateTime.ToString("HH:mm:ss")       + logSplitter);
                        AddLog("T1"   + logSplitter + tenzo1_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("T2"   + logSplitter + tenzo1_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("T3"   + logSplitter + tenzo1_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("T4"   + logSplitter + tenzo1_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("T5"   + logSplitter + tenzo5_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("Pito" + logSplitter + resist_Data.Text.Replace(kpa, "")   + logSplitter + "\n");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (DynamicLog)
            {
                DynamicLog = false;
                DynamicLogString = 0;

                logBtn.IconChar = FontAwesome.Sharp.IconChar.File;

                dateTime = DateTime.Now;

                AddLog("Конец:\n");
                AddLog(dateTime.ToString("dd.MM.yyyy") + "\n" + dateTime.ToString("HH:mm:ss") + "\n");

                AddLog("Динамичный лог " + (dLog_num - 1) + " окончен.\n");

                logFileStream.Close();
            }
            else
            {
                logFileStream = new FileStream(logPath, FileMode.Append);

                DynamicLog = true;
                logBtn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;

                AddLog("Динамичный лог " + dLog_num + "\n");

                dateTime = DateTime.Now;

                AddLog("Начало:\n");
                AddLog(dateTime.ToString("dd.MM.yyyy") + "\n" + dateTime.ToString("HH:mm:ss") + "\n");

                dLog_num++;
            }
        }

        private void ManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsExit = true;
            DynamicLog = false;

            // Если порт открыт
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(Commands.Arduino.shutdown);    // Перевести систему в спящий режим
                serialPort.Close();                                 // Отключить порт
            }
        }
    }
}
