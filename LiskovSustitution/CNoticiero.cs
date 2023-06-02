using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitution
{
    class CNoticiero
    {
        protected string mensaje;

        public CNoticiero(string pMensaje) 
        {
            mensaje = pMensaje;
        }

        //public void Muestra() 
        //{
        //    Console.WriteLine("Desde el noticiero : {0}", mensaje);
        //    Console.ReadLine();
        //}

        public virtual void Muestra()
        {
            Console.WriteLine("Desde el noticiero : {0}", mensaje);
            Console.ReadLine();
        }
    }
}
