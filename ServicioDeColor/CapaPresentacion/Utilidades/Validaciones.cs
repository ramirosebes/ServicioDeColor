using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Utilidades
{
    public static class Validaciones
    {
        public static bool ValidarCamposVacios(Control.ControlCollection controls)
        {
            var textBoxes = controls.OfType<TextBox>().Where(c => c.Visible).OrderBy(c => c.TabIndex);

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Trim() == string.Empty)
                {
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarClaves(string clave1, string clave2)
        {
            if (clave1 != clave2)
            {
                MessageBox.Show("Las claves no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
