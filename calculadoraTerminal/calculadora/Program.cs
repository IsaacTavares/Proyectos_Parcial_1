using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //definimos unas variables que se ocuparan 
            char operador;
            double num1, num2, resultado;
            bool VolverEjecutar;



            //metemos todo el codigo en un ciclo while para que se este ejecutando hasta que lo detengamos
            while (true)
            {
                VolverEjecutar = false;

                //pedimos que ingrese la operacion

                Console.Write("Ingrese la operacion (+, - , * /): ");
                operador = Convert.ToChar(Console.ReadLine());//la leemos


                //una validacion para ver que el usuario haya escrito un caracter que le pedimos
                if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
                {
                    Console.WriteLine("Error: Operador no válido.");
                    continue; 
                }

                //pedimos que ingrese el primer numero
                Console.Write("Ingrese el primer numero: ");
                num1 = Convert.ToDouble(Console.ReadLine()); //leemos


                //pedimos que ingrese el segundo numero
                Console.Write("Ingrese el segundo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());//leemos


                //ponemos un switch para que realizo lo que el usuario puse de operador
                switch (operador)
                { 
                    //si es suma entonces los dos numeros ingrsados se suman
                    case '+':
                        resultado = num1 + num2;
                        break;
                    //si es resta entonces los dos numeros ingrsados se restan
                    case '-':
                        resultado = num1 - num2;
                        break;
                    //si es multiplicacion entonces los dos numeros ingrsados se multiplican
                    case '*':
                        resultado = num1 * num2;
                        break;
                    //si es division entonces los dos numeros ingrsados se dividen
                    case '/':

                        //primero comprobamos que no haya escrito un numero 0 
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division por 0 no permitida");
                            return;
                        }
                        break;
                    default:
                        //si no se cumple entonces un error
                        Console.WriteLine("Error: Operador no válido");
                        return;
                }

                //imprimimos el resultado al usuario
                Console.WriteLine("Resultado: " + resultado);

                // preguntar al usuario si desea volver a ejecutar el programa
                Console.Write("¿Desea volver a ejecutar? (S/N): ");
                char respuesta = Convert.ToChar(Console.ReadLine());

                //si la respuesta es s es que se volvera a ejecutar la calculadora
                if (respuesta == 's')
                {
                    VolverEjecutar = true;
                }

                //si no
                else
                {
                    //si la respuesta es n se detendra la calculadora
                    if (respuesta == 'n')
                    {
                        VolverEjecutar = false;
                        break;
                    }
                }
            }
        }
    }
}
