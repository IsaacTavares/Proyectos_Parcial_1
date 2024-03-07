using System;

namespace calcularAreaPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define el color del texto
            System.Console.ForegroundColor = ConsoleColor.Green;
            char TipoFigura, APC, APR, APT, APCI;
            bool repetirPrograma = true;


            //metemos todo el codigo en un ciclo while para que ejecute hasta que le indiquemos que no
            while (repetirPrograma)
            {

                //preguntamos que figura quiere conocer su area y/o perimetro
                Console.Write("Que figura quiere conocer su perimetro y area (c cuadrado, r rectangulo, t triangulo, i circulo): ");
                TipoFigura = Convert.ToChar(Console.ReadLine());


                //si es cuadrado
                if (TipoFigura == 'c')
                {
                    //preguntamos que quiere obtener
                    Console.Write("Que quieres sacar (p perimetro o a area): ");
                    APC = Convert.ToChar(Console.ReadLine());
                    //si es p sera perimetro
                    if (APC == 'p')
                    {
                        perimetroCuadrado();
                    }
                    //si es a sera el área
                    else if (APC == 'a')
                    {
                        areaCuadrado();
                    }
                }

                //si es rectangulo
                else if (TipoFigura == 'r')
                {
                    //preguntamos que quiere obtener
                    Console.Write("Que quieres sacar (p perimetro o a area): ");
                    APR = Convert.ToChar(Console.ReadLine());
                    //si es p sera perimetro
                    if (APR == 'p')
                    {
                        perimetroRectangulo();
                    }

                    //si es a sera área
                    else if (APR == 'a')
                    {
                        areaRectangulo();
                    }
                }
                //si es triangulo
                else if (TipoFigura == 't')
                {
                    //preguntamos que quiere obtener
                    Console.Write("Que quieres sacar (p perimetro o a area): ");
                    APT = Convert.ToChar(Console.ReadLine());
                    //si es p sera perimetro
                    if (APT == 'p')
                    {
                        perimetroTriangulov();
                    }

                    //si es a sera área
                    else if (APT == 'a')
                    {
                        areaTriangulo();
                    }
                }

                //si es circulo
                else if (TipoFigura == 'i')
                {
                    //preguntamos que quiere obtener
                    Console.Write("Que quieres sacar (p perimetro o a area): ");
                    APCI = Convert.ToChar(Console.ReadLine());
                    //si es p sera perimetro
                    if (APCI == 'p')
                    {
                        perimetroCirculo();
                    }
                    //si es a sera área
                    else if (APCI == 'a')
                    {
                        areaCirculo();
                    }
                }
                //preguntamos si quiere realizar  otra operacion y si dice que si volvera a ejecutarse y si no quiere se termina la ejecucion
                Console.Write("¿Deseas realizar otra operación? (s/n): ");
                char respuesta = Convert.ToChar(Console.ReadLine());
                if (respuesta == 's')
                {
                    repetirPrograma = true;
                }
                else
                {
                    if (respuesta == 'n')
                    {
                        repetirPrograma = false;
                        break;
                    }
                }
            }

            Console.WriteLine("Programa finalizado.");



            //hacemos una funcion para que haga el perimetro del circulo
            void perimetroCirculo()
            {
                Console.Write("Dame el radio del circulo: "); //preguntamos por el radio 
                double radioC = Convert.ToDouble(Console.ReadLine());
                double totalPerimetroCirculo = radioC * 6.28; //hacemos la operacion
                Console.WriteLine("Resultado perimetro del circulo: " + totalPerimetroCirculo); //devolvemos el resultado
            }

            //hacemos una funcion para que haga el area del circulo
            void areaCirculo()
            {
                Console.Write("Ingrese el radio del circulo: "); //preguntamos por el radio 
                double radioCirculo = Convert.ToDouble(Console.ReadLine());
                double radioCuadrado = radioCirculo * radioCirculo;
                double totalareaCirculo = 3.14 * radioCuadrado;//hacemos la operacion
                Console.WriteLine("Resultado área del circulo: " + totalareaCirculo);//devolvemos el resultado
            }

            //hacemos una funcion para que haga el perimetro del cuadrado
            void perimetroCuadrado()
            {
                Console.Write("Ingrese cuanto mide el lado: "); //preguntamos por un lado del cuadrado
                double LadoCuadrado = Convert.ToDouble(Console.ReadLine());
                double totalPerimetro = LadoCuadrado * 4;//hacemos la operacion
                Console.WriteLine("Resultado perimetro del cuadrado: " + totalPerimetro); //entregamos el resultado
            }

            //hacemos una funcion para que haga el area del cuadrado
            void areaCuadrado()
            {
                Console.WriteLine("Ingrese cuanto mide el lado: "); //preguntamos por el lado
                double LadoCuadrado = Convert.ToDouble(Console.ReadLine());
                double totalareaCuadrado = LadoCuadrado * LadoCuadrado;//hacemos la operacion
                Console.WriteLine("Resultado área del cuadrado: " + totalareaCuadrado, Console.ForegroundColor = ConsoleColor.Cyan);//entregamos el resultado
            }

            //funcion para el perimetro del rectangulo
            void perimetroRectangulo()
            {
                Console.Write("Ingrese cuanto mide el lado mas grande del rectangulo: ");//preguntamos por el lado mas grande del rectangulo
                double LadoGrandeRectanguloP = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese cuanto mide el lado mas pequeño del rectangulo: "); //preguntamos por el lado mas pequeño del rectangulo
                double LadoPequeñoRectanguloP = Convert.ToDouble(Console.ReadLine());
                double pruebaxd = LadoGrandeRectanguloP * 2; //hacemos las operaciones
                double ladob = LadoPequeñoRectanguloP * 2;
                double totalPerimetroRectangulo = pruebaxd + ladob;
                Console.WriteLine("Resultado perimetro del rectangulo: " + totalPerimetroRectangulo);//entregamos los resultados
            }


            //funcion para el area del rectangulo
            void areaRectangulo()
            {
                Console.Write("Ingrese la base del rectangulo: "); //pedimos la base del rectangulo
                double baseRectangulo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese la altura del rectangulo: "); //pedimos la altura del rectangulo
                double alturaRectangulo = Convert.ToDouble(Console.ReadLine()); //hacemos las operaciones
                double totalAreaRectangulo = baseRectangulo * alturaRectangulo;
                //entregamos el resultado
                Console.WriteLine("Resultado área del rectangulo: " + totalAreaRectangulo, Console.ForegroundColor = ConsoleColor.Cyan);
            }


            //funcion para el perimetro del triangulo
            void perimetroTriangulov()
            {
                Console.Write("Dame la medida de un lado del triangulo: ");//pedimos un lado del triangulo
                double lado1TP = Convert.ToDouble(Console.ReadLine());
                double perimetroTriangulo = lado1TP * 3; //hacemos las operaciones
                Console.WriteLine("Resultado perimetro de triangulo: " + perimetroTriangulo);//entregamos el resultado
            }

            //Operacion para el area del triangulo equilatero
            void areaTriangulo()
            {
                Console.Write("Ingrese la base del triangulo: "); //pedimos la base del triangulo
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese la altura del triangulo: "); //la altura
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                double totalAreaTriangulo = baseTriangulo * alturaTriangulo / 2;//hacemos las operaciones
                //entregamos el reultado
                Console.WriteLine("Resultado del área del triangulo: " + totalAreaTriangulo, Console.ForegroundColor = ConsoleColor.Cyan);
            }
        }
    }
}