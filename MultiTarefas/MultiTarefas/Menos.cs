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
    public partial class Menos : Form
    {
        public Menos()
        {
            InitializeComponent();
        }
        double n1 = 0;
        double n2 = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Informe todos os valores");
            }
            else
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(n1 - n2);
            }
        }
    }
}
