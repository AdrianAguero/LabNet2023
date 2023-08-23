using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExepciones.MisExepciones
{
    public class LogicExepcionPersonalizada: Exception
    {
        public LogicExepcionPersonalizada() : base("Mensaje personalizado de una exepcion!") { }
    }
}
