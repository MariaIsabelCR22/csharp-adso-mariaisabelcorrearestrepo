
using Inventario.Modelos;
using Inventario.Datos;
using Inventario.Servicios;

ServicioInventario servicio = new(
    new RepositorioJson("inventario.json"));

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n===== INVENTARIO =====");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender producto");
    Console.WriteLine("4. Ver inventario");
    Console.WriteLine("5. Ver productos con stock bajo");
    Console.WriteLine("6. Buscar producto por texto");
    Console.WriteLine("7. Eliminar producto");
    Console.WriteLine("8. Salir");
    Console.Write("Seleccione una opcion: ");

    string opcion = Console.ReadLine() ?? "";

    try
    {
        switch (opcion)
        {
            case "1":
                Console.Write("Codigo: ");
                string codigo = Console.ReadLine() ?? "";

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";

                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine() ?? "");

                Console.Write("Stock inicial: ");
                int stock = int.Parse(Console.ReadLine() ?? "");

                Producto nuevo = new(codigo, nombre, precio, stock);

                servicio.Agregar(nuevo);

                Console.WriteLine("Producto registrado correctamente");
                break;

            case "2":
                Console.Write("Codigo del producto: ");
                string codigoStock = Console.ReadLine() ?? "";

                Console.Write("Cantidad a agregar: ");
                int cantidadStock = int.Parse(Console.ReadLine() ?? "");

                servicio.AgregarStock(codigoStock, cantidadStock);

                Console.WriteLine("Stock actualizado correctamente");
                break;

            case "3":
                Console.Write("Codigo del producto: ");
                string codigoVenta = Console.ReadLine() ?? "";

                Console.Write("Cantidad a vender: ");
                int cantidadVenta = int.Parse(Console.ReadLine() ?? "");

                servicio.Vender(codigoVenta, cantidadVenta);

                Console.WriteLine("Venta realizada correctamente");
                break;

            case "4":
                List<Producto> productos = servicio.Listar();

                foreach (Producto producto in productos)
                {
                    Console.WriteLine(
                        $"{producto.Codigo} | {producto.Nombre} | ${producto.Precio} | Stock: {producto.Stock}");
                }
                break;

            case "5":
                List<Producto> bajos = servicio.StockBajo();

                foreach (Producto producto in bajos)
                {
                    Console.WriteLine(
                        $"{producto.Codigo} | {producto.Nombre} | Stock: {producto.Stock}");
                }
                break;

            case "6":
                Console.Write("Ingrese el nombre o codigo a buscar: ");
                string texto = Console.ReadLine() ?? "";

                List<Producto> encontrados = servicio.BuscarPorTexto(texto);

                if (encontrados.Count == 0)
                {
                    Console.WriteLine("No se encontraron productos");
                }
                else
                {
                    foreach (Producto producto in encontrados)
                    {
                        Console.WriteLine(
                            $"{producto.Codigo} | {producto.Nombre} | ${producto.Precio} | Stock: {producto.Stock}");
                    }
                }
                break;

            case "7":
                Console.Write("Ingrese el codigo del producto a eliminar: ");
                string codigoEliminar = Console.ReadLine() ?? "";

                Console.Write("¿Esta seguro de eliminarlo? (s/n): ");
                string confirmacion = Console.ReadLine() ?? "";

                if (confirmacion.Trim().Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    servicio.Eliminar(codigoEliminar);
                    Console.WriteLine("Producto eliminado correctamente");
                }
                else if (confirmacion.Trim().Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Eliminacion cancelada");
                }
                else
                {
                    Console.WriteLine("Respuesta no valida. No se elimino el producto");
                }
                break;

            case "8":
                continuar = false;
                Console.WriteLine("Saliendo del inventario...");
                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
    catch (StockInsuficienteException ex)
    {
        Console.WriteLine($"Error de stock: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
