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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

       double q = 0;
       double raio = 0;
       double altura = 0;
        double basee =0;


        private void button1_Click(object sender, EventArgs e)
        {
            q = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(q * q);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            raio = Convert.ToDouble(textBox3.Text);
            raio = 3.14 * raio * raio;
            textBox4.Text = Convert.ToString(raio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            altura =Convert.ToDouble(textBox5.Text);
            basee = Convert.ToDouble(textBox6.Text);

            textBox7.Text = Convert.ToString((basee*altura)/2);
        }
    }
}
