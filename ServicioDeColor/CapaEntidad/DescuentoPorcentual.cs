using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DescuentoPorcentual : Descuento
    {
        private decimal _porcentaje;

        public DescuentoPorcentual(decimal porcentaje)
        {
            _porcentaje = porcentaje;
        }

        public decimal AplicarDescuento(decimal monto)
        {
            return monto * (1 - _porcentaje / 100);
        }
    }
}
