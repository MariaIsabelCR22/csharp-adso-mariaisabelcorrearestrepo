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
            int intentosMax = 3;
            int intentosAct = 0;
            double cantidadtot = 500000;

            while (intentosAct < intentosMax) {

                if (intentosAct > intentosMax)
                    Console.WriteLine("Demadiados intentos, intentalo de nuevo");

                Console.WriteLine("Ingrese su usuario:");
                string user = Console.ReadLine().ToLower().Trim();

                Console.WriteLine("Ingrese su contraseña:");
                string pass = Console.ReadLine().ToLower().Trim();

                if (user == "maria" && pass == "123")
                {
                    Console.WriteLine("¡Bienvenido a tu cajero!");
                    Console.WriteLine("Menu del Cajero:");

                    Console.WriteLine("Digite la opcion deseada:");
                    Console.WriteLine("1. Consultar saldo");
                    Console.WriteLine("2. Depositar");
                    Console.WriteLine("3. Retira");
                    Console.WriteLine("4. Salir");

                    int opc = Convert.ToInt32(Console.ReadLine());

                    while (opc !=4)
                    {

                        switch (opc)
                        {
                            case 1:
                                Console.WriteLine($"tu saldo actual es de {cantidadtot}");
                                break;
                            case 2:
                                Console.WriteLine("Cuanto desea depositar?");
                                double deposito = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"La cantidad depositada fue de {deposito}");
                                cantidadtot += deposito;
                                break;
                            case 3:
                                Console.WriteLine("Cuanto desea retirar?");
                                double retiro = Convert.ToDouble(Console.ReadLine());
                                if (retiro > cantidadtot || retiro % 10000 != 0)
                                    Console.WriteLine("No tienes la cantidad suficiente para retirar o debes retirar en valores de 10000");
                                else
                                    cantidadtot -= retiro;
                                Console.WriteLine($"Su sueldo actual es de {cantidadtot}");
                                break;
                            default:
                                Console.WriteLine("Opcion incorrecta");
                                break;
                        }

                        Console.WriteLine("Menu del Cajero:");

                        Console.WriteLine("Digite la opcion deseada:");
                        Console.WriteLine("1. Consultar saldo");
                        Console.WriteLine("2. Depositar");
                        Console.WriteLine("3. Retira");
                        Console.WriteLine("4. Salir");

                        opc = Convert.ToInt32(Console.ReadLine());

                    }
                    Console.WriteLine("Gracias por utilizar el cajero, nos vemos!");
                    return;
                }
                else
                {
                    intentosAct++;
                    Console.WriteLine("Intentalo de nuevo");
                }    
            }       
        }
    } 
}
