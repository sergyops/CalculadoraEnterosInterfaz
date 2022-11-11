using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraEnterosInterfaz
{
    public partial class Form1 : Form
    {
        int primern;
        int segundn;
        int result;
        string operacion;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void check (string op)//detectar si son enteros mayores que 0
        {
            try
            {
                primern = Convert.ToInt32(textBox.Text);
            }
            catch (FormatException)//detectar si el numero que introduce no es un entero
            {
                MessageBox.Show("Formato no soportado");
                primern = 0;
                textBox.Text = "";
            }
            
            if (primern > 0)
            {
                textBox.Text = "";
                operacion = op;
            }
            else
            {
                MessageBox.Show("El número debe ser mayor que 0");
                primern = 0;
                textBox.Text = "";
            }
        }

        private void buttonsuma_Click(object sender, EventArgs e)
        {
            check("+");
        }

        private void buttonresta_Click(object sender, EventArgs e)
        {
            check("-");
        }
        private void buttonmulti_Click(object sender, EventArgs e)
        {
            check("*");
        }
        private void buttondivi_Click(object sender, EventArgs e)
        {
            check("/");
        }
        private void buttonpotencia_Click(object sender, EventArgs e)
        {
            check("^");
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            //hace la operación y muestra el resultado
            try
            {
                segundn = Convert.ToInt32(textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato no soportado");
                primern = 0;
                textBox.Text = "";
            }

            if (operacion == "+")
            {
                result = primern + segundn;
                textBox.Text = result.ToString();
            }
            if (operacion == "-")
            {
                result = primern - segundn;
                textBox.Text = result.ToString();
            }
            if (operacion == "*")
            {
                result = primern * segundn;
                textBox.Text = result.ToString();
            }
            if (operacion == "/")
            {
                result = primern / segundn;
                textBox.Text = result.ToString();
            }
            if (operacion == "^")
            {
                result = primern;
                for (int i = 1; i < (int)segundn; i++)
                {
                    result = result * primern;
                }
                textBox.Text = result.ToString();
            }
            //Muestra un mensaje para preguntar si quiere salir de la aplicacion
            if(MessageBox.Show("Quieres cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
