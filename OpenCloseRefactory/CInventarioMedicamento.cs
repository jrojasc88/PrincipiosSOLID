using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseRefactory
{
    class CInventarioMedicamento : CBaseInventario
    {
        public CInventarioMedicamento(CProducto pProducto) : base(pProducto) 
        {
            
        }
        public override double CalcularProducto()
        {
            producto.Precio *= 0.8;
            return producto.Precio;
        }
    }
}
