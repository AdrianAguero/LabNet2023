using System;

namespace ManejoExepciones.MisExepciones
{
    public class LogicExepcionPersonalizada: Exception
    {
        public LogicExepcionPersonalizada() : base("Mensaje personalizado de una exepcion!") { }
    }
}
