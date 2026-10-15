using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bienvenido al programa");

            Console.Write("¿Como te llamas?: ");
            string entrada = Console.ReadLine() ?? "";
            string nombre = string.IsNullOrWhiteSpace(entrada) ? "Invitado" : entrada;

            Console.Write("¿En que ciudad vives?: ");
            string entradaCiudad = Console.ReadLine() ?? "";
            string ciudad = string.IsNullOrWhiteSpace(entradaCiudad) ? "una ciudad desconocida" : entradaCiudad;

            Console.WriteLine($"Hola {nombre}, bienvenido desde {ciudad}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gracias por usar el programa");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine(7 / 2);
            Console.WriteLine(7 / 2.0);
            Console.WriteLine(7 % 2);
            Console.WriteLine((10 + 3) * 2);

            int edad = 17;
            double estatura = 1.68;
            decimal precio = 12500.50m;
            bool activo = true;
            char jornada = 'M';
            string nombreEjemplo = "Ana";

            Console.WriteLine(edad);
            Console.WriteLine(estatura);
            Console.WriteLine(precio);
            Console.WriteLine(activo);
            Console.WriteLine(jornada);
            Console.WriteLine(nombreEjemplo);

            string ciudadEjemplo = "Cali";
            const int HorasSemana = 12;

            Console.WriteLine(ciudadEjemplo);
            Console.WriteLine(HorasSemana);

            decimal valor = 1234567.891m;

            Console.WriteLine(valor.ToString("N2"));
            Console.WriteLine(valor.ToString("C0"));

            Console.Write("Ingresa tu edad: ");
            bool edadValida = int.TryParse(Console.ReadLine(), out int edadUsuario);

            if (edadValida)
            {
                Console.WriteLine("Tu edad es: " + edadUsuario);
            }
            else
            {
                Console.WriteLine("Error, ingresa una edad valida.");
            }

            Console.Write("Ingresa la primera nota: ");
            bool nota1Valida = double.TryParse(Console.ReadLine(), out double nota1);

            Console.Write("Ingresa la segunda nota: ");
            bool nota2Valida = double.TryParse(Console.ReadLine(), out double nota2);

            Console.Write("Ingresa la tercera nota: ");
            bool nota3Valida = double.TryParse(Console.ReadLine(), out double nota3);

            if (nota1Valida && nota2Valida && nota3Valida)
            {
                double promedio = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine("El promedio es: " + promedio.ToString("N1"));
            }
            else
            {
                Console.WriteLine("Error, ingresa notas validas.");
            }

            Console.ReadKey();


        }
    }
}
