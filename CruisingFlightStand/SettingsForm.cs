using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace CruisingFlightStand
{
    public partial class SettingsForm : Form
    {
        bool IsSuccessLoad;

        struct ConnectionData
        {
            public string PortName;
            public int BaudRate;
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            portList.Items.Clear();
            baudRateList.Items.Clear();
            
            string[] ports = SerialPort.GetPortNames();
            portList.Items.AddRange(ports);

            if (ports.Length == 0)
            {
                Form errorForm = new ErrorForm("Не удаётся найти подключенное устройство!");
                errorForm.ShowDialog();

                IsSuccessLoad = false;
            }
            else
            {
                portList.SelectedItem = portList.Items[0];

                IsSuccessLoad = true;
            }

            baudRateList.Items.Add(300);
            baudRateList.Items.Add(1200);

            for (int i = 1200; i < 38400; i += i)
            {
                baudRateList.Items.Add(i * 2);
            }

            baudRateList.Items.Add(57600);

            for (int i = 57600; i < 230400; i += i)
            {
                baudRateList.Items.Add(i * 2);
            }

            baudRateList.Items.Add(250000);

            for (int i = 250000; i < 2000000; i += i)
            {
                baudRateList.Items.Add(i * 2);
            }

            baudRateList.SelectedItem = 9600;

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
                    fstream.Close();
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
                ConnectionData data1 = JsonConvert.DeserializeObject<ConnectionData>(rawData);

                portList.SelectedItem = data1.PortName;
                baudRateList.SelectedItem = data1.BaudRate;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ConnectionData data;

            data.PortName = portList.SelectedItem.ToString();
            data.BaudRate = Convert.ToInt32(baudRateList.SelectedItem.ToString());
            
            string json = JsonConvert.SerializeObject(data);

            // запись в файл
            using (FileStream fstream = new FileStream("cnt.json", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(json);
                fstream.Write(array, 0, array.Length);
            }
        }
    }
}
