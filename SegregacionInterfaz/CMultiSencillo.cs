using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacionInterfaz
{
    class CMultiSencillo : IMultifuncional
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu reporte.");
            Console.ReadLine();
        }
        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando un documento.");
            Console.ReadLine();
        }

        //Estos métodos no se requieren

        public void Fax()
        {
            throw new NotImplementedException();
        }
        public void Telefono()
        {
            throw new NotImplementedException();
        }
    }
}
