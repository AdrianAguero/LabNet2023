using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExepciones.MisExepciones
{
    internal class ExepcionDivCero
    {
        public static void DispararMiExcepcion()
        {
            throw new DivideByZeroException("Solo Chuck Norris divide por cero!");
        }
    }
}
