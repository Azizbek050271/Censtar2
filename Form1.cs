using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace Censtar
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;

        public Form1()
        {
            InitializeComponent();
            // Устанавливаем начальный текст для метки статуса
            _statusLabel.Text = "Ожидание подключения";
        }

        // Обработчик события клика на пункте меню "Exit"
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Обработчик события клика на пункте меню "Port setting"
        private void PortSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortSettingsForm portSettingsForm = new PortSettingsForm();
            portSettingsForm.ShowDialog();
        }

        // Обработчик события клика на пункте меню "Price setting"
        private void PriceSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceSettingsForm priceSettingsForm = new PriceSettingsForm();
            priceSettingsForm.Show();
        }

        // Обработчик события клика на пункте меню "Connected"
        private void ConnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");

            // Проверка существования файла конфигурации
            if (!File.Exists(iniFilePath))
            {
                MessageBox.Show("Файл конфигурации не найден.");
                return;
            }

            // Чтение параметров из конфигурационного файла
            string comPort = IniFileHelper.ReadIni("PortSettings", "COMPort", iniFilePath);
            string baudRate = IniFileHelper.ReadIni("PortSettings", "BaudRate", iniFilePath);
            string dataBits = IniFileHelper.ReadIni("PortSettings", "DataBits", iniFilePath);
            string parity = IniFileHelper.ReadIni("PortSettings", "Parity", iniFilePath);
            string stopBits = IniFileHelper.ReadIni("PortSettings", "StopBits", iniFilePath);

            // Проверка корректности параметров
            if (string.IsNullOrWhiteSpace(comPort) ||
                string.IsNullOrWhiteSpace(baudRate) ||
                string.IsNullOrWhiteSpace(dataBits) ||
                string.IsNullOrWhiteSpace(parity) ||
                string.IsNullOrWhiteSpace(stopBits))
            {
                MessageBox.Show("Параметры конфигурации отсутствуют или неверны.");
                return;
            }

            // Проверка существования указанного COM порта
            if (!SerialPort.GetPortNames().Contains(comPort))
            {
                _statusLabel.Text = "Указанный COM порт не существует.";
                return;
            }

            try
            {
                _serialPort = new SerialPort
                {
                    PortName = comPort,
                    BaudRate = int.Parse(baudRate),
                    DataBits = int.Parse(dataBits),
                    Parity = (Parity)Enum.Parse(typeof(Parity), parity),
                    StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits)
                };

                _serialPort.Open();
                this._statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                _statusLabel.Text = "Подключено к " + comPort;
                _statusLabel.ForeColor = System.Drawing.Color.White;
                this.statusStrip1.BackColor = System.Drawing.Color.DarkGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }

        // Обработчик события клика на пункте меню "Disconnected"
        private void DisconnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                try
                {
                    _serialPort.Close();
                    _statusLabel.Text = "Отключено";
                    this._statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                    _statusLabel.ForeColor = System.Drawing.Color.White;
                    this.statusStrip1.BackColor = System.Drawing.Color.DarkRed;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка отключения: " + ex.Message);
                }
            }
        }
    }
}
