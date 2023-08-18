using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1.Modelo
{
    internal abstract class Transporte
    {
        public int Pasajero { get; set; }
        public int velocidad;

        public Transporte(int _pasajero)
        {
            this.Pasajero = _pasajero;
            velocidad = 0;
        }

        public abstract void Acelerar();

        public abstract void Frenar();

    }
}
