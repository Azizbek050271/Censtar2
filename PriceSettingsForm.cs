using System;
using System.IO;
using System.Windows.Forms;

namespace Censtar
{
    public partial class PriceSettingsForm : Form
    {
        // Constructor
        public PriceSettingsForm()
        {
            InitializeComponent(); // Initialize components
            InitializeDelimiterComboBox();
            LoadPriceSettings();
            DisplayCurrentPrice(); // Новый метод для отображения текущей цены
        }

        // Initialize delimiters in ComboBox
        private void InitializeDelimiterComboBox()
        {
            comboBoxDelimiter.Items.AddRange(new object[] { "1", "10", "100", "1000" });
            comboBoxDelimiter.SelectedIndex = 0; // Default to 1
        }

        // Load settings from INI file
        private void LoadPriceSettings()
        {
            string iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");

            if (File.Exists(iniFilePath))
            {
                string priceDelimiter = IniFileHelper.ReadIni("PriceSettings", "PriceDelimiter", iniFilePath);
                if (priceDelimiter != "")
                {
                    var parts = priceDelimiter.Split('/');
                    if (parts.Length == 2)
                    {
                        textBoxPrice.Text = parts[0];
                        comboBoxDelimiter.Text = parts[1];
                    }
                }
            }
        }

        // Новый метод для отображения текущей цены
        private void DisplayCurrentPrice()
        {
            string iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");

            if (File.Exists(iniFilePath))
            {
                string priceDelimiter = IniFileHelper.ReadIni("PriceSettings", "PriceDelimiter", iniFilePath);

                if (decimal.TryParse(priceDelimiter, out decimal price))
                {
                    LblCrPrice.Text = $"Текущая цена: {price} руб.";
                }
                else
                {
                    LblCrPrice.Text = "Цена не установлена. Задайте цену.";
                }
            }
            else
            {
                LblCrPrice.Text = "Файл конфигурации не найден.";
            }
        }

        // Save settings to INI file
        private void SavePriceSettings()
        {
            string iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");

            try
            {
                // Проверка корректности ввода цены
                if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
                {
                    MessageBox.Show("Введите корректную цену.");
                    return;
                }

                // Проверка выбора делителя
                if (comboBoxDelimiter.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите корректный делитель.");
                    return;
                }

                // Получение выбранного делителя
                string delimiterString = comboBoxDelimiter.SelectedItem.ToString();
                if (!int.TryParse(delimiterString, out int delimiter))
                {
                    MessageBox.Show("Выбран некорректный делитель.");
                    return;
                }

                // Выполнение деления
                decimal result = price / delimiter;

                // Преобразование результата в строку без ненужных нулей после запятой
                string priceDelimiter = result.ToString("0.##");

                // Сохранение в INI файл
                IniFileHelper.WriteIni("PriceSettings", "PriceDelimiter", priceDelimiter, iniFilePath);

                MessageBox.Show("Настройки цены успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении настроек цены: " + ex.Message);
            }
        }

        // Event handler for Save button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SavePriceSettings();
            this.Close(); // Закрывает окно настроек после сохранения
        }

        // Initialize the form components
        private void InitializeComponent()
        {
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxDelimiter = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCrPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(55, 84);
            this.textBoxPrice.MaxLength = 6;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 0;
            // 
            // comboBoxDelimiter
            // 
            this.comboBoxDelimiter.FormattingEnabled = true;
            this.comboBoxDelimiter.Location = new System.Drawing.Point(55, 121);
            this.comboBoxDelimiter.Name = "comboBoxDelimiter";
            this.comboBoxDelimiter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDelimiter.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(55, 162);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delimiter:";
            // 
            // LblCrPrice
            // 
            this.LblCrPrice.AutoSize = true;
            this.LblCrPrice.Location = new System.Drawing.Point(5, 45);
            this.LblCrPrice.Name = "LblCrPrice";
            this.LblCrPrice.Size = new System.Drawing.Size(70, 13);
            this.LblCrPrice.TabIndex = 5;
            this.LblCrPrice.Text = "Current price:";
            // 
            // PriceSettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(237, 242);
            this.Controls.Add(this.LblCrPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxDelimiter);
            this.Controls.Add(this.textBoxPrice);
            this.Name = "PriceSettingsForm";
            this.Text = "Price Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxDelimiter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label LblCrPrice;

        private void PriceSettingsForm_Load(object sender, EventArgs e)
        {
            // Handle form load event if needed
        }
    }
}
