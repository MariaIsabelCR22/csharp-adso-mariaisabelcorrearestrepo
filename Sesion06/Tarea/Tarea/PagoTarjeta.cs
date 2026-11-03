namespace Tarea;

public class PagoTarjeta : IMetodoPago, IReembolsable
{
    public string Nombre => "Tarjeta";

    public string NumeroTarjeta { get; private set; }

    public PagoTarjeta(string numeroTarjeta)
    {
        NumeroTarjeta = numeroTarjeta;
    }

    public decimal CalcularComision(decimal monto)
    {
        return monto * 0.03m;
    }

    public bool Validar(decimal monto)
    {
        return monto > 0 && NumeroTarjeta.Length == 16 &&
               NumeroTarjeta.All(char.IsDigit);
    }

    public void Reembolsar(decimal monto)
    {
        Console.WriteLine($"Reembolso de tarjeta: ${monto:N0}");
    }
}