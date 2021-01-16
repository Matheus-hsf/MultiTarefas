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
    public partial class Bhaskara : Form
    {
        public Bhaskara()
        {
            InitializeComponent();
        }

        double vlaorX1 = 0;
        double vlaorX2 = 0;
        double raiz1 = 0;
        double raiz2 = 0;
        double a = 0;
        double b = 0;
        double c = 0;
        double x1 = 0;
        double x2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            x1 = Math.Sqrt(b * b - (4 * a * c));
            raiz1 = Convert.ToDouble(x1);
            x1 = -1 * b + x1;
            vlaorX1 = Convert.ToDouble(x1);
            x1 = x1 / (2 * a);

            x2 = Math.Sqrt(b * b - (4 * a * c));
            raiz2 = Convert.ToDouble(x2);
            x2 = -1 * b - x2;
            vlaorX2 = Convert.ToDouble(x2);
            x2 = x2 / (2 * a);

            textBox4.Text = Convert.ToString(x1);
            textBox5.Text = Convert.ToString(x2);
        }
    }
}
