Console.WriteLine("=== VALIDADOR DE CONTRASEÑAS ===");
Console.WriteLine();
Console.Write("=== LOS REQUISITOS SON LOS SIGUIENTES ===");
Console.WriteLine();
Console.WriteLine();Console.WriteLine(" 1. Minimo 8 caracteres \n 2. Minimo una mayuscula \n 3. Minimo una minuscula \n 4. Minimo un numero \n 5. Minimo un caracter especial \n 6. No debe tener espacios");
Console.WriteLine();

Console.WriteLine("Digite una contraseña:");
Console.WriteLine();
string contraseña = Console.ReadLine();

bool cumpleCaracteres = contraseña.Length >= 8;
bool cumpleMayuscula = contraseña.Any(c => char.IsUpper(c));
bool cumpleMinuscula = contraseña.Any(c => char.IsLower(c));
bool cumpleNumero = contraseña.Any(c => char.IsDigit(c));
bool cumpleCaracterEs = contraseña.Any(c => char.IsPunctuation(c) || char.IsSymbol(c));
bool sinEspacios = !contraseña.Any(char.IsWhiteSpace);
int cantidad = 0;

Console.WriteLine();
Console.WriteLine("=== RESULTADO DE SU CONTRASEÑA ===");
Console.WriteLine();

if (cumpleCaracteres) cantidad++;
if (cumpleMayuscula) cantidad++;
if (cumpleMinuscula) cantidad++;
if (cumpleNumero) cantidad++;
if (cumpleCaracterEs) cantidad++;
if (sinEspacios) cantidad++;

Console.WriteLine($"El resultado de la contraseña {contraseña} fue el siguiente: ");
Console.WriteLine();

Console.WriteLine($"{(cumpleCaracteres ? "Bien:" : "Mal:")} Minimo 8 caracteres");
Console.WriteLine($"{(cumpleMayuscula ? "Bien:" : "Mal:")} Minimo una mayuscula");
Console.WriteLine($"{(cumpleMinuscula ? "Bien:" : "Mal:")} Minimo una minuscula");
Console.WriteLine($"{(cumpleNumero ? "Bien:" : "Mal:")} Minimo un numero");
Console.WriteLine($"{(cumpleCaracterEs ? "Bien:" : "Mal:")} Minimo un caracter especial");
Console.WriteLine($"{(sinEspacios ? "Bien:" : "Mal:")} No debe tener espacios");

Console.WriteLine();

if (cantidad == 6)
    Console.WriteLine("Nivel de contraseña = Muy fuerte (6/6)");
else if (cantidad == 5)
    Console.WriteLine("El nivel de la contraseña es Fuerte (5/6)");
else if (cantidad == 4)
    Console.WriteLine("El nivel de la contraseña es Medio (4/6)");
else if (cantidad == 3)
    Console.WriteLine("El nivel de la contraseña es Debil (3/6)");
else if (cantidad == 2)
    Console.WriteLine("El nivel de la contraseña es Muy Debil (2/6)");
else if (cantidad == 1)
    Console.WriteLine("El nivel de la contraseña es Demasiado Debil (1/6)");
else if (cantidad == 0)
    Console.WriteLine("El nivel de la contraseña es Nula (0/6)");