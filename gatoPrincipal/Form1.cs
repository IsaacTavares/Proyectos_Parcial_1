using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace gato
{
    public partial class Form1 : Form
    {

        // declaración de una clase llamada Form1 que hereda de la clase Form
        private Dictionary<Button, Image> imagenesPredefinidas = new Dictionary<Button, Image>();

        //para la musica 
        string rutaAudio = "images/mario.wav";
        SoundPlayer player;


        public Form1()
        {

            // Inicializa los componentes del formulario
            InitializeComponent();
            // Llama al método GuardarImagenesPredefinidas para almacenar las imágenes predefinidas en el diccionario
            GuardarImagenesPredefinidas();

        }



        //unas variables
        int banderaTurno = 1;
        int banderaEmpate = 0;
        int jug1 = 0;
        int jug2 = 0;
        int empate = 0;


        //variables para las imagnes de los personajes 
        Image imagenX = Image.FromFile("images/mario.jpg");
        Image imagenO = Image.FromFile("images/yoshi.jpg");

        

        //imagnes de los botones 
        private void GuardarImagenesPredefinidas()
        {
            imagenesPredefinidas.Add(btn1, btn1.BackgroundImage);
            imagenesPredefinidas.Add(btn2, btn2.BackgroundImage);
            imagenesPredefinidas.Add(btn3, btn3.BackgroundImage);
            imagenesPredefinidas.Add(btn4, btn4.BackgroundImage);
            imagenesPredefinidas.Add(btn5, btn5.BackgroundImage);
            imagenesPredefinidas.Add(btn6, btn6.BackgroundImage);
            imagenesPredefinidas.Add(btn7, btn7.BackgroundImage);
            imagenesPredefinidas.Add(btn8, btn8.BackgroundImage);
            imagenesPredefinidas.Add(btn9, btn9.BackgroundImage);
         
        }

        // Método para restablecer el juego
        private void reset()
        {
            
            LimpiarImagenes();
            RestaurarImagenesPredefinidas();

            banderaEmpate = 0;
            if (banderaTurno == 1)
                banderaTurno = 2;
            else
                banderaTurno = 1;
        }

        // Método para limpiar las imágenes de los botones
        private void LimpiarImagenes()
        {
            foreach (Button btn in imagenesPredefinidas.Keys)
            {
                if (esImagenX(btn.BackgroundImage) || esImagenO(btn.BackgroundImage))
                {
                    btn.BackgroundImage = null;
                }
            }
        }


        // Método para restaurar las imágenes predefinidas de los botones
        private void RestaurarImagenesPredefinidas()
        {
            foreach (var entry in imagenesPredefinidas)
            {
                entry.Key.BackgroundImage = entry.Value;
            }
        }


        // Método para agregar puntos y restablecer el juego
        private void AgregarPuntos()
        {
            if (banderaTurno == 1)
            {
                jug1++;
                lbljugador1.Text = jug1.ToString();
            }
            else
            {
                jug2++;
                lbljugador2.Text = jug2.ToString();
            }
            reset();
        }

        // Método para verificar si hay un ganador o un empate
        private void comprobar()
        {
            Image img1 = btn1.BackgroundImage;
            Image img2 = btn2.BackgroundImage;
            Image img3 = btn3.BackgroundImage;
            Image img4 = btn4.BackgroundImage;
            Image img5 = btn5.BackgroundImage;
            Image img6 = btn6.BackgroundImage;
            Image img7 = btn7.BackgroundImage;
            Image img8 = btn8.BackgroundImage;
            Image img9 = btn9.BackgroundImage;

            string nombreJugador = (banderaTurno == 1) ? "Mario" : "Yoshi";



            //comprobamos que el boton 1, 2 y 3 para el ganador
            if (img1 != null && img1.Equals(img2) && img1.Equals(img3)) {
                MessageBox.Show("Ganó " + nombreJugador);

                //agrega puntos
                AgregarPuntos();
            }
            else

                //comprobamos que el boton 1, 4 y 7 para el ganador
                if (img1 != null && img1.Equals(img4) && img1.Equals(img7))
            {
                MessageBox.Show("Ganó " + nombreJugador);
                //agrega puntos
                AgregarPuntos();
            }
            else
                //comprobamos que el boton 1, 5 y 9 para el ganador
                if (img1 != null && img1.Equals(img5) && img1.Equals(img9))
            {
                MessageBox.Show("Ganó " + nombreJugador);
                //agrega puntos
                AgregarPuntos();
            }
            else
                //comprobamos que el boton 2, 5 y 8 para el ganador
                if (img2 != null && img2.Equals(img5) && img2.Equals(img8))
            {
                MessageBox.Show("Ganó " + nombreJugador);
                //agrega puntos
                AgregarPuntos();
            }

            else
                //comprobamos que el boton 3, 6 y 9 para el ganador
                if (img3 != null && img3.Equals(img6) && img3.Equals(img9))
            {
                MessageBox.Show("Ganó " + nombreJugador);
                //agrega puntos
                AgregarPuntos();
            }
            else
                //comprobamos que el boton 3, 5 y 7 para el ganador
                if (img3 != null && img3.Equals(img5) && img3.Equals(img7))
            {
                MessageBox.Show("Ganó " + nombreJugador);
                //agrega puntos
                AgregarPuntos();
            }
            else
                //comprobamos que el boton 4, 5 y 6 para el ganador
                if (img4 != null && img4.Equals(img5) && img4.Equals(img6))
            {
                MessageBox.Show("Ganó " + nombreJugador);
                //agrega puntos
                AgregarPuntos();
            }
            //comprobamos que el boton 7, 8 y 9 para el ganador
            else
                if (img7 != null && img7.Equals(img8) && img7.Equals(img9))
            {
                MessageBox.Show("Ganó " + nombreJugador);
                //agrega puntos
                AgregarPuntos();
            }
           
            
            else
            {
                //si empatan entonces sumamos en el marcador
                banderaEmpate++;
                if (banderaEmpate == 9)//empata cuando los 9 botones esten llenos y compruebe que nadie gano
                {
                    MessageBox.Show("Nadie gana, es un empate");
                    empate++;
                    lblempate.Text = empate.ToString();
                    reset();
                }
            }
        }


        //metodo para manejar el clic en un botón
        private void escribir(Button a)
        {
            if (!esImagenX(a.BackgroundImage) && !esImagenO(a.BackgroundImage))
            {

                //si el turno es para el 1 entonces pondra la imagen 
                if (banderaTurno == 1)
                {
                    a.BackgroundImage = imagenX;
                    a.BackgroundImageLayout = ImageLayout.Stretch;
                    comprobar();//comprobamos
                    banderaTurno = 2;
                }
                //si el turno es para el 2 entonces pondra la imagen 
                else if (banderaTurno == 2)
                {
                    a.BackgroundImage = imagenO;
                    a.BackgroundImageLayout = ImageLayout.Stretch;
                    comprobar();//comprobamos
                    banderaTurno = 1;
                }
            }

            //si hay una imagen en el boton le mandamos una alerta
            else
            {
                MessageBox.Show("Ya hay una imagen en este botón.");
            }
        }


        //metodo para verificar si la imagen es la imagen de X (Mario)
        private bool esImagenX(Image imagen)
        {
            return imagen != null && imagen.Equals(imagenX);
        }
        //metodo para verificar si la imagen es la imagen de O (Yoshi)
        private bool esImagenO(Image imagen)
        {
            return imagen != null && imagen.Equals(imagenO);
        }


        // manejadores de eventos click para cada botón en el formulario hasta el 9
        private void btn1_Click(object sender, EventArgs e)
        {
            escribir(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            escribir(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            escribir(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            escribir(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            escribir(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            escribir(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            escribir(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            escribir(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            escribir(btn9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*string rutaMusica = "images/f1.wav";
            reproductor = new SoundPlayer(rutaMusica);
            try
            {

                reproductor.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir la música: " + ex.Message);
            }*/
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //reproductor.Stop();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //muisca
            player = new SoundPlayer(rutaAudio);
            player.PlayLooping();
        }
    }
}