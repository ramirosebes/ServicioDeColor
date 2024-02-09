using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class SinDescuento : Descuento
    {
        public decimal AplicarDescuento(decimal monto)
        {
            return monto;
        }
    }
}
