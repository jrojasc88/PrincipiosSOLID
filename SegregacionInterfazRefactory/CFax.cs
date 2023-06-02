using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacionInterfazRefactory
{
    class CFax : IFax
    {
        public void fax()
        {
            Console.WriteLine("Te marco a un teléfono.");
        }

        public void telefono()
        {
            Console.WriteLine("Envío un fax.");
        }
    }
}
