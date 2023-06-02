using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitution
{
    class CRadio: CNoticiero
    {
        public CRadio(string pMensaje):base(pMensaje) 
        {
            
        }

        //public new void Muestra() 
        //{
        //    Console.WriteLine("Desde radio: {0}", mensaje);
        //    Console.ReadLine();
        //}

        public override void Muestra()
        {
            Console.WriteLine("Desde radio: {0}", mensaje);
            Console.ReadLine();
        }
    }
}
