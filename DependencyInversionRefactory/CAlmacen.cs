using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactory
{
    class CAlmacen : IAuditable
    {
        private List<CProducto> inventario;

        public CAlmacen() 
        {
            inventario = new List<CProducto>();
        }

        public void AdicionaProducto(CProducto pProducto) 
        {
            inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}", pProducto.Nombre);
        }

        public IEnumerable<CProducto> ObtenProductos(int pTipo)
        {
            List<CProducto> encontrados = new List<CProducto>();

            foreach (CProducto producto in inventario) 
            {
                if (producto.Tipo == pTipo) 
                {
                    encontrados.Add(producto);
                }
            }
            return encontrados;
        }
    }
}
