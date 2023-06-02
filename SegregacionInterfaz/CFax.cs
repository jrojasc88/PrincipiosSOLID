using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacionInterfaz
{
    class CFax : IMultifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("No tengo este servicio.");
            Console.ReadLine();
        }

        public void Fax()
        {
            Console.WriteLine("Envío un fax.");
            Console.ReadLine();
        }

        public void Imprimir()
        {
            Console.WriteLine("No tengo este servicio.");
            Console.ReadLine();
        }

        public void Telefono()
        {
            Console.WriteLine("No tengo este servicio.");
            Console.ReadLine();
        }
    }
}
