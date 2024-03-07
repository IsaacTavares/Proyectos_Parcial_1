using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora3.Presentacion
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            //se inicia
            InitializeComponent();
        }

        //boton 1 que es para ver el resultado
        private void button1_Click(object sender, EventArgs e)
        {

            //una variable
            double res = 0;

            //ver que esten dos caracteres en los campos correspondientes que en este caso son textBox
            if (double.TryParse(dato1.Text, out double d1) && double.TryParse(dato2.Text, out double d2))
            {
                char op = operacion.Text[0];
                switch (op)
                {
                    case '+':
                        // Sumar los valores
                        res = d1 + d2;
                        break;
                    case '-':
                        // Sumar los valores
                        res = d1 - d2;
                        break;
                    case '*':
                        // Sumar los valores
                        res = d1 * d2;
                        break;
                    case '/':
                        // Sumar los valores
                        res = d1 / d2;
                        break;
                    default:
                        MessageBox.Show("Ingrese una operación valida");
                        break;

                }
                // Mostrar el resultado en el TextBox correspondiente
                resultado.Text = res.ToString();

            }
            else
            {
                //una alerta para ingresar solamente numeros
                MessageBox.Show("Ingrese números válidos en los TextBox.");
            }
        }
    }
}
