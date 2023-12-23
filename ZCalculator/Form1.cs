using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number;
            if (Double.TryParse(textBox1.Text, out number))
            {
                number /= Int32.Parse(listBox1.Text);
                number /= 1.10f;
                number = Math.Round(number, 4);
                //MessageBox.Show(number.ToString());
                Clipboard.SetText(number.ToString());
                textBox1.Text = "";
                button1.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Geçersiz Sayı!");
            }
        }
    }
}
