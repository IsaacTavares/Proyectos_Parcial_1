using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Media;

namespace aplicaciondesigngato
{
    public partial class MainPage : ContentPage
    {
        private Dictionary<ImageButton, ImageSource> imagenesPredefinidas = new Dictionary<ImageButton, ImageSource>();
       

        public MainPage()
        {
            //inicializa los componentes de la página
            InitializeComponent();
            //llama al método para guardar imágenes predefinidas
            GuardarImagenesPredefinidas();
        }


        //variables de estado para controlar el juego
        int banderaTurno = 1;
        int banderaEmpate = 0;
        int jug1 = 0;
        int jug2 = 0;
        int empate = 0;


        //imagenes de X (Mario) y O (Yoshi)
        ImageSource imagenX = ImageSource.FromFile("mario.jpg");
        ImageSource imagenO = ImageSource.FromFile("yoshi.jpg");


        //metodo para guardar imágenes predefinidas asociadas a los botones
        private void GuardarImagenesPredefinidas()
        {
            imagenesPredefinidas.Add(BtnUnoGato, BtnUnoGato.Source);
            imagenesPredefinidas.Add(BtnDosGato, BtnDosGato.Source);
            imagenesPredefinidas.Add(BtnTresGato, BtnTresGato.Source);
            imagenesPredefinidas.Add(BtnCuatroGato, BtnCuatroGato.Source);
            imagenesPredefinidas.Add(BtnCincoGato, BtnCincoGato.Source);
            imagenesPredefinidas.Add(BtnSeisGato, BtnSeisGato.Source);
            imagenesPredefinidas.Add(BtnSieteGato, BtnSieteGato.Source);
            imagenesPredefinidas.Add(BtnOchoGato, BtnOchoGato.Source);
            imagenesPredefinidas.Add(BtnNueveGato, BtnNueveGato.Source);
        }


        //metodo para reiniciar el juego
        private void Reset()
        {
            LimpiarImagenes();
            RestaurarImagenesPredefinidas();
            banderaEmpate = 0;
            if (banderaTurno == 1)
                banderaTurno = 2;
            else
                banderaTurno = 1;
        }


        //metodo para limpiar las imágenes de los botones
        private void LimpiarImagenes()
        {
            foreach (ImageButton btn in imagenesPredefinidas.Keys)
            {
                if (btn.Source != null && (EsImagenX(btn.Source) || EsImagenO(btn.Source)))
                {
                    btn.Source = null;
                }
            }
        }

        //metodo para restaurar las imágenes predefinidas en los botones
        private void RestaurarImagenesPredefinidas()
        {
            foreach (var entry in imagenesPredefinidas)
            {
                entry.Key.Source = entry.Value;
            }
        }


        //metodo para agregar puntos al jugador correspondiente y reiniciar el juego
        private void AgregarPuntos()
        {
            if (banderaTurno == 1)
            {
                jug1++;
                lblMarioScore.Text = jug1.ToString();
            }
            else
            {
                jug2++;
                lblYoshiScore.Text = jug2.ToString();
            }
            Reset();
        }


        //metodo para verificar si un jugador ha ganado o si hay un empate
        private void Comprobar()
        {
            ImageSource img1 = BtnUnoGato.Source;
            ImageSource img2 = BtnDosGato.Source;
            ImageSource img3 = BtnTresGato.Source;
            ImageSource img4 = BtnCuatroGato.Source;
            ImageSource img5 = BtnCincoGato.Source;
            ImageSource img6 = BtnSeisGato.Source;
            ImageSource img7 = BtnSieteGato.Source;
            ImageSource img8 = BtnOchoGato.Source;
            ImageSource img9 = BtnNueveGato.Source;

            string nombreJugador = (banderaTurno == 1) ? "Mario" : "Yoshi";


            //comprobamos que el boton 1, 2 y 3 para el ganador
            if (img1 != null && img1.Equals(img2) && img1.Equals(img3))
            {
                DisplayAlert("¡Ganó " + nombreJugador + "!", "", "OK");
                //agrega puntos
                AgregarPuntos();
            }
            //comprobamos que el boton 1, 4 y 7 para el ganador
            else if (img1 != null && img1.Equals(img4) && img1.Equals(img7))
            {
                DisplayAlert("¡Ganó " + nombreJugador + "!", "", "OK");
                //agrega puntos
                AgregarPuntos();
            }

            //comprobamos que el boton 1, 5 y 9 para el ganador
            else if (img1 != null && img1.Equals(img5) && img1.Equals(img9))
            {
                DisplayAlert("¡Ganó " + nombreJugador + "!", "", "OK");
                //agrega puntos
                AgregarPuntos();
            }

            //comprobamos que el boton 2, 5 y 8 para el ganador
            else if (img2 != null && img2.Equals(img5) && img2.Equals(img8))
            {
                DisplayAlert("¡Ganó " + nombreJugador + "!", "", "OK");
                //agrega puntos
                AgregarPuntos();
            }

            //comprobamos que el boton 3, 6 y 9 para el ganador
            else if (img3 != null && img3.Equals(img6) && img3.Equals(img9))
            {
                DisplayAlert("¡Ganó " + nombreJugador + "!", "", "OK");
                //agrega puntos
                AgregarPuntos();
            }

            //comprobamos que el boton 3, 5 y 7 para el ganador
            else if (img3 != null && img3.Equals(img5) && img3.Equals(img7))
            {
                DisplayAlert("¡Ganó " + nombreJugador + "!", "", "OK");
                //agrega puntos
                AgregarPuntos();
            }

            //comprobamos que el boton 4, 5 y 6 para el ganador
            else if (img4 != null && img4.Equals(img5) && img4.Equals(img6))
            {
                DisplayAlert("¡Ganó " + nombreJugador + "!", "", "OK");
                //agrega puntos
                AgregarPuntos();
            }

            //comprobamos que el boton 7, 8 y 9 para el ganador
            else if (img7 != null && img7.Equals(img8) && img7.Equals(img9))
            {
                DisplayAlert("¡Ganó " + nombreJugador + "!", "", "OK");
                //agrega puntos
                AgregarPuntos();
            }
            else
            {

                //si empatan entonces sumamos en el marcador
                banderaEmpate++;
                if (banderaEmpate == 9)//empata cuando los 9 botones esten llenos y compruebe que nadie gano
                {
                    DisplayAlert("Nadie gana, es un empate", "", "OK");
                    empate++;
                    lblEmpateScore.Text = empate.ToString();
                    Reset();
                }
            }
        }


        //metodo para manejar el clic en un botón
        private void Escribir(ImageButton a)
        {
            if (!EsImagenX(a.Source) && !EsImagenO(a.Source))
            {

                //si el turno es para el 1 entonces pondra la imagen 
                if (banderaTurno == 1)
                {
                    a.Source = imagenX;
                    Comprobar();//comprobamos
                    banderaTurno = 2;
                }
                //si el turno es para el 2 entonces pondra la imagen
                else if (banderaTurno == 2)
                {
                    a.Source = imagenO;
                    Comprobar();//comprobamos
                    banderaTurno = 1;
                }
            }
            else
            {
                //si hay una imagen en el boton le mandamos una alerta
                DisplayAlert("Advertencia", "Ya hay una imagen en este botón.", "OK");
            }
        }


        //metodo para verificar si la imagen es la imagen de X (Mario)
        private bool EsImagenX(ImageSource imagen)
        {
            return imagen != null && imagen.Equals(imagenX);
        }


        //metodo para verificar si la imagen es la imagen de O (Yoshi)
        private bool EsImagenO(ImageSource imagen)
        {
            return imagen != null && imagen.Equals(imagenO);
        }


        //manejadores de eventos click para cada botón en el formulario hasta el 9
        private void BotonGatoUno(object sender, EventArgs e)
        {
            Escribir(BtnUnoGato);
        }

        private void BotonGatoDos(object sender, EventArgs e)
        {
            Escribir(BtnDosGato);
        }

        private void BotonGatoTres(object sender, EventArgs e)
        {
            Escribir(BtnTresGato);
        }

        private void BotonGatoCuatro(object sender, EventArgs e)
        {
            Escribir(BtnCuatroGato);
        }

        private void BotonGatoCinco(object sender, EventArgs e)
        {
            Escribir(BtnCincoGato);
        }

        private void BotonGatoSeis(object sender, EventArgs e)
        {
            Escribir(BtnSeisGato);
        }

        private void BotonGatoSiete(object sender, EventArgs e)
        {
            Escribir(BtnSieteGato);
        }

        private void BotonGatoOcho(object sender, EventArgs e)
        {
            Escribir(BtnOchoGato);
        }

        private void BotonGatoNueve(object sender, EventArgs e)
        {
            Escribir(BtnNueveGato);
        }

        
    }
}
