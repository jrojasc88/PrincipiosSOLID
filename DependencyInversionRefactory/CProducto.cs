using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactory
{
    class CProducto
    {
        private string nombre;
        private int tipo; //0 alimento, 1 medicicna, 2 ropa
        private double costo;

        public string Nombre { get { return nombre; } set => nombre = value; }
        public int Tipo { get { return tipo; } set => tipo = value; }
        public double Costo { get { return costo; } set => costo = value; }

        public CProducto(string pNombre, int pTipo, double pPrecio)
        {
            nombre = pNombre;
            tipo = pTipo;
            costo = pPrecio;
        }

        public override string ToString()
        {
            string strTipo = string.Empty;

            if (tipo == 0)
            {
                strTipo = "Alimento";
            }
            if (tipo == 1)
            {
                strTipo = "Medicina";
            }
            if (tipo == 2)
            {
                strTipo = "Ropa";
            }

            return string.Format("{0}, tipo {1}, costo $ {2}", nombre, strTipo, costo);
        }
    }
}
