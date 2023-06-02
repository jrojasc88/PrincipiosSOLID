using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacionInterfazRefactory
{
    class CMultiAvanzada : IMulticompleto
    {
        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando un documento.");
        }

        public void fax()
        {
            Console.WriteLine("Te envío un fax.");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu documento.");
        }

        public void telefono()
        {
            Console.WriteLine("Te marco a un teléfono.");
        }
    }
}
