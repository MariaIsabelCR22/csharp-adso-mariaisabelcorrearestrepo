namespace Reto;

public class EmpleadoPorHoras : Empleado
{
    public int Horas { get; private set; }
    public decimal ValorHora { get; private set; }

    public override string Tipo => "Por horas";

    public EmpleadoPorHoras(string nombre, string documento, int horas, decimal valorHora)
        : base(nombre, documento)
    {
        Horas = horas;
        ValorHora = valorHora;
    }

    public override decimal CalcularSalario()
    {
        if (Horas > 160)
        {
            return (160 * ValorHora) + ((Horas - 160) * ValorHora * 1.5m);
        }

        return Horas * ValorHora;
    }
}