namespace Tarea
{
    public class ConversorTemperatura
    {
        public decimal Convertir(decimal valor, string origen, string destino)
        {
            decimal celsius = 0;

            // Convertir el valor de origen a Celsius
            if (origen == "Celsius")
            {
                celsius = valor;
            }
            else if (origen == "Fahrenheit")
            {
                celsius = (valor - 32) * 5 / 9;
            }
            else if (origen == "Kelvin")
            {
                celsius = valor - 273.15m;
            }

            // Convertir Celsius a la unidad de destino
            if (destino == "Celsius")
            {
                return celsius;
            }
            else if (destino == "Fahrenheit")
            {
                return (celsius * 9 / 5) + 32;
            }
            else if (destino == "Kelvin")
            {
                return celsius + 273.15m;
            }

            return 0;
        }
    }
}