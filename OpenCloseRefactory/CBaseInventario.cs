using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseRefactory
{
    abstract class CBaseInventario
    {
        protected CProducto producto;

        public CProducto Producto { get { return producto; } set { producto = value; } }

        public CBaseInventario(CProducto pPorducto) 
        {
            producto= pPorducto;
        }

        public override string ToString() 
        {
            return producto.ToString();
        }

        public abstract double CalcularProducto();
    }
}
