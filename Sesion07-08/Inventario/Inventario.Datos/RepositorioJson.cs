
using System.Text.Json;
using Inventario.Modelos;

namespace Inventario.Datos;

public class RepositorioJson : IRepositorioProductos
{
    private readonly string _ruta;

    public RepositorioJson(string ruta)
    {
        _ruta = ruta;
    }

    public List<Producto> ObtenerTodos()
    {
        if (!File.Exists(_ruta))
            return new List<Producto>();

        try
        {
            string json = File.ReadAllText(_ruta);

            return JsonSerializer.Deserialize<List<Producto>>(json)
                   ?? new List<Producto>();
        }
        catch (JsonException)
        {
            File.Copy(_ruta, _ruta + ".danado", true);
            return new List<Producto>();
        }
    }

    private void Guardar(List<Producto> productos)
    {
        var opciones = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(productos, opciones);

        File.WriteAllText(_ruta, json);
    }

    public Producto? BuscarPorCodigo(string codigo)
    {
        return ObtenerTodos()
            .FirstOrDefault(p => p.Codigo == codigo);
    }

    public void Agregar(Producto producto)
    {
        List<Producto> productos = ObtenerTodos();

        productos.Add(producto);

        Guardar(productos);
    }

    public void Actualizar(Producto producto)
    {
        List<Producto> productos = ObtenerTodos();

        int indice = productos.FindIndex(
            p => p.Codigo == producto.Codigo);

        if (indice == -1)
            throw new ArgumentException("El producto no existe");

        productos[indice] = producto;

        Guardar(productos);
    }

    public void Eliminar(string codigo)
    {
        List<Producto> productos = ObtenerTodos();

        Producto? producto = productos
            .FirstOrDefault(p => p.Codigo == codigo);

        if (producto == null)
            throw new ArgumentException("El producto no existe");

        productos.Remove(producto);

        Guardar(productos);
    }
}
