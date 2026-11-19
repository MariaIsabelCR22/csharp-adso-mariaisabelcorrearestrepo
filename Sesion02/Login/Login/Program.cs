using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su usuario:");
            string user = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Ingrese su contraseña:");
            string pass = Console.ReadLine().ToLower().Trim();

            if (user == "admin" && pass == "12345")
            {
                Console.WriteLine("Bienvenido al Sistema");

                Console.WriteLine("Calculadora con Switch");

                Console.WriteLine("Digite el valor para A");
                string entrada = Console.ReadLine().Trim();
                int variableA = Convert.ToInt32(entrada);

                Console.WriteLine("Digite el valor para B");
                float variableB = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la opcion deseada:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Nota");

                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"La suma de {variableA} + {variableB} es {variableA + variableB}");
                        break;

                    case 2:
                        Console.WriteLine($"La resta de {variableA} - {variableB} es {variableA - variableB}");
                        break;

                    case 3:
                        Console.WriteLine($"La multiplicacion de {variableA} * {variableB} es {variableA * variableB}");
                        break;

                    case 4:
                        if (variableB == 0)
                            Console.WriteLine("No se puede dividir entre cero (0)");
                        else
                            Console.WriteLine($"La division de {variableA} / {variableB} es {variableA / variableB}");
                        break;

                    case 5:
                        double nota = Convert.ToDouble(Console.ReadLine());

                        if (nota < 0 || nota > 5)
                            Console.WriteLine("La nota debe ser entre 0.0 y 5.0");
                        else
                        {
                            if (nota <= 3.0)
                                Console.WriteLine("Nota: Es insuficiente");
                            else if (nota < 4)
                                Console.WriteLine("Nota: Es aceptable");
                            else if (nota < 4.6)
                                Console.WriteLine("Nota: Es Sobresaliente");
                            else
                                Console.WriteLine("Nota: Exelente");
                        }

                        break;
                       
                    default:
                        Console.WriteLine("Eleccion inconrrecta");
                        break;

                }

            }

            else
            {
                Console.WriteLine("Error en el usuario o contraseña");
            }

        }
    }
}
