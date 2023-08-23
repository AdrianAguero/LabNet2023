using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExepciones
{
    internal static class ExtensionMethodsDivCero
    {   //Ejercicio 1:
        public static int DividirPorCero(this int value)
        {
            return value / 0;
        }
    }
}
