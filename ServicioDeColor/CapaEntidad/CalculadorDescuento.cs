using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CalculadorDescuento : Descuento
    {
        private Descuento _descuento;

        public void SetDescuento(Descuento descuento)
        {
            _descuento = descuento;
        }

        public decimal AplicarDescuento(decimal monto)
        {
            if (_descuento == null)
            {
                throw new Exception("No se ha establecido un descuento");
            }

            return _descuento.AplicarDescuento(monto);
        }
    }
}
