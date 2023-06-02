using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SingleResponsabilityRefactory
{
    class CHacienda
    {
        public static double CalularImpuesto(CEmpleado objEmpleado)
        {
            return objEmpleado.Sueldo * 0.35;
        }

        public static void PagarImpuesto(CEmpleado objEmpleado)
        {
            double imp = CalularImpuesto(objEmpleado);
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", imp, objEmpleado.Nombre);
            Console.ReadLine();
        }
    }
}
