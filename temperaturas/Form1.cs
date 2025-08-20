using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float celsius,fahrenheit,resul;
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btFAC_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtEntrada.Text, out fahrenheit))
            {
                float celsius = (fahrenheit - 32) * 5 / 9;
                Salida.Text = celsius.ToString("0.00") + (" °C");
            }

            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCAF_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtEntrada.Text, out celsius))
            {
                float Fahrenheit = (celsius * 9 / 5) +32;
                Salida.Text = Fahrenheit.ToString("0.00") + (" °C");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }

        }
    }
}
