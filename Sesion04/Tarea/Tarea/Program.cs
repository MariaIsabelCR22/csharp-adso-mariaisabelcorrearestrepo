List<Venta> ventas =
[
    new("Portatil", "Medellin", 2, 2_800_000m),
    new("Mouse", "Bogota", 10, 45_000m),
    new("Teclado", "Cali", 5, 120_000m),
    new("Monitor", "Medellin", 3, 750_000m),
    new("Mouse", "Medellin", 8, 45_000m),
    new("Portatil", "Bogota", 1, 2_800_000m),
    new("Diadema", "Cali", 6, 180_000m),
    new("Monitor", "Bogota", 2, 750_000m),
    new("Teclado", "Medellin", 4, 120_000m),
    new("Diadema", "Bogota", 3, 180_000m),
    new("Portatil", "Cali", 2, 2_800_000m),
    new("Mouse", "Cali", 12, 45_000m)
];

// total y promedio
decimal total = ventas.Sum(v => v.Cantidad * v.PrecioUnitario);
decimal promedio = ventas.Average(v => v.Cantidad * v.PrecioUnitario);

Console.WriteLine($"total vendido: ${total:N0}");
Console.WriteLine($"promedio por venta: ${promedio:N0}");

// ventas por ciudad de mayor a menor
var porciudad = ventas
    .GroupBy(v => v.Ciudad)
    .Select(g => new { ciudad = g.Key, total = g.Sum(v => v.Cantidad * v.PrecioUnitario) })
    .OrderByDescending(c => c.total);

Console.WriteLine();
Console.WriteLine("ventas por ciudad:");
foreach (var c in porciudad)
{
    Console.WriteLine($"{c.ciudad,-12} ${c.total:N0}");
}

// top 3 productos por ingresos
var top3 = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new { producto = g.Key, ingresos = g.Sum(v => v.Cantidad * v.PrecioUnitario) })
    .OrderByDescending(p => p.ingresos)
    .Take(3);

Console.WriteLine();
Console.WriteLine("top 3 productos por ingresos:");
foreach (var p in top3)
{
    Console.WriteLine($"{p.producto,-12} ${p.ingresos:N0}");
}

// producto mas vendido en unidades
var masvendido = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new { producto = g.Key, unidades = g.Sum(v => v.Cantidad) })
    .MaxBy(p => p.unidades);

Console.WriteLine();
Console.WriteLine($"mas vendido: {masvendido!.producto} con {masvendido.unidades} unidades");

record Venta(string Producto, string Ciudad, int Cantidad, decimal PrecioUnitario);