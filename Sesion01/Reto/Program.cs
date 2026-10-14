using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // pedimos el nombre de la persona
            Console.Write("Digita tu nombre: ");
            string nombre = Console.ReadLine();

            // programa de formacion de la persona
            Console.Write("Digita tu programa de formacion: ");
            string programa = Console.ReadLine();

            // numero de ficha de la persona
            Console.Write("Dime tu numero de ficha: ");
            string ficha = Console.ReadLine();

            // pedir que se escriba una frase que nos represente
            Console.Write("Escribe una frase que te represente: ");
            string frase = Console.ReadLine();

            Console.WriteLine();

            // poniendo el titulo en rojo
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("RESPUESTAS");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==============================================");

            // mostramos la tarjeta con los datos 
            Console.WriteLine($"Su nombres es: {nombre}");
            Console.WriteLine($"Usted esta en el programa de formacion: {programa}");
            Console.WriteLine($"Su ficha es: {ficha}");
            Console.WriteLine($"La frase que te representa es: {frase}");

            Console.WriteLine("==============================================");

            Console.ResetColor();

        }
    }
}
