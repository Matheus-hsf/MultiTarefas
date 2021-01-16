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
    public partial class Raiz : Form
    {
        public Raiz()
        {
            InitializeComponent();
        }
        double n1 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n1 = Math.Sqrt(n1);
            textBox2.Text = Convert.ToString(n1);
        }
    }
}
