
using Inventario.Modelos;
using Inventario.Datos;

namespace Inventario.Servicios;

public class ServicioInventario
{
    private readonly IRepositorioProductos _repositorio;

    public ServicioInventario(IRepositorioProductos repositorio)
    {
        _repositorio = repositorio;
    }

    public List<Producto> Listar()
    {
        return _repositorio.ObtenerTodos()
            .OrderBy(p => p.Nombre)
            .ToList();
    }

    public void Agregar(Producto producto)
    {
        if (_repositorio.BuscarPorCodigo(producto.Codigo) != null)
            throw new ArgumentException("Ya existe un producto con ese codigo");

        _repositorio.Agregar(producto);
    }

    public void AgregarStock(string codigo, int cantidad)
    {
        Producto? producto = _repositorio.BuscarPorCodigo(codigo);

        if (producto == null)
            throw new ArgumentException("El producto no existe");

        producto.AgregarStock(cantidad);

        _repositorio.Actualizar(producto);
    }

    public void Vender(string codigo, int cantidad)
    {
        Producto? producto = _repositorio.BuscarPorCodigo(codigo);

        if (producto == null)
            throw new ArgumentException("El producto no existe");

        producto.Vender(cantidad);

        _repositorio.Actualizar(producto);
    }

    public List<Producto> StockBajo()
    {
        return _repositorio.ObtenerTodos()
            .Where(p => p.Stock < 5)
            .ToList();
    }


    public List<Producto> BuscarPorTexto(string texto)
    {
        return _repositorio.ObtenerTodos()
            .Where(p =>
                p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public void Eliminar(string codigo)
    {
        Producto? producto = _repositorio.BuscarPorCodigo(codigo);

        if (producto == null)
            throw new ArgumentException("El producto no existe");

        _repositorio.Eliminar(codigo);
    }

}