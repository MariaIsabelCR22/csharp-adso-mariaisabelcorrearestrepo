5cusing System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace prueba1
{
    internal class Vehiculo
    {
        public string Placa { get; }
        public string Ruedas { get; }

        public Vehiculo(string Placa, string Ruedas)
        {
            Placa = Placa.ToUpper();
            Ruedas = Ruedas;
        }

        public class Carro : Vehiculo
        {
            public int Puestos { get; }

            public Carro(string Placa, int Puestos) : base(Placa, 4)
            {
                Puestos = Puestos;
            }
        }

    }
}
