using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Censtar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PortSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortSettingsForm portSettingsForm = new PortSettingsForm();
            portSettingsForm.ShowDialog();  // Открываем форму как диалоговое окно
        }


        private void PriceSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Код для открытия формы настроек цены
        }

        private void ConnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Код для открытия выбранного порта
        }

        private void DisconnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Код для закрытия выбранного порта
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
