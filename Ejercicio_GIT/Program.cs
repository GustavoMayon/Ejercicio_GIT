using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entradaOpcion, entrada1, entrada2;
            double num1, num2, resultado;
            bool continuar = true;

            do
            {
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Salir");

                Console.Write("Ingresa una opcion: ");
                entradaOpcion = Console.ReadLine();
                int.TryParse(entradaOpcion, out int opcion);
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el primer numero");
                        entrada1 = Console.ReadLine();
                        if (double.TryParse(entrada1, out  num1))
                        {
                            Console.WriteLine("Ingrese el segundo numero");
                            entrada2 = Console.ReadLine();
                            if (double.TryParse(entrada2, out num2))
                            {
                                resultado = Suma(num1, num2);
                                Console.WriteLine($"La suma es: {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el primer numero");
                        entrada1 = Console.ReadLine();
                        if (double.TryParse(entrada1, out num1))
                        {
                            Console.WriteLine("Ingrese el segundo numero");
                            entrada2 = Console.ReadLine();
                            if (double.TryParse(entrada2, out num2))
                            {
                                resultado = Resta(num1, num2);
                                Console.WriteLine($"La Resta es: {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el primer numero");
                        entrada1 = Console.ReadLine();
                        if (double.TryParse(entrada1, out num1))
                        {
                            Console.WriteLine("Ingrese el segundo numero");
                            entrada2 = Console.ReadLine();
                            if (double.TryParse(entrada2, out num2))
                            {
                                resultado = Multiplicacion(num1, num2);
                                Console.WriteLine($"La multiplicación es: {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número");
                        }
                        break;
                    case 4:
                        continuar = false;
                        Console.WriteLine("¡Adios!");
                        break;
                    default:
                        Console.WriteLine("¡Ingresa una opción válida!");
                        break;
                }
            } while (continuar);
        }
        static double Suma(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }
        static double Resta(double num1, double num2)
        {
            double resultado = num1 - num2;
            return resultado;
        }
        static double Multiplicacion(double num1, double num2)
        {
            double resultado = num1 * num2;
            return resultado;
        }
    }
}
