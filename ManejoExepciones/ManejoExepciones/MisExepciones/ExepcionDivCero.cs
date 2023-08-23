using System;

namespace ManejoExepciones.MisExepciones
{
    public class ExepcionDivCero
    {
        public static void DispararMiExcepcion()
        {
            throw new DivideByZeroException("Solo Chuck Norris divide por cero!");
        }
    }
}
