using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_01_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!","Заголовок",MessageBoxButtons.OKCancel);
        }

        private void button_text_Click(object sender, EventArgs e)
        {
            textBox_status.Text = "Hello!";
        }

        private void abautToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Моя первая программа", "Информация");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
