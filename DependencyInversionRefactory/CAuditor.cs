using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactory
{
    class CAuditor
    {
        private IAuditable miAlmacen;

        public CAuditor (IAuditable pAlmacen) 
        {
            miAlmacen = pAlmacen;
        }

        public double totalesAlimentos() 
        {
            double total = 0;

            IEnumerable<CProducto> listado = miAlmacen.ObtenProductos(0);

            foreach (CProducto p in listado) 
            {
                Console.WriteLine(p.ToString());
                total += p.Costo;
            }

            return total;
        }
    }
}
