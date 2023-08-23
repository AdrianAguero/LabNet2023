using ManejoExepciones.MisExepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExepciones
{
    public class Logic
    {
        //Ejercicio 2:
        public static decimal Dividir(decimal dividendo, decimal divisor)
        {
            decimal resultado = dividendo / divisor;
            return resultado;
        }
        //Ejercicio 3:
        public void ExepcionPunto3()
        {
            throw new NotImplementedException();
        }
        //Ejercicio 4:
        public string ExepcionPersonalizadaPunto4()
        {
            throw new LogicExepcionPersonalizada();
        }
    }
}
