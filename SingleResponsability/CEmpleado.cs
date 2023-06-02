using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    class CEmpleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public CEmpleado(string pNombre, string pPuesto, int pEdad, double pSueldo)
        {
            nombre = pNombre;
            puesto = pPuesto;
            edad = pEdad;
            sueldo = pSueldo;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", nombre, puesto, edad, sueldo);
        }

        public double CalularImpuesto()
        {
            return sueldo * 0.35;
        }

        public void PagarImpuesto() 
        {
            double imp = CalularImpuesto();
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", imp, nombre);
            Console.ReadLine();
        }
    }
}
