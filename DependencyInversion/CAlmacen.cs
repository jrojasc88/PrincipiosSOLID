using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class CAlmacen
    {
        private List<CProducto> inventario;

        public List<CProducto> Inventario { get => inventario; set => inventario = value; }

        public CAlmacen() 
        {
            inventario = new List<CProducto>();
        }

        public void AdicionarProducto(CProducto pProducto) 
        {
            inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}", pProducto.Nombre);
        }
    }
}
