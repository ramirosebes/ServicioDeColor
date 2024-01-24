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
    public partial class frmGrupo : Form
    {
        CC_GrupoPermiso oCC_GrupoPermiso = new CC_GrupoPermiso();
        private Usuario _usuarioActual;
        public frmGrupo(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }
    }
}
