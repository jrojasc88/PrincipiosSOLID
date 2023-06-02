using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseRefactory
{
    class CProducto
    {
        private string nombre;
        private int categoria;
        private double precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public double Precio { get => precio; set => precio = value; }

        public CProducto(string _nombre, int _categoria, double _precio)
        {
            nombre = _nombre;
            categoria = _categoria;
            precio = _precio;
        }

        public override string ToString()
        {
            return string.Format("El producto {0} cuesta {1}", nombre, precio);
        }
    }
}
