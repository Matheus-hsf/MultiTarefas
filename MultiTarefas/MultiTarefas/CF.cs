using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CF : Form
    {
        public CF()
        {
            InitializeComponent();
        }

        double celsius = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Informe o valor em graus celsius para ser convertido.");
            }
            else
            {
                celsius = Convert.ToDouble(textBox1.Text);
                celsius = (celsius * (1.8)) + 32;
                textBox2.Text = Convert.ToString(celsius);
                
            }
        }
    }
}
