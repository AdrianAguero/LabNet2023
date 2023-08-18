using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1.Modelo
{
    internal abstract class Transporte
    {
        public int pasajero { get; set; }

        public Transporte(int _pasajero)
        {
            this.pasajero = _pasajero;  
        }

        public abstract string Avanzar();

        public abstract string Detenerse();

    }
}
