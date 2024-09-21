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
        private OrderManager _orderManager;

        public Form1()
        {
            InitializeComponent();
            // Устанавливаем начальный текст для метки статуса
            _statusLabel.Text = "Ожидание подключения";

            // Создаем экземпляр OrderManager с передачей пути к config.ini
            string iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
            _orderManager = new OrderManager(iniFilePath);

            // Привязываем обработчики для полей TbxLiter и TbxAmount
            TbxLiter.TextChanged += TbxLiter_TextChanged;
            TbxAmount.TextChanged += TbxAmount_TextChanged;

            // Привязываем обработчики для кнопок
            BtnStart.Click += BtnStart_Click;
            BtnReset.Click += BtnReset_Click; // Обработчик для кнопки Reset
        }

        private void TbxLiter_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(TbxLiter.Text, out decimal liters))
            {
                TbxAmount.Enabled = false; // Отключаем ввод в TbxAmount
                _orderManager.SetLiters(liters);
            }
            else
            {
                TbxAmount.Enabled = true; // Разрешаем ввод в TbxAmount, если неверный ввод
            }
        }

        private void TbxAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(TbxAmount.Text, out decimal amount))
            {
                TbxLiter.Enabled = false; // Отключаем ввод в TbxLiter
                _orderManager.SetAmount(amount);
            }
            else
            {
                TbxLiter.Enabled = true; // Разрешаем ввод в TbxLiter, если неверный ввод
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (_orderManager.ValidateOrder())
            {
                // Отображаем данные заказа с расчетом литров или суммы
                MessageBox.Show(_orderManager.GetOrderSummary(), "Информация о заказе");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите данные заказа.", "Ошибка");
            }
        }

        // Обработчик для кнопки Reset
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Очищаем поля TbxLiter и TbxAmount
            TbxLiter.Clear();
            TbxAmount.Clear();

            // Делаем оба поля доступными для ввода
            TbxLiter.Enabled = true;
            TbxAmount.Enabled = true;

            // Сбрасываем данные в OrderManager, путь к config.ini остается тем же
            string iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
            _orderManager = new OrderManager(iniFilePath);
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
                this.OrderPanel.Visible = true;
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
                    this.OrderPanel.Visible = false;
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
