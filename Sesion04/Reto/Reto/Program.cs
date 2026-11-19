Dictionary<string, List<double>> notas = new(StringComparer.OrdinalIgnoreCase);
int opcion = 0;

while (opcion != 7)
{
    Console.WriteLine();
    Console.WriteLine("1. registrar aprendiz");
    Console.WriteLine("2. agregar nota");
    Console.WriteLine("3. listar todos");
    Console.WriteLine("4. ranking");
    Console.WriteLine("5. mejor aprendiz y aprobados");
    Console.WriteLine("6. eliminar aprendiz");
    Console.WriteLine("7. salir");
    Console.Write("opcion: ");

    int.TryParse(Console.ReadLine(), out opcion);

    if (opcion == 1) registrar(notas);
    else if (opcion == 2) agregarnota(notas);
    else if (opcion == 3) listar(notas);
    else if (opcion == 4) ranking(notas);
    else if (opcion == 5) mejoryaprobados(notas);
    else if (opcion == 6) eliminar(notas);
    else if (opcion == 7) Console.WriteLine("chao");
    else Console.WriteLine("opcion no valida");
}

void registrar(Dictionary<string, List<double>> notas)
{
    Console.Write("nombre del aprendiz: ");
    string nombre = Console.ReadLine()!.Trim();

    if (nombre == "")
    {
        Console.WriteLine("el nombre no puede estar vacio");
    }
    else if (notas.ContainsKey(nombre))
    {
        Console.WriteLine("ese aprendiz ya existe");
    }
    else
    {
        notas[nombre] = [];
        Console.WriteLine("aprendiz registrado");
    }
}

void agregarnota(Dictionary<string, List<double>> notas)
{
    Console.Write("nombre del aprendiz: ");
    string nombre = Console.ReadLine()!.Trim();

    if (notas.TryGetValue(nombre, out List<double>? lista))
    {
        Console.Write("nota (0 a 5): ");
        double nota;
        if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 5)
        {
            lista.Add(nota);
            Console.WriteLine("nota agregada");
        }
        else
        {
            Console.WriteLine("nota no valida");
        }
    }
    else
    {
        Console.WriteLine("ese aprendiz no existe");
    }
}

void listar(Dictionary<string, List<double>> notas)
{
    if (notas.Count == 0)
    {
        Console.WriteLine("no hay aprendices");
        return;
    }

    foreach (var a in notas)
    {
        double promedio = 0;
        if (a.Value.Count > 0)
        {
            promedio = a.Value.Average();
        }

        string juicio = "D";
        if (promedio >= 3)
        {
            juicio = "A";
        }

        Console.WriteLine($"{a.Key,-15} {a.Value.Count} notas - promedio {promedio:N1} - {juicio}");
    }
}

void ranking(Dictionary<string, List<double>> notas)
{
    var ordenados = notas
        .Where(a => a.Value.Count > 0)
        .OrderByDescending(a => a.Value.Average());

    int puesto = 1;
    foreach (var a in ordenados)
    {
        Console.WriteLine($"{puesto}. {a.Key,-15} {a.Value.Average():N1}");
        puesto++;
    }

    if (puesto == 1)
    {
        Console.WriteLine("todavia no hay notas");
    }
}

void mejoryaprobados(Dictionary<string, List<double>> notas)
{
    var mejor = notas
        .Where(a => a.Value.Count > 0)
        .OrderByDescending(a => a.Value.Average())
        .FirstOrDefault();

    if (mejor.Key == null)
    {
        Console.WriteLine("todavia no hay notas");
        return;
    }

    int aprobados = notas.Count(a => a.Value.Count > 0 && a.Value.Average() >= 3);

    Console.WriteLine($"mejor aprendiz: {mejor.Key} con {mejor.Value.Average():N1}");
    Console.WriteLine($"aprobados: {aprobados}");
}

void eliminar(Dictionary<string, List<double>> notas)
{
    Console.Write("nombre del aprendiz: ");
    string nombre = Console.ReadLine()!.Trim();

    if (notas.Remove(nombre))
    {
        Console.WriteLine("aprendiz eliminado");
    }
    else
    {
        Console.WriteLine("ese aprendiz no existe");
    }
}