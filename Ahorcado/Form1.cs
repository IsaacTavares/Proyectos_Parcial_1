using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int num1, num2, resultadoCorrecto;


        //constructor de la clase Form1
        public Form1()
        {
            InitializeComponent();


            //deshabilitar los controles al iniciar el formulario
            resultado.Enabled = false;
            button2.Enabled = false;
            numero1.Enabled = false;
            numero2.Enabled = false;

            tec1.Enabled = false;
            tec2.Enabled = false;
            tec3.Enabled = false;
            tec4.Enabled = false;
            tec5.Enabled = false;
            tec6.Enabled = false;
            tec7.Enabled = false;
            tec8.Enabled = false;
            tec9.Enabled = false;
            tec0.Enabled = false;


            //asignar el evento Click a los botones de los números
            tec1.Click += Tec_Click;
            tec2.Click += Tec_Click;
            tec3.Click += Tec_Click;
            tec4.Click += Tec_Click;
            tec5.Click += Tec_Click;
            tec6.Click += Tec_Click;
            tec7.Click += Tec_Click;
            tec8.Click += Tec_Click;
            tec9.Click += Tec_Click;
            tec0.Click += Tec_Click;



            
        }


        //contador de intentos y límite de intentos
        private int intentos = 0;
        private const int maxIntentos = 6;


        //imágenes para mostrar los intentos fallidos
        private Image img1 = Image.FromFile("images/1.png");
        private Image img2 = Image.FromFile("images/2.png");
        private Image img3 = Image.FromFile("images/3.png");
        private Image img4 = Image.FromFile("images/4.png");
        private Image img5 = Image.FromFile("images/5.png");
        private Image img6 = Image.FromFile("images/6.png");


        //metodo para manejar el evento Click de los botones de los números
        private void Tec_Click(object sender, EventArgs e)
        {
            Button tecButton = sender as Button;
            if (tecButton != null)
            {
                int numero = int.Parse(tecButton.Text);
                resultado.Text += numero.ToString();
            }
        }

        //metodo para iniciar el juego al hacer clic en el botón de empezar
        private void button1_Click(object sender, EventArgs e)
        {
            resultado.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = false;

            tec1.Enabled = true;
            tec2.Enabled = true;
            tec3.Enabled = true;
            tec4.Enabled = true;
            tec5.Enabled = true;
            tec6.Enabled = true;
            tec7.Enabled = true;
            tec8.Enabled = true;
            tec9.Enabled = true;
            tec0.Enabled = true;

            //generar la operación matemática
            GenerarOperacion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tec3_Click(object sender, EventArgs e)
        {
     
        }


        //metodo para generar una nueva operación matemática
        private void GenerarOperacion()
        {
            num1 = random.Next(1, 11);
            num2 = random.Next(1, 11);

            numero1.Text = num1.ToString();
            numero1.Enabled = false;

            numero2.Text = num2.ToString();
            numero2.Enabled = false;

            resultado.Text = "";
            resultadoCorrecto = num1 * num2;
        }


        //metodo para manejar el evento Click del botón comprobar
        private void button2_Click(object sender, EventArgs e)
        {

            //comprobar si se ha alcanzado el límite de intentos
            if (intentos >= maxIntentos)
            {
                MessageBox.Show("has alcanzado el máximo de intentos");
                button1.Enabled = true; 
                return;
            }


            //validar el resultado ingresado por el usuario
            int resultadoIngresado;
            if (int.TryParse(resultado.Text, out resultadoIngresado))
            {
                if (resultadoIngresado == resultadoCorrecto)
                {
                    MessageBox.Show("El resultado es correcto");
                }
                else
                {
                    MessageBox.Show("When no saben: NO SABEN, El resultado es: " + resultadoCorrecto);

                    //mostrar la imagen correspondiente al intento fallido
                    switch (intentos)
                    {
                        case 0:
                            pictureBox1.Image = img1;
                            break;
                        case 1:
                            pictureBox1.Image = img2;
                            break;
                        case 2:
                            pictureBox1.Image = img3;
                            break;
                        case 3:
                            pictureBox1.Image = img4;
                            break;
                        case 4:
                            pictureBox1.Image = img5;
                            break;
                        case 5:
                            pictureBox1.Image = img6;
                            break;
                        default:
                            break;
                    }
                    intentos++;
                }


                //comprobar si se ha alcanzado el límite de intentos
                if (intentos >= maxIntentos)
                {
                    MessageBox.Show("Ves lo que haces ya se murió ");
                    button2.Enabled = false;
                    resultado.Enabled = false;


                    //deshabilitar los controles de entrada
                    tec1.Enabled = false;
                    tec2.Enabled =false;
                    tec3.Enabled = false;
                    tec4.Enabled = false;
                    tec5.Enabled = false;
                    tec6.Enabled = false;
                    tec7.Enabled = false;
                    tec8.Enabled = false;
                    tec9.Enabled = false;
                    tec0.Enabled = false;


                    //habilitar el botón de empezar para iniciar un nuevo juego
                    button1.Enabled = true;

                }
                else
                {

                    //generar una nueva operación matemática
                    GenerarOperacion();
                }
            }
            else
            {
                MessageBox.Show("ingresa un numero ");
            }
        }
    }
}