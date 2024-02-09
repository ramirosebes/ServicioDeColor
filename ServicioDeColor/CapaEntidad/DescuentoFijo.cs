using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DescuentoFijo : Descuento
    {
        private decimal _montoDescuento;

        public DescuentoFijo(decimal montoDescuento)
        {
            _montoDescuento = montoDescuento;
        }

        public decimal AplicarDescuento(decimal monto)
        {
            return (monto - _montoDescuento);
        }
    }
}
