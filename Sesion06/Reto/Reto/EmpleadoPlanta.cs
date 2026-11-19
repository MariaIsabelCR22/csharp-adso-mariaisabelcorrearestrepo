namespace Reto;

public class EmpleadoPlanta : Empleado
{
    public decimal SalarioMensual { get; private set; }
    public int AniosAntiguedad { get; private set; }

    public override string Tipo => "Planta";

    public EmpleadoPlanta(string nombre, string documento, decimal salarioMensual, int aniosAntiguedad)
        : base(nombre, documento)
    {
        SalarioMensual = salarioMensual;
        AniosAntiguedad = aniosAntiguedad;
    }

    public override decimal CalcularSalario()
    {
        if (AniosAntiguedad >= 5)
        {
            return SalarioMensual * 1.05m;
        }

        return SalarioMensual;
    }
}