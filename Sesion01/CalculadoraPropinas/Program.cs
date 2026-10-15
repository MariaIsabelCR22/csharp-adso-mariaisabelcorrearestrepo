using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPropinas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("calculadora de propinas");
            Console.ResetColor();

            Console.Write("total de la cuenta: ");
            bool okTotal = decimal.TryParse(Console.ReadLine(), out decimal total);

            Console.Write("porcentaje de propina: ");
            bool okPct = decimal.TryParse(Console.ReadLine(), out decimal porcentaje);

            Console.Write("numero de personas: ");
            bool okPersonas = int.TryParse(Console.ReadLine(), out int personas);

            if (okTotal && okPct && okPersonas && total >= 0 && porcentaje >= 0 && personas > 0)
            {
                decimal propina = total * porcentaje / 100m;
                decimal totalFinal = total + propina;
                decimal porPersona = totalFinal / personas;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("propina: $ " + propina.ToString("N0"));
                Console.WriteLine("total: $ " + totalFinal.ToString("N0"));
                Console.WriteLine("cada persona paga: $ " + porPersona.ToString("N0"));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("por favor ingrese datos validos");
                Console.ResetColor();
            }

        }
    }
}
