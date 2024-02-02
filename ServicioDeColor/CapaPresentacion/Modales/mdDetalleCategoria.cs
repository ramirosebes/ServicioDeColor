using CapaControladora;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdDetalleCategoria : Form
    {
        private readonly string _tipoModal;
        private int _idCategoria;
        private Categoria _oCategoria;
        private CC_Categoria oCC_Categoria = new CC_Categoria();
        public int idCategoria { get; set; }

        public mdDetalleCategoria(string tipoModal, int idCategoria)
        {
            _idCategoria = idCategoria;
            _tipoModal = tipoModal;
            _oCategoria = oCC_Categoria.ListarCategorias().Where(c => c.IdCategoria == _idCategoria).FirstOrDefault();
            InitializeComponent();
        }

        private void mdDetalleCategoria_Load(object sender, EventArgs e)
        {
            ConfigurarModal();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposVacios(panelContenedor.Controls))
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (_tipoModal)
            {
                case "Agregar":
                    AgregarCategoria();
                    break;
                case "Editar":
                    EditarCategoria();
                    break;
            }
        }

        private void AgregarCategoria()
        {
            Categoria categoria = new Categoria()
            {
                Descripcion = textBoxDescripcion.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            };

            int idCategoriaRegistrado = oCC_Categoria.AgregarCategoria(categoria, out string mensaje);

            if (idCategoriaRegistrado != 0)
            {
                MessageBox.Show("Categoria agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                idCategoria = idCategoriaRegistrado;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarCategoria()
        {
            bool categoriaEditada = oCC_Categoria.EditarCategoria(new Categoria()
            {
                IdCategoria = _idCategoria,
                Descripcion = textBoxDescripcion.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            }, out string mensaje);

            if (categoriaEditada)
            {
                MessageBox.Show("Categoria editada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarModal()
        {
            comboBoxEstado.Items.Add(new OpcionCombo(1, "Activo"));
            comboBoxEstado.Items.Add(new OpcionCombo(0, "Inactivo"));
            comboBoxEstado.SelectedIndex = 0;
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";

            switch (_tipoModal)
            {
                case "VerDetalle":
                    ConfigurarVerDetalle();
                    break;
                case "Agregar":
                    ConfigurarAgregar();
                    break;
                case "Editar":
                    ConfigurarEditar();
                    break;
            }
        }

        private void ConfigurarVerDetalle()
        {
            this.Text = "Ver Detalle";
            textBoxDescripcion.Enabled = false;
            comboBoxEstado.Enabled = false;
            buttonConfirmar.Visible = false;

            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oCategoria.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }

            textBoxDescripcion.Text = _oCategoria.Descripcion.ToString();
        }

        private void ConfigurarAgregar()
        {
            this.Text = "Agregar categoria";
            labelSubTitulo.Text = "Agregar categoria";
            buttonConfirmar.Text = "Agregar";
        }

        private void ConfigurarEditar()
        {
            this.Text = "Editar categoria";
            labelSubTitulo.Text = "Editar categoria";
            buttonConfirmar.Text = "Editar";

            textBoxDescripcion.Text = _oCategoria.Descripcion.ToString();

            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oCategoria.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
