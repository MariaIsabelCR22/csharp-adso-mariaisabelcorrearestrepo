namespace Inventario.Modelos;

public class StockInsuficienteException : Exception
{
    public StockInsuficienteException(string mensaje) : base(mensaje)
    {
    }
}