using CapaControladora;
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
    public partial class frmPermisoUsuario : Form
    {
        private CC_Usuario oCC_Usuario = new CC_Usuario();
        public frmPermisoUsuario()
        {
            InitializeComponent();
        }
    }
}
