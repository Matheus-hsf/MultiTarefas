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
    public partial class Pitagoras : Form
    {
        public Pitagoras()
        {
            InitializeComponent();
        }

        double n1 = 0;
        double n2 = 0;
        double n3 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Informe os valores");
            }
            else
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);

                n3 = Math.Sqrt(n1*n1 + n2*n2);
                textBox4.Text = Convert.ToString(n3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Informe os valores");
            }
            else
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                n3 = Convert.ToDouble(textBox3.Text);

                if (n1 == 0)
                {
                    n1 = Math.Sqrt(n3 * n3 - n2 * n2);
                    textBox5.Text = Convert.ToString(n1);
                }
                else
                {
                    n2 = Math.Sqrt(n3 * n3 - n1 * n1);
                    textBox5.Text = Convert.ToString(n2);
                }



                
            }

        }
    }
}
