using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1) SEGUNDOS A RELOJ");

            Console.Write("ingrese una cantidad de segundos: ");
            bool datoValido = int.TryParse(Console.ReadLine(), out int segundos);

            if (datoValido && segundos >= 0)
            {
                int horas = segundos / 3600;
                int minutos = (segundos % 3600) / 60;
                int resto = segundos % 60;

                Console.WriteLine(horas + " h " + minutos + " min " + resto + " s");
            }
            else
            {
                Console.WriteLine("ERRO ingrese un numero entero positivo");
            }

            Console.WriteLine();

            Console.WriteLine("2) TEMPERATURA");

            Console.Write("ingrese la temperatura en celsius: ");
            bool temperaturaValida = double.TryParse(Console.ReadLine(), out double celsius);

            if (temperaturaValida)
            {
                double fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine("Temperatura en fahrenheit: " + fahrenheit);
            }
            else
            {
                Console.WriteLine("ERROR debes ingresar un numero");
            }

            Console.WriteLine();

            Console.WriteLine("3) PROMEDIO DE NOTAS");

            Console.Write("ingrese la primera nota: ");
            bool nota1Valida = double.TryParse(Console.ReadLine(), out double nota1);

            Console.Write("ingrese la segunda nota: ");
            bool nota2Valida = double.TryParse(Console.ReadLine(), out double nota2);

            Console.Write("ingrese la tercera nota: ");
            bool nota3Valida = double.TryParse(Console.ReadLine(), out double nota3);

            if (nota1Valida && nota2Valida && nota3Valida &&
                nota1 >= 0 && nota1 <= 5 &&
                nota2 >= 0 && nota2 <= 5 &&
                nota3 >= 0 && nota3 <= 5)
            {
                double promedio = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine("el promedio es: " + promedio.ToString("N1"));
            }
            else
            {
                Console.WriteLine("ERROR las notas deben ser numeros entre 0 y 5");
            }

            Console.WriteLine("fin de los ejercicios");

        }
    }
}
