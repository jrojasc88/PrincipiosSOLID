using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactory
{
    interface IAuditable
    {
        IEnumerable<CProducto> ObtenProductos(int pTipo);
    }
}
