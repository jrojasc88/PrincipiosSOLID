using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacionInterfazRefactory
{
    class CMultiSencillo : IMultiBasico
    {
        public void Escanear()
        {
            Console.WriteLine("Escaneo una fotografía.");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu documento.");
        }
    }
}
