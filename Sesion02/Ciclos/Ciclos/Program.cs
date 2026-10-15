using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Ciclos

            //for (int i = 0;i <= 10; i++)
            //{
            //    Console.WriteLine($"Valor {i}");
            //}

            ////Cickis di - while

            //int edad;
            //do
            //{
            //    Console.WriteLine("Digite su edad:");
            //} while (!int.TryParse(Console.ReadLine(), out edad) || edad < 1 || edad > 120);

            //int suma = 0;
            //for (int i = 1; i < 5; i++)
            //{
            //    Console.Write($"Puntaje {i}: ");

            //    int.TryParse(Console.ReadLine(), out int puntaje);
            //    suma += puntaje;
            //}
            //double promedio = suma / 5.0;
            //Console.WriteLine($"Promedio: {promedio}");

            Console.WriteLine("TABLAS MULTIPLICAR");

            double numero;
            do
            {
                Console.WriteLine("Digite un numero para generar su tabla de multiplicar");
            } while (!double.TryParse(Console.ReadLine(), out numero));

            Console.WriteLine($"Tabla del {numero}");
            for (int i = 1; i < 11; i++)
                Console.WriteLine($"{numero} * {i} es {i * numero}");



        }
    }
}
