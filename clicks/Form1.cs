using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador = 0;
        


        private void btClick_Click(object sender, EventArgs e)
        {
            contador++;
            ctNumero.Text = contador.ToString();
            
           
        }

        private void ctNumero_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lblDEDOS_Click(object sender, EventArgs e)
        {
            
        }
    }
}
