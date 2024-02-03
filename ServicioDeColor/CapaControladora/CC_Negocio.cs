using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladora
{
    public class CC_Negocio
    {
        private CD_Negocio oCD_Negocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return oCD_Negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del negocio\n";
            }

            if (obj.CUIT == "")
            {
                Mensaje += "Es necesario el numero de CUIT negocio\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la direccion del negocio\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return oCD_Negocio.GuardarDatos(obj, out Mensaje);
            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return oCD_Negocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return oCD_Negocio.ActualizarLogo(imagen, out mensaje);
        }
    }
}
