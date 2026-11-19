namespace Tarea;

public class ProcesadorPagos
{
    public void Cobrar(IMetodoPago metodo, decimal monto)
    {
        if (metodo.Validar(monto))
        {
            decimal comision = metodo.CalcularComision(monto);
            decimal total = monto + comision;

            Console.WriteLine($"Metodo: {metodo.Nombre}");
            Console.WriteLine($"Monto: ${monto:N0}");
            Console.WriteLine($"Comision: ${comision:N0}");
            Console.WriteLine($"Total a pagar: ${total:N0}");
        }
        else
        {
            Console.WriteLine("El pago no es valido");
        }
    }

    public void Devolver(IMetodoPago metodo, decimal monto)
    {
        if (metodo is IReembolsable reembolsable)
        {
            reembolsable.Reembolsar(monto);
        }
        else
        {
            Console.WriteLine("Este metodo de pago no permite reembolsos");
        }
    }
}