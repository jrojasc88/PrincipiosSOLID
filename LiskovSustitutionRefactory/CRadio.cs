using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitutionRefactory
{
    class CRadio: Principal
    {
        public CRadio(string pMensaje) :base(pMensaje) 
        {
            
        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el radio: {0}", mensaje);
            Console.ReadLine();
        }
    }
}
