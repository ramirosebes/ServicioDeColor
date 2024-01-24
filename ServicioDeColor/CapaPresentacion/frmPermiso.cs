using CapaControladora;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPermiso : Form
    {
        private CC_Permiso oCCPermiso = new CC_Permiso();
        private Usuario _usuarioActual;

        public frmPermiso(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }
    }
}
