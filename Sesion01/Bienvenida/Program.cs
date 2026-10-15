using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al programa");

            Console.Write("¿Como te llamas?: ");
            string nombre = Console.ReadLine();

            Console.Write("¿En que ciudad vives?: ");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + ", bienvenido desde " + ciudad);

        }
    }
}
