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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CruisingFlightStand
{
    public partial class ManageForm : Form
    {
        struct ConnectionData
        {
            public double KT1;
            public double KT2;
            public double KT3;
            public double KT4;
            public double KT5;
            public double AirDensity;
            public string PortName;
            public int    BaudRate;
        }

        private bool IsExit = false;                     // Если программа закрывается

        private static string logPath = "log.txt";       // Имя файла с логом 
        private FileStream logFileStream;                // Поток работы с файлом
        private bool DynamicLog = false;                 // Если динамичный лог доступен
        private uint DynamicLogString = 0;               // Текущая строка динамичного лога
        private uint dLog_num = 1;
        private string logSplitter = "|";

        private const string gramm = "гр.";
        private const string kpa = "Па";
        private const string kmh = "км/ч";

        ConnectionData data;
        DateTime dateTime;

        private delegate void TenzoSetter(string val, int id);
        private TenzoSetter SetTenzo;

        private delegate void PitoSetter(string val);
        private PitoSetter SetPito;
        private PitoSetter SetPitoRaw;

        private delegate void VoltSetter(string val);
        private VoltSetter SetVolt;

        private delegate void AmpSetter(string val);
        private AmpSetter SetAmp;

        private delegate void RawAmpSetter(string val);
        private RawAmpSetter SetRawAmp;

        public ManageForm()
        {
            InitializeComponent();

            SetTenzo = new TenzoSetter(SetNewTenzoVal);
            SetPito = new PitoSetter(SetNewPitoVal);
            SetPitoRaw = new PitoSetter(SetNewPitoRawVal);
            SetVolt = new VoltSetter(SetNewVoltVal);
            SetAmp = new AmpSetter(SetNewAmpVal);
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
                data = JsonConvert.DeserializeObject<ConnectionData>(rawData);

                serialPort.PortName = data.PortName;
                serialPort.BaudRate = data.BaudRate;    

                // Установка заддержки отправки данных
                serialPort.WriteTimeout = 10;

                kTenzo1.Text = Convert.ToString(data.KT1);
                kTenzo2.Text = Convert.ToString(data.KT2);
                kTenzo3.Text = Convert.ToString(data.KT3);
                kTenzo4.Text = Convert.ToString(data.KT4);
                kTenzo5.Text = Convert.ToString(data.KT5);
                airDensity.Text = Convert.ToString(data.AirDensity);

                try
                {
                    if (!serialPort.IsOpen)
                    {
                        serialPort.Open();
                        serialPort.WriteLine("[Go]");

                        mainTimer.Enabled = true;
                        mainTimer.Start();
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
            double P = Commands.ConvertToUniformDouble(val);
            double speed = Math.Pow(((P * 1000.0) / Convert.ToDouble(airDensity.Text)), 0.5);
            
            speed *= 3.6;

            speed = Math.Round(speed, 2);

            speed *= Math.Round(Commands.ConvertToUniformDouble(speed_Koef.Text), 2);

            resist_Data.Text = Math.Round(Math.Round(speed, 2) / 100.0, 2) + " " + kmh;
        }

        private void SetNewPitoRawVal(string val)
        {            
            resist_Data_Raw.Text = val.Replace(".", ",");
        }

        private void SetNewTenzoVal(string val, int id)
        {
            //val = val.Replace(".", ",");
            double v = Commands.ConvertToUniformDouble(val);

            switch (id)
            {            
                case 1:
                    tenzo1_Data.Text = Math.Round(Math.Round(Math.Round(v, 2) * Math.Round(Commands.ConvertToUniformDouble(kTenzo1.Text.Replace(",", ".")), 2), 2) / 10.0, 2) + " " + gramm;
                    break;
                case 2:
                    tenzo2_Data.Text = Math.Round(Math.Round(Math.Round(v, 2) * Math.Round(Commands.ConvertToUniformDouble(kTenzo2.Text.Replace(",", ".")), 2), 2) / 10.0, 2) + " " + gramm;
                    break;
                case 3:
                    tenzo3_Data.Text = Math.Round(Math.Round(Math.Round(v, 2) * Math.Round(Commands.ConvertToUniformDouble(kTenzo3.Text.Replace(",", ".")), 2), 2) / 10.0, 2) + " " + gramm;
                    break;
                case 4:
                    tenzo4_Data.Text = Math.Round(Math.Round(Math.Round(v, 2) * Math.Round(Commands.ConvertToUniformDouble(kTenzo4.Text.Replace(",", ".")), 2), 2) / 10.0, 2) + " " + gramm;
                    break;
                case 5:
                    tenzo5_Data.Text = Math.Round(Math.Round(Math.Round(v, 2) * Math.Round(Commands.ConvertToUniformDouble(kTenzo5.Text.Replace(",", ".")), 2), 2) / 10.0, 2) + " " + gramm;
                    tenzo5_DataMain.Text = tenzo5_Data.Text;
                    break;
            }
        }

        private void SetNewVoltVal(string val)
        {
            voltage_Data.Text = Math.Round(Commands.Map(Commands.ConvertToUniformDouble(val), 0.0, 1023.0, 0.0, 50.0) *
               Commands.ConvertToUniformDouble(voltage_Koef.Text), 2) + " В";
        }
        
        private void SetNewAmpVal(string val)
        {
            current_Data.Text = Math.Round(Commands.ConvertToUniformDouble(val) *
                Commands.ConvertToUniformDouble(current_Koef.Text), 2) + " А";
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (!serialPort.IsOpen)
                return;

            try
            {
                var data = serialPort.ReadLine();       // Данные
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
                    else if (command == Commands.Pito.pito) // Если трубка Пито
                    {
                        // Установить значение
                        resist_Data.Invoke(SetPito, value);
                    }
                    else if (command == Commands.Pito.pito_raw) // Если трубка Пито
                    {
                        // Установить значение
                        resist_Data_Raw.Invoke(SetPitoRaw, value);
                    }
                    else if (command == Commands.Sensors.volt) // Если напряжение
                    {
                        // Установить значение
                        voltage_Data.Invoke(SetVolt, value);
                    }
                    else if (command == Commands.Sensors.current) // Если ток
                    {
                        // Установить значение
                        current_Data.Invoke(SetAmp, value);
                    }

                    if (DynamicLog)
                    {
                        dateTime = DateTime.Now;

                        SetStringNumber();
                        AddLog("Time" + logSplitter + dateTime.ToString("HH:mm:ss")       + logSplitter);
                        AddLog("T1"   + logSplitter + tenzo1_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("T2"   + logSplitter + tenzo2_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("T3"   + logSplitter + tenzo3_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("T4"   + logSplitter + tenzo4_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("T5"   + logSplitter + tenzo5_Data.Text.Replace(gramm, "") + logSplitter);
                        AddLog("S"    + logSplitter + tenzo_sum.Text.Replace(gramm, "")   + logSplitter);
                        AddLog("A"    + logSplitter + current_Data.Text.Replace("A", "")  + logSplitter);
                        AddLog("V"    + logSplitter + voltage_Data.Text.Replace("В", "")  + logSplitter);
                        AddLog("P"    + logSplitter + power_Data.Text.Replace("Вт", "")   + logSplitter);
                        AddLog("Pito" + logSplitter + resist_Data.Text.Replace(kmh, "")   + logSplitter + "\n");
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
                logBtn.Text = "Запись";

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
                logBtn.Text = "Остановить";

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

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            double t1 = Convert.ToDouble(tenzo1_Data.Text.Replace(gramm, ""));
            double t2 = Convert.ToDouble(tenzo2_Data.Text.Replace(gramm, ""));
            double t3 = Convert.ToDouble(tenzo3_Data.Text.Replace(gramm, ""));                                     
            double t4 = Convert.ToDouble(tenzo4_Data.Text.Replace(gramm, ""));
            
            double ofs = Convert.ToDouble(offset.Text);

            string v = voltage_Data.Text.Replace("В", "");
            string a = current_Data.Text.Replace("А", "");

            double volt = Convert.ToDouble(v);
            double amp = Convert.ToDouble(a);

            double sum = t1 + t2 + t3 + t4 + (ofs * 1000.0);

            double power = volt * amp;

            power = Math.Round(power, 2);

            tenzo_sum.Text  = Convert.ToString(sum) + " " + gramm;
            power_Data.Text = Convert.ToString(power) + " Вт";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ConnectionData dataSave;

            dataSave.PortName = data.PortName;
            dataSave.BaudRate = data.BaudRate;
            dataSave.AirDensity = Commands.ConvertToUniformDouble(airDensity.Text);
            dataSave.KT1 = Commands.ConvertToUniformDouble(kTenzo1.Text);
            dataSave.KT2 = Commands.ConvertToUniformDouble(kTenzo2.Text);
            dataSave.KT3 = Commands.ConvertToUniformDouble(kTenzo3.Text);
            dataSave.KT4 = Commands.ConvertToUniformDouble(kTenzo4.Text);
            dataSave.KT5 = Commands.ConvertToUniformDouble(kTenzo5.Text);

            string json = JsonConvert.SerializeObject(dataSave);

            // запись в файл
            using (FileStream fstream = new FileStream("cnt.json", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(json);
                fstream.Write(array, 0, array.Length);
            }
        }
    }
}
