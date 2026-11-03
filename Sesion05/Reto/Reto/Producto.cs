
namespace Reto;

public class Producto
{
    private string _nombre = "";
    private decimal _precio;

    public string Codigo { get; private set; }

    public string Nombre
    {
        get { return _nombre; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacio");

            _nombre = value.Trim();
        }
    }

    public decimal Precio
    {
        get { return _precio; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero");

            _precio = value;
        }
    }

    public int Stock { get; private set; }

    public Producto(string codigo, string nombre, decimal precio, int stock)
    {
        if (string.IsNullOrWhiteSpace(codigo))
            throw new ArgumentException("El codigo no puede estar vacio");

        if (codigo != codigo.ToUpper())
            throw new ArgumentException("El codigo debe estar en mayusculas");

        if (stock < 0)
            throw new ArgumentException("El stock no puede ser negativo");

        Codigo = codigo.Trim();
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    public void AgregarStock(int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentException("La cantidad debe ser mayor que cero");

        Stock += cantidad;
    }

    public bool Vender(int cantidad)
    {
        if (cantidad <= 0 || cantidad > Stock)
            return false;

        Stock -= cantidad;
        return true;
    }
}
