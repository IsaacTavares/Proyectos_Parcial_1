using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //VARIABLES
        string operador = "";
        double num1 = 0;
        double num2 = 0;

        //Boton para borrar todo
        private void btnBorrarT_Click(object sender, EventArgs e)
        {
            espEscribir.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        //Boton para borrar un elemento
        private void btnBorrarE_Click(object sender, EventArgs e)
        {
            if (espEscribir.TextLength == 1) espEscribir.Text = "0";
            else espEscribir.Text = espEscribir.Text.Substring(0, espEscribir.Text.Length - 1);
        }

        //Pantalla para ingreso de datos y muestra de  resultados
        private void espEscribir_TextChanged(object sender, EventArgs e)
        {

        }

        //---------------------------------
        //BOTONES DE LA CALCULADORA (NUMEROS)
        //---------------------------------

        //Boton con el numero uno
        private void numUno_Click(object sender, EventArgs e)
        {
            if(espEscribir.Text=="0") espEscribir.Text = "";
            espEscribir.Text = espEscribir.Text + "1";
        }

        //Boton con el numero dos
        private void numDos_Click(object sender, EventArgs e)
        {
            if (espEscribir.Text == "0") espEscribir.Text = "";
            espEscribir.Text = espEscribir.Text + "2";
        }

        //Boton con el numero tres
        private void numTres_Click(object sender, EventArgs e)
        {
            if (espEscribir.Text == "0") espEscribir.Text = "";
            espEscribir.Text = espEscribir.Text + "3";
        }

        //Boton con el numero cuatro
        private void numCuatro_Click(object sender, EventArgs e)
        {
            if (espEscribir.Text == "0") espEscribir.Text = "";
            espEscribir.Text = espEscribir.Text + "4";
        }

        //Boton con el numero cinco
        private void numCinco_Click(object sender, EventArgs e)
        {
            if (espEscribir.Text == "0") espEscribir.Text = "";
            espEscribir.Text = espEscribir.Text + "5";
        }

        //Boton con el numero seis
        private void numSeis_Click(object sender, EventArgs e)
        {
            if (espEscribir.Text == "0") espEscribir.Text = "";
            espEscribir.Text = espEscribir.Text + "6";
        }

        //Boton con el numero siete
        private void numSiete_Click(object sender, EventArgs e)
        {
            if (espEscribir.Text == "0") espEscribir.Text = "";
            espEscribir.Text = espEscribir.Text + "7";
        }

        //Boton con el numero ocho
        private void numOcho_Click(object sender, EventArgs e)
        {
            if (espEscribir.Text == "0") espEscribir.Text = "";
            espEscribir.Text = espEscribir.Text + "8";
        }

        //Boton con el numero nueve
        private void numNueve_Click(object sender, EventArgs e)
        {
            if (espEscribir.Text == "0") espEscribir.Text = "";
            espEscribir.Text = espEscribir.Text + "9";
        }

        //BOTON PARA EL PUNTO
        private void btnPunto_Click(object sender, EventArgs e)
        {
            espEscribir.Text = espEscribir.Text + ",";
        }

        //Boton con el numero cero
        private void numCero_Click_1(object sender, EventArgs e)
        {
            espEscribir.Text = espEscribir.Text + "0";
        }

        //-----------------------
        //BOTONES DE OPERACION
        //-----------------------
        //Boton de suma
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(espEscribir.Text);
            espEscribir.Text = "0";
        }

        //Boton de resta
        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(espEscribir.Text);
            espEscribir.Text = "0";
        }

        //Boton de multiplicacion
        private void btnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(espEscribir.Text);
            espEscribir.Text = "0";
        }

        //Boton de division
        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(espEscribir.Text);
            espEscribir.Text = "0";
        }

        //BOTON PARA EJECUTAR LA OPERACION Y MOSTRAR EL RESULTADO
        private void btnRes_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(espEscribir.Text);

            switch (operador)
            {
                case "+":
                    espEscribir.Text =$"{ num1+num2}";
                    break;
                case "-":
                    espEscribir.Text = $"{num1 - num2}";
                    break;
                case "*":
                    espEscribir.Text = $"{num1 * num2}";
                    break;
                case "/":
                    espEscribir.Text = $"{num1 / num2}";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
