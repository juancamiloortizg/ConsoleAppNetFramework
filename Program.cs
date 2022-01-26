using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenid@!");
            Console.WriteLine("Por favor selecciona una de las siguientes opciones.");
            Console.WriteLine($"{Environment.NewLine}1. Calcular IMC.{Environment.NewLine}2. Calcular calorias quemadas.{Environment.NewLine}3. Salir.");
            string eleccionUsuario = Console.ReadLine();
            if (eleccionUsuario != null)
            {
                if (Int32.TryParse(eleccionUsuario, out int eleccion))
                {
                    switch (eleccion)
                    {
                        case 1:
                            CalcularIMC();
                            break;
                        case 2:
                            CalcularCalorias();
                            break;
                        case 3:
                            Console.WriteLine("Presiona cualquier tecla para salir.");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("No es una opción valida. Presione una tecla para salir.");
                            Console.ReadKey(true);
                            break;
                    }
                } else
                {
                    Console.WriteLine("La elección del menú debe ser un valor numerico. Presiona una tecla para finalizar:");
                    Console.ReadKey(true);
                }
            }

            void CalcularCalorias()
            {
                Console.WriteLine("En construcción.");
                return;
            }


            void CalcularIMC()
            {
                Console.WriteLine($"{Environment.NewLine}Ingrese su peso en kg:");
                string peso = Console.ReadLine();
                Console.WriteLine($"{Environment.NewLine}Ingrese su estatura en centimetros:");
                string estatura = Console.ReadLine();
                if (peso != null && estatura != null)
                {
                    if (Double.TryParse(peso, out double pesoUsuario) && Double.TryParse(estatura, out double estaturaUsuario))
                    {
                        estaturaUsuario = estaturaUsuario / 100;    // Conversión a metros.
                        double imc = pesoUsuario / (estaturaUsuario * estaturaUsuario);
                        Console.WriteLine($"Su IMC calculado es de {String.Format("{0:0.00}", imc)}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Los valores deben de numericos.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Los valores no pueden ser vacíos.");
                    return;
                }
            }

        }


    }
}