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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void portSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Код для открытия формы настроек порта
        }

        private void priceSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Код для открытия формы настроек цены
        }

        private void connectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Код для открытия выбранного порта
        }

        private void disconnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Код для закрытия выбранного порта
        }
    }
}
