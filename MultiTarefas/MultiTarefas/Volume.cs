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
    public partial class Volume : Form
    {
        public Volume()
        {
            InitializeComponent();
        }

        double aresta = 0;
        double largura = 0;
        double altura = 0;
        double comprimento = 0;
        double raio = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Informe o valor");
            }
            else
            {
                aresta = Convert.ToDouble(textBox1.Text);
                aresta = aresta * aresta * aresta;
                textBox2.Text = Convert.ToString(aresta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" )
            {
                MessageBox.Show("Informe todos os valores");
            }
            else
            {
                largura = Convert.ToDouble(textBox3.Text);
                comprimento = Convert.ToDouble(textBox4.Text);
                altura = Convert.ToDouble(textBox5.Text);

                textBox6.Text = Convert.ToString(largura*comprimento*altura);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Informe o valor");
            }
            else
            {
                raio = Convert.ToDouble(textBox7.Text);
                raio = raio * raio * raio;
                raio = raio * 4;
                raio = raio * 3.14;
                raio = raio / 3;
                textBox8.Text = Convert.ToString(raio);
            }
        }
    }
}
