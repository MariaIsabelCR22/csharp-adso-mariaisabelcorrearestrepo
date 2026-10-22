using System.Text;

Console.WriteLine("=== GENERADOR DE USUARIOS ===");
Console.Write("Nombre completo: ");
string nombre = Console.ReadLine();
Console.Write("Documento: ");
string documento = Console.ReadLine();
Console.WriteLine($"Usuario: {GenerarUsuario(nombre, documento)}");

Console.WriteLine();
Console.WriteLine("=== ANALIZADOR DE FRASES ===");
Console.Write("Frase: ");
string frase = Console.ReadLine();
AnalizarFrase(frase);

static string GenerarUsuario(string nombreCompleto, string documento)
{
    nombreCompleto = nombreCompleto.Trim().ToLower();
    documento = documento.Trim();

    string[] partes = nombreCompleto.Split(' ');

    string primerNombre = partes[0];
    string primerApellido;

    // si tiene 4 palabras el primer apellido es la tercera, si tiene 3 es la segunda
    if (partes.Length == 4)
        primerApellido = partes[2];
    else
        primerApellido = partes[1];

    string usuario = primerNombre.Substring(0, 1) + primerApellido + documento.Substring(documento.Length - 2);

    usuario = usuario.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u");

    return usuario;
}

static void AnalizarFrase(string frase)
{
    string[] palabras = frase.Trim().Split(' ');

    var sb = new StringBuilder();
    for (int i = palabras.Length - 1; i >= 0; i--)
    {
        sb.Append(palabras[i]);
        sb.Append(" ");
    }

    Console.WriteLine($"Cantidad de palabras: {palabras.Length}");
    Console.WriteLine($"Frase invertida: {sb.ToString().Trim()}");
}