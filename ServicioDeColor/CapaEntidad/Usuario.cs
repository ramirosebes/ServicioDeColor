using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario : Persona
    {
        #region Variables Privadas
        private int idUsuario;
        private string clave;
        private bool estado;
        private List<Permiso> permisos;
        #endregion

        #region Propiedades
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public void SetClave(string clave)
        {
            this.clave = clave;
        }
        public bool Estado { get { return estado; } set { estado = value; } }
        public void SetPermisos(List<Permiso> permisos)
        {
            this.permisos = permisos;
        }
        public List<Permiso> GetPermisos()
        {
            return this.permisos;
        }
        #endregion

        #region Metodos
        public static string GenerarClaveHash(string clave)
        {
            //GENERAR UN SALTO UNICO PARA LA CLAVE
            string salto = GenerarSaltoAleatorio();

            //SUMA LA CLAVE CON EL SALTO Y GENERA UN HASH
            string claveSalto = clave + salto;

            //GENERAR UN HASH CON EL ALGORITMO SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - DEVUELVE ARRAY DE BYTES  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(claveSalto));

                // CONVIERTE ARRAY DE BITES A STRING
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    //X2 ES PARA QUE EL HASH SE DEVUELVA EN HEXADECIMAL
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString() + "|" + salto;
            }
        }

        public bool VerificarClave(string claveIngresada)
        {
            //SEPARA EL HASH DEL SALTO
            string claveHash = this.clave;
            string[] claveHashSplit = claveHash.Split('|');
            string claveHashSinSalto = string.Empty;
            string salto = string.Empty;

            if (claveHashSplit.Length == 2)
            {
                claveHashSinSalto = claveHashSplit[0];
                salto = claveHashSplit[1];
            }

            if (claveHashSplit.Length != 2)
            {
                return false;
            }

            //GENERA UN HASH CON LA CLAVE Y EL SALTO
            string claveSalto = claveIngresada + salto;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - DEVUELVE ARRAY DE BYTES  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(claveSalto));

                // CONVIERTE ARRAY DE BITES A STRING
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    //X2 ES PARA QUE EL HASH SE DEVUELVA EN HEXADECIMAL
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString() == claveHashSinSalto;
            }
        }

        //ANTIGUO METODO PARA GENERAR UN SALTO ALEATORIO
        //private static string GenerarSaltoAleatorio()
        //{
        //    string salto = string.Empty;
        //    //RANDOM GENERA NUMEROS ALEATORIOS
        //    Random r = new Random();
        //    //GENERA ALEATORIAMENTE ENTRE 10 Y 19 CARACTERES
        //    int longitud = r.Next(10, 20);
        //    //GENERA ALEATORIAMENTE ENTRE 33 Y 126 CARACTERES CARACTERES IMPRIMIBLES ASCII
        //    for (int i = 0; i < longitud; i++)
        //    {
        //        salto += (char)r.Next(33, 126);
        //    }
        //    return salto;
        //}

        private static string GenerarSaltoAleatorio()
        {
            string salto = string.Empty;
            Random r = new Random();
            int longitud = r.Next(10, 20);
            char caracterAleatorio;

            for (int i = 0; i < longitud; i++)
            {
                do
                {
                    caracterAleatorio = (char)r.Next(33, 126);
                } while (caracterAleatorio == '|'); // Verifica si el caracter generado es '|'

                salto += caracterAleatorio;
            }
            return salto;
        }
        #endregion
    }
}
