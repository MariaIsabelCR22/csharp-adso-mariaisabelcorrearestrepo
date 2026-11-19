using System;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcesadorPagos procesador = new ProcesadorPagos();

            IMetodoPago efectivo = new PagoEfectivo();
            IMetodoPago tarjeta = new PagoTarjeta("1234567890123456");
            IMetodoPago billetera = new PagoBilletera();

            Console.WriteLine("===== PAGOS =====");

            procesador.Cobrar(efectivo, 500000m);

            Console.WriteLine();

            procesador.Cobrar(tarjeta, 800000m);

            Console.WriteLine();

            procesador.Cobrar(billetera, 2000000m);

            Console.WriteLine("\n===== REEMBOLSOS =====");

            procesador.Devolver(efectivo, 500000m);

            Console.WriteLine();

            procesador.Devolver(tarjeta, 300000m);

            Console.WriteLine();

            procesador.Devolver(billetera, 200000m);
        }
    }
}