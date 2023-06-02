using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitutionRefactory
{
    abstract class Principal
    {
        protected string mensaje;

        public Principal(string pmensaje)
        {
            mensaje = pmensaje;
        }

        public abstract void Muestra();
    }
}
