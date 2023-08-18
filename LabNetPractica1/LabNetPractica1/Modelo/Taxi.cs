using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1.Modelo
{
    internal class Taxi : Transporte
    {
        public Taxi(int _pasajero) : base(_pasajero)
        {
        }

        public override void Acelerar()
        {
            if (velocidad < 50) 
                velocidad += 10;         }

        public override void Frenar()
        {
            if (velocidad > 0)
                velocidad -= 3;
        }
    }
}
