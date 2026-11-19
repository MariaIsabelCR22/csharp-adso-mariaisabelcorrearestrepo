namespace Reto;

class Program
{
    static void Main()
    {
        List<Producto> inventario = new List<Producto>();
        List<LineaVenta> carrito = new List<LineaVenta>();

        inventario.Add(new Producto("P1", "Arroz", 4500, 20));
        inventario.Add(new Producto("P2", "Aceite", 12000, 10)); 
        inventario.Add(new Producto("P3", "Azucar", 3500, 15));

        int opcion = 0;

        while (opcion != 6)
        {
            Console.WriteLine("\n--- TIENDA ---");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Agregar stock");
            Console.WriteLine("3. Vender producto");
            Console.WriteLine("4. Ver carrito");
            Console.WriteLine("5. Ver inventario");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opcion: ");

            try
            {
                opcion = int.Parse(Console.ReadLine()!);

                if (opcion == 1)
                {
                    Console.Write("Codigo: ");
                    string codigo = Console.ReadLine()!;

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine()!;

                    Console.Write("Precio: ");
                    decimal precio = decimal.Parse(Console.ReadLine()!);

                    Console.Write("Stock inicial: ");
                    int stock = int.Parse(Console.ReadLine()!);

                    if (inventario.Any(p => p.Codigo == codigo.Trim()))
                    {
                        Console.WriteLine("Ese codigo ya existe");
                    }
                    else
                    {
                        Producto producto = new Producto(codigo, nombre, precio, stock);
                        inventario.Add(producto);
                        Console.WriteLine("Producto registrado");
                    }
                }
                else if (opcion == 2)
                {
                    Console.Write("Codigo del producto: ");
                    string codigo = Console.ReadLine()!;

                    Producto? producto = inventario.FirstOrDefault(p => p.Codigo == codigo.Trim());

                    if (producto == null)
                    {
                        Console.WriteLine("Producto no encontrado");
                    }
                    else
                    {
                        Console.Write("Cantidad para agregar: ");
                        int cantidad = int.Parse(Console.ReadLine()!);

                        producto.AgregarStock(cantidad);
                        Console.WriteLine("Stock actualizado");
                    }
                }
                else if (opcion == 3)
                {
                    Console.Write("Codigo del producto: ");
                    string codigo = Console.ReadLine()!;

                    Producto? producto = inventario.FirstOrDefault(p => p.Codigo == codigo.Trim());

                    if (producto == null)
                    {
                        Console.WriteLine("Producto no encontrado");
                    }
                    else
                    {
                        Console.Write("Cantidad para vender: ");
                        int cantidad = int.Parse(Console.ReadLine()!);

                        if (producto.Vender(cantidad))
                        {
                            decimal subtotal = producto.Precio * cantidad;

                            LineaVenta linea = new LineaVenta(
                                producto.Codigo,
                                producto.Nombre,
                                cantidad,
                                subtotal
                            );

                            carrito.Add(linea);
                            Console.WriteLine("Venta agregada al carrito");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad invalida o stock insuficiente");
                        }
                    }
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\n--- CARRITO ---");

                    if (carrito.Count == 0)
                    {
                        Console.WriteLine("El carrito esta vacio");
                    }
                    else
                    {
                        foreach (LineaVenta linea in carrito)
                        {
                            Console.WriteLine(
                                linea.Codigo + " - " +
                                linea.Nombre + " - Cantidad: " +
                                linea.Cantidad + " - Subtotal: $" +
                                linea.Subtotal
                            );
                        }

                        decimal total = carrito.Sum(l => l.Subtotal);
                        Console.WriteLine("Total: $" + total);
                    }
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("\n--- INVENTARIO ---");

                    foreach (Producto producto in inventario)
                    {
                        Console.WriteLine(
                            producto.Codigo + " - " +
                            producto.Nombre + " - Precio: $" +
                            producto.Precio + " - Stock: " +
                            producto.Stock
                        );
                    }
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("Hasta luego");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo realizar la operacion: " + ex.Message);
            }
        }
    }
}
