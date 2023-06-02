using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacionInterfaz
{
    class CMultiAvanzado : IMultifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando un documento.");
            Console.ReadLine();
        }

        public void Fax()
        {
            Console.WriteLine("Envío un fax.");
            Console.ReadLine();
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu reporte.");
            Console.ReadLine();
        }

        public void Telefono()
        {
            Console.WriteLine("Te marco al teléfono.");
            Console.ReadLine();
        }
    }
}
