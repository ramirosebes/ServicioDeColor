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
    public partial class mdDetalleGrupoPermiso : Form
    {
        private readonly string _tipoModal;
        private int _idGrupoPermiso;
        private GrupoPermiso _oGrupoPermiso;
        private CC_GrupoPermiso oCC_GrupoPermiso = new CC_GrupoPermiso();

        public mdDetalleGrupoPermiso(string tipoModal, int idGrupoPermiso)
        {
            _tipoModal = tipoModal;
            _idGrupoPermiso = idGrupoPermiso;
            _oGrupoPermiso = oCC_GrupoPermiso.ListarGrupoPermisos().Where(c => c.IdGrupoPermiso == _idGrupoPermiso).FirstOrDefault();
            InitializeComponent();
        }

        private void mdDetalleGrupoPermiso_Load(object sender, EventArgs e)
        {
            ConfigurarModal();
        }

        private void ConfigurarModal()
        {
            comboBoxEstado.Items.Add(new OpcionCombo(1, "Activo"));
            comboBoxEstado.Items.Add(new OpcionCombo(0, "Inactivo"));
            comboBoxEstado.SelectedIndex = 0;
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";

            dataGridView.Rows.Clear();

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
            };
        }

        private void ConfigurarVerDetalle()
        {
            this.Text = "Ver Detalle";
            textBoxNombreGrupo.Text = _oGrupoPermiso.Nombre.ToString();
            textBoxNombreGrupo.Enabled = false;
            comboBoxEstado.Enabled = false;
            buttonAgregar.Visible = false;
            buttonEliminar.Visible = false;
            buttonConfirmar.Visible = false;

            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oGrupoPermiso.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }

            MostrarPermisos();
        }

        private void ConfigurarAgregar()
        {
            this.Text = "Agregar Grupo";
            labelSubTitulo.Text = "Agregar Grupo";
            buttonConfirmar.Text = "Guardar";
        }

        private void ConfigurarEditar()
        {
            this.Text = "Editar Grupo";
            labelSubTitulo.Text = "Editar Grupo";
            buttonConfirmar.Text = "Editar";

            textBoxNombreGrupo.Text = _oGrupoPermiso.Nombre.ToString();

            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oGrupoPermiso.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }

            MostrarPermisos();
        }

        private void MostrarPermisos()
        {
            //MOSTRAR LOS PERMISOS
            List<Componente> listaComponentes = oCC_GrupoPermiso.ListarComponentes(_idGrupoPermiso);

            foreach (Componente oComponente in listaComponentes)
            {
                dataGridView.Rows.Add(
                    "",
                    oComponente.IdComponente,
                    oComponente.Nombre,
                    oComponente.TipoComponente,
                    oComponente.Estado == true ? 1 : 0,
                    oComponente.Estado == true ? "Activo" : "Inactivo"
                    );
            }

            //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
            dataGridView.ClearSelection();
        }

        private void AgregarGrupo()
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable listaComponentes = new DataTable();

            listaComponentes.Columns.Add("IdComponente", typeof(int));

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                listaComponentes.Rows.Add(Convert.ToInt32(row.Cells["IdComponente"].Value));
            }

            GrupoPermiso oGrupoPermiso = new GrupoPermiso()
            {
                NombreGrupo = textBoxNombreGrupo.Text,
                Estado = Convert.ToBoolean(((OpcionCombo)comboBoxEstado.SelectedItem).Valor)
            };

            bool resultado = oCC_GrupoPermiso.AgregarGrupoPermiso(oGrupoPermiso, listaComponentes, out string mensaje);

            if (resultado)
            {
                MessageBox.Show("Grupo registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarGrupo()
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable listaComponentes = new DataTable();

            listaComponentes.Columns.Add("IdComponente", typeof(int));

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                listaComponentes.Rows.Add(Convert.ToInt32(row.Cells["IdComponente"].Value));
            }

            GrupoPermiso oGrupoPermiso = new GrupoPermiso()
            {
                IdGrupoPermiso = _idGrupoPermiso,
                IdComponente = _oGrupoPermiso.IdComponente,
                NombreGrupo = textBoxNombreGrupo.Text.Trim(),
                Estado = Convert.ToBoolean(((OpcionCombo)comboBoxEstado.SelectedItem).Valor)
            };

            bool resultado = oCC_GrupoPermiso.EditarGrupoPermiso(oGrupoPermiso, listaComponentes, out string mensaje);

            if (resultado)
            {
                MessageBox.Show("Grupo editado correctamente.\nSe recomienda reiniciar el sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdAgregarComponenteAGrupo())
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    textBoxId.Text = modal.oComponente.IdComponente.ToString();

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells["IdComponente"].Value.ToString() == textBoxId.Text)
                        {
                            MessageBox.Show("El componente ya se encuentra en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    dataGridView.Rows.Add(
                        "",
                        modal.oComponente.IdComponente,
                        modal.oComponente.Nombre,
                        modal.oComponente.TipoComponente,
                        modal.oComponente.Estado == true ? 1 : 0,
                        modal.oComponente.Estado == true ? "Activo" : "Inactivo"
                        );
                }
                dataGridView.ClearSelection();
                textBoxId.Text = "";
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int indice = dataGridView.CurrentRow.Index;

            if (indice >= 0)
            {
                dataGridView.Rows.RemoveAt(indice);
            }

            dataGridView.ClearSelection();
            textBoxId.Text = "";
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposVacios(Controls))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (_tipoModal)
            {
                case "Agregar":
                    AgregarGrupo();
                    break;
                case "Editar":
                    EditarGrupo();
                    break;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                textBoxId.Text = dataGridView.Rows[indice].Cells["IdComponente"].Value.ToString();
            }
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                e.PaintBackground(e.ClipBounds, true);

                var w = Properties.Resources.Seleccion.Width;
                var h = Properties.Resources.Seleccion.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Seleccion, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
