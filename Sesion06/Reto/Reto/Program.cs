namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> nomina =
            [
                new EmpleadoPlanta("Ana Gómez", "1001", 3_200_000m, 6),
                new EmpleadoPlanta("Luis Pérez", "1002", 2_800_000m, 2),
                new EmpleadoPorHoras("Marta Ruiz", "1003", 170, 18_000m),
                new EmpleadoPorHoras("Jorge Díaz", "1004", 120, 18_000m),
                new Contratista("Sofía León", "1005", 4_000_000m)
            ];

            Console.WriteLine("===== NOMINA DE EMPLEADOS =====");

            foreach (Empleado empleado in nomina)
            {
                Console.WriteLine(empleado);
            }

            decimal totalNomina = nomina.Sum(e => e.CalcularSalario());

            Console.WriteLine("\n===== TOTAL DE NOMINA =====");
            Console.WriteLine($"Total a pagar: ${totalNomina:N0}");

            Empleado mayorPago = nomina.OrderByDescending(e => e.CalcularSalario()).First();

            Console.WriteLine("\n===== MAYOR PAGO =====");
            Console.WriteLine($"{mayorPago.Nombre}: ${mayorPago.CalcularSalario():N0}");

            Console.WriteLine("\n===== TOTAL POR TIPO =====");

            var totalesPorTipo = nomina.GroupBy(e => e.Tipo);

            foreach (var grupo in totalesPorTipo)
            {
                decimal total = grupo.Sum(e => e.CalcularSalario());

                Console.WriteLine($"{grupo.Key}: ${total:N0}");
            }
        }
    }
}