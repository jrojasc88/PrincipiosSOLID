using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseRefactory
{
    class CTienda
    {
        private List<CBaseInventario> productos;

        public CTienda(List<CBaseInventario> pPorductos) 
        {
            productos = pPorductos;
        }

        public void CalcularInventario() 
        {
            double total = 0;

            foreach ( var producto in productos) 
            {
                producto.CalcularProducto();
                Console.WriteLine(producto);
                total += producto.Producto.Precio;
            }

            Console.WriteLine("El total del inventario es {0}", total);
            Console.ReadLine();
        }
    }
}
