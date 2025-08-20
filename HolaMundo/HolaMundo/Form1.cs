using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            string usuario, clave;
            usuario = ctUsuario.Text;

            clave = ctClave.Text;
            int intent = 1;

            do
            {
                if (usuario == "admin" && clave == "admin123")
                {
                    MessageBox.Show("Bienvenido " + usuario);
                    return; 
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta. Intento " + intent + " de 3");
                    intent++;

                  
                }

            } while (intent <= 3);

            MessageBox.Show("Has excedido el número de intentos");
        
    }
    }
}
