
using System;

namespace Tarea;

class Program
{
    static void Main()
    {
        CuentaBancaria cuenta1 = new CuentaBancaria("Maria", "001", 500000);
        CuentaBancaria cuenta2 = new CuentaBancaria("Carlos", "002", 200000);

        Console.WriteLine("--- CUENTAS BANCARIAS ---");

        Console.WriteLine("Saldo inicial de Maria: $" + cuenta1.Saldo);
        Console.WriteLine("Saldo inicial de Carlos: $" + cuenta2.Saldo);

        Console.WriteLine("\n--- DEPOSITO ---");

        if (cuenta1.Depositar(100000))
        {
            Console.WriteLine("Deposito realizado correctamente");
        }
        else
        {
            Console.WriteLine("No se pudo realizar el deposito");
        }

        Console.WriteLine("Saldo de Maria: $" + cuenta1.Saldo);

        Console.WriteLine("\n--- RETIRO RECHAZADO ---");

        if (cuenta2.Retirar(500000))
        {
            Console.WriteLine("Retiro realizado correctamente");
        }
        else
        {
            Console.WriteLine("No se pudo realizar el retiro");
        }

        Console.WriteLine("Saldo de Carlos: $" + cuenta2.Saldo);

        Console.WriteLine("\n--- TRANSFERENCIA ---");

        if (cuenta1.Transferir(cuenta2, 150000))
        {
            Console.WriteLine("Transferencia realizada correctamente");
        }
        else
        {
            Console.WriteLine("No se pudo realizar la transferencia");
        }

        Console.WriteLine("Saldo final de Maria: $" + cuenta1.Saldo);
        Console.WriteLine("Saldo final de Carlos: $" + cuenta2.Saldo);
    }
}
