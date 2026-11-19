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

            Random azar = new Random();
            int secreto = azar.Next(1, 101);
            int maxIntentos = 7;
            int intentos = 0;
            bool acerto = false;

            Console.WriteLine("=== ADIVINA EL NÚMERO ===");
            Console.WriteLine("Pensé un número entre 1 y 100. Tienes 7 intentos.");

            while (intentos < maxIntentos && !acerto)
            {
                Console.Write($"Intento {intentos + 1} de {maxIntentos}: ");

                if (!int.TryParse(Console.ReadLine(), out int numero))
                {
                    Console.WriteLine("Escribe un número válido.");
                    continue;
                }

                intentos++;

                if (numero == secreto)
                {
                    acerto = true;
                }
                else if (numero < secreto)
                {
                    Console.WriteLine("El número secreto es MAYOR.");
                }
                else
                {
                    Console.WriteLine("El número secreto es MENOR.");
                }
            }

            if (acerto)
            {
                Console.WriteLine($"¡Ganaste! Lo adivinaste en {intentos} intento(s).");
            }
            else
            {
                Console.WriteLine($"Se acabaron los intentos. El número era {secreto}.");
            }

        }
    }
}
