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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mais mais = new Mais();
            mais.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menos menos = new Menos();
            menos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multi multi = new Multi();
            multi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Divi divi = new Divi();
            divi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bhaskara baca = new Bhaskara();
            baca.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CF cf = new CF();
            cf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pitagoras piti = new Pitagoras();
            piti.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Raiz raiz = new Raiz();
            raiz.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            area.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Volume volume = new Volume();
            volume.Show();
        }
    }
}
