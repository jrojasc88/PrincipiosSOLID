using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class CAuditor
    {
        private CAlmacen miAlmacen;

        //Fuertemente acoplado, solamente puede trabajar con Almacen
        public CAuditor(CAlmacen pAlmacen)
        {
            miAlmacen = pAlmacen;
        }
        public double totalesAlimentos() 
        {
            double total = 0;

            foreach (CProducto p in miAlmacen.Inventario) 
            {
                if (p.Tipo == 0) 
                {
                    Console.WriteLine(p);
                    total += p.Costo;
                }
            }
            Console.ReadLine();
            return total;
        }
    }
}
