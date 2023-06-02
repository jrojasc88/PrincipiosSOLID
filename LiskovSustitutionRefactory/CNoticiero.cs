using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitutionRefactory
{
    class CNoticiero: Principal
    {
        public CNoticiero(string pMensaje): base(pMensaje) 
        {
            
        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje);
            Console.ReadLine();
        }
    }
}
