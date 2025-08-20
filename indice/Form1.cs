using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indice
{
    public partial class lblTitulomts : Form
    {
        public lblTitulomts()
        {
            InitializeComponent();
        }
        double peso=0;
        double altura = 0;
        double IMC = 0;

        private void lblMtss_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulokg_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtMetros.Text);

            IMC = peso / (altura * altura);
            lblRes.Text = IMC.ToString("0.0");

            if (IMC < 18.5)
            {
                lblEstado.Text = "Bajo Peso";

            }
            else if (IMC >= 18.5 && IMC < 24.9)
            {

                lblEstado.Text = "Peso Normal";

            }
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                lblEstado.Text = "Sobre Peso";
            }
            else
            {
                lblEstado.Text = "Obesidad";
            }

        }

        private void txtMetros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
