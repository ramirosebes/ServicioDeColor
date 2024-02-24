namespace CapaPresentacion.Modales
{
    partial class mdDetalleCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdDetalleCompra));
            this.panelDetalleCompra = new System.Windows.Forms.Panel();
            this.buttonDescargarPDF = new System.Windows.Forms.Button();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMontoTotal = new System.Windows.Forms.Label();
            this.groupBoxInformacionProveedor = new System.Windows.Forms.GroupBox();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.textBoxCUIT = new System.Windows.Forms.TextBox();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.groupBoxInformacionCompra = new System.Windows.Forms.GroupBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxTipoDocumento = new System.Windows.Forms.TextBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelFehca = new System.Windows.Forms.Label();
            this.buttonLimpiarBuscardor = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.labelDetalleCompra = new System.Windows.Forms.Label();
            this.panelDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.groupBoxInformacionProveedor.SuspendLayout();
            this.groupBoxInformacionCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalleCompra
            // 
            this.panelDetalleCompra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDetalleCompra.Controls.Add(this.buttonDescargarPDF);
            this.panelDetalleCompra.Controls.Add(this.textBoxMontoTotal);
            this.panelDetalleCompra.Controls.Add(this.dataGridViewData);
            this.panelDetalleCompra.Controls.Add(this.labelMontoTotal);
            this.panelDetalleCompra.Controls.Add(this.groupBoxInformacionProveedor);
            this.panelDetalleCompra.Controls.Add(this.groupBoxInformacionCompra);
            this.panelDetalleCompra.Controls.Add(this.buttonLimpiarBuscardor);
            this.panelDetalleCompra.Controls.Add(this.textBoxBusqueda);
            this.panelDetalleCompra.Controls.Add(this.buttonBuscar);
            this.panelDetalleCompra.Controls.Add(this.labelNumeroDocumento);
            this.panelDetalleCompra.Controls.Add(this.labelDetalleCompra);
            this.panelDetalleCompra.Location = new System.Drawing.Point(12, 12);
            this.panelDetalleCompra.Name = "panelDetalleCompra";
            this.panelDetalleCompra.Size = new System.Drawing.Size(835, 578);
            this.panelDetalleCompra.TabIndex = 1;
            // 
            // buttonDescargarPDF
            // 
            this.buttonDescargarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(12)))), ((int)(((byte)(0)))));
            this.buttonDescargarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDescargarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDescargarPDF.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDescargarPDF.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDescargarPDF.Location = new System.Drawing.Point(668, 533);
            this.buttonDescargarPDF.Name = "buttonDescargarPDF";
            this.buttonDescargarPDF.Size = new System.Drawing.Size(150, 30);
            this.buttonDescargarPDF.TabIndex = 7;
            this.buttonDescargarPDF.Text = "Descargar PDF";
            this.buttonDescargarPDF.UseVisualStyleBackColor = false;
            this.buttonDescargarPDF.Click += new System.EventHandler(this.buttonDescargarPDF_Click);
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMontoTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoTotal.Location = new System.Drawing.Point(106, 536);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.ReadOnly = true;
            this.textBoxMontoTotal.Size = new System.Drawing.Size(150, 27);
            this.textBoxMontoTotal.TabIndex = 6;
            this.textBoxMontoTotal.Text = "0.00";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.Location = new System.Drawing.Point(20, 234);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewData.Size = new System.Drawing.Size(798, 293);
            this.dataGridViewData.TabIndex = 60;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 305;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 150;
            // 
            // labelMontoTotal
            // 
            this.labelMontoTotal.AutoSize = true;
            this.labelMontoTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoTotal.Location = new System.Drawing.Point(16, 536);
            this.labelMontoTotal.Name = "labelMontoTotal";
            this.labelMontoTotal.Size = new System.Drawing.Size(84, 23);
            this.labelMontoTotal.TabIndex = 8;
            this.labelMontoTotal.Text = "Monto total:";
            // 
            // groupBoxInformacionProveedor
            // 
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxNumeroDocumento);
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxRazonSocial);
            this.groupBoxInformacionProveedor.Controls.Add(this.labelRazonSocial);
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxCUIT);
            this.groupBoxInformacionProveedor.Controls.Add(this.labelCUIT);
            this.groupBoxInformacionProveedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionProveedor.Location = new System.Drawing.Point(20, 144);
            this.groupBoxInformacionProveedor.Name = "groupBoxInformacionProveedor";
            this.groupBoxInformacionProveedor.Size = new System.Drawing.Size(798, 84);
            this.groupBoxInformacionProveedor.TabIndex = 59;
            this.groupBoxInformacionProveedor.TabStop = false;
            this.groupBoxInformacionProveedor.Text = "Informacion del proveedor";
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(742, 45);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(50, 27);
            this.textBoxNumeroDocumento.TabIndex = 7;
            this.textBoxNumeroDocumento.Visible = false;
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(216, 45);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.ReadOnly = true;
            this.textBoxRazonSocial.Size = new System.Drawing.Size(200, 27);
            this.textBoxRazonSocial.TabIndex = 5;
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(212, 23);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(80, 19);
            this.labelRazonSocial.TabIndex = 4;
            this.labelRazonSocial.Text = "Razon social:";
            // 
            // textBoxCUIT
            // 
            this.textBoxCUIT.Location = new System.Drawing.Point(10, 45);
            this.textBoxCUIT.Name = "textBoxCUIT";
            this.textBoxCUIT.ReadOnly = true;
            this.textBoxCUIT.Size = new System.Drawing.Size(200, 27);
            this.textBoxCUIT.TabIndex = 4;
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.Location = new System.Drawing.Point(6, 23);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(35, 19);
            this.labelCUIT.TabIndex = 2;
            this.labelCUIT.Text = "CUIT:";
            // 
            // groupBoxInformacionCompra
            // 
            this.groupBoxInformacionCompra.Controls.Add(this.textBoxUsuario);
            this.groupBoxInformacionCompra.Controls.Add(this.labelUsuario);
            this.groupBoxInformacionCompra.Controls.Add(this.textBoxTipoDocumento);
            this.groupBoxInformacionCompra.Controls.Add(this.labelTipoDocumento);
            this.groupBoxInformacionCompra.Controls.Add(this.textBoxFecha);
            this.groupBoxInformacionCompra.Controls.Add(this.labelFehca);
            this.groupBoxInformacionCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionCompra.Location = new System.Drawing.Point(20, 54);
            this.groupBoxInformacionCompra.Name = "groupBoxInformacionCompra";
            this.groupBoxInformacionCompra.Size = new System.Drawing.Size(798, 84);
            this.groupBoxInformacionCompra.TabIndex = 58;
            this.groupBoxInformacionCompra.TabStop = false;
            this.groupBoxInformacionCompra.Text = "Informacion de la compra";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(372, 45);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(200, 27);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(368, 23);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(53, 19);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuario:";
            // 
            // textBoxTipoDocumento
            // 
            this.textBoxTipoDocumento.Location = new System.Drawing.Point(166, 45);
            this.textBoxTipoDocumento.Name = "textBoxTipoDocumento";
            this.textBoxTipoDocumento.ReadOnly = true;
            this.textBoxTipoDocumento.Size = new System.Drawing.Size(200, 27);
            this.textBoxTipoDocumento.TabIndex = 2;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(162, 23);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(109, 19);
            this.labelTipoDocumento.TabIndex = 4;
            this.labelTipoDocumento.Text = "Tipo de documento:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(10, 45);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(150, 27);
            this.textBoxFecha.TabIndex = 1;
            // 
            // labelFehca
            // 
            this.labelFehca.AutoSize = true;
            this.labelFehca.Location = new System.Drawing.Point(6, 23);
            this.labelFehca.Name = "labelFehca";
            this.labelFehca.Size = new System.Drawing.Size(44, 19);
            this.labelFehca.TabIndex = 2;
            this.labelFehca.Text = "Fecha:";
            // 
            // buttonLimpiarBuscardor
            // 
            this.buttonLimpiarBuscardor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiarBuscardor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiarBuscardor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiarBuscardor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarBuscardor.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLimpiarBuscardor.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiarBuscardor.Location = new System.Drawing.Point(743, 18);
            this.buttonLimpiarBuscardor.Name = "buttonLimpiarBuscardor";
            this.buttonLimpiarBuscardor.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiarBuscardor.TabIndex = 55;
            this.buttonLimpiarBuscardor.Text = "Limpiar";
            this.buttonLimpiarBuscardor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiarBuscardor.UseVisualStyleBackColor = false;
            this.buttonLimpiarBuscardor.Visible = false;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxBusqueda.Location = new System.Drawing.Point(456, 18);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(200, 30);
            this.textBoxBusqueda.TabIndex = 53;
            this.textBoxBusqueda.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscar.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscar.Location = new System.Drawing.Point(662, 18);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscar.TabIndex = 54;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Visible = false;
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNumeroDocumento.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelNumeroDocumento.Location = new System.Drawing.Point(321, 23);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(129, 19);
            this.labelNumeroDocumento.TabIndex = 56;
            this.labelNumeroDocumento.Text = "Numero de documento:";
            this.labelNumeroDocumento.Visible = false;
            // 
            // labelDetalleCompra
            // 
            this.labelDetalleCompra.AutoSize = true;
            this.labelDetalleCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleCompra.Location = new System.Drawing.Point(13, 12);
            this.labelDetalleCompra.Name = "labelDetalleCompra";
            this.labelDetalleCompra.Size = new System.Drawing.Size(178, 33);
            this.labelDetalleCompra.TabIndex = 1;
            this.labelDetalleCompra.Text = "Detalle de compra";
            // 
            // mdDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(859, 603);
            this.Controls.Add(this.panelDetalleCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(875, 642);
            this.MinimumSize = new System.Drawing.Size(875, 642);
            this.Name = "mdDetalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle compra";
            this.Load += new System.EventHandler(this.mdDetalleCompra_Load);
            this.panelDetalleCompra.ResumeLayout(false);
            this.panelDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.groupBoxInformacionProveedor.ResumeLayout(false);
            this.groupBoxInformacionProveedor.PerformLayout();
            this.groupBoxInformacionCompra.ResumeLayout(false);
            this.groupBoxInformacionCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetalleCompra;
        private System.Windows.Forms.Button buttonDescargarPDF;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label labelMontoTotal;
        private System.Windows.Forms.GroupBox groupBoxInformacionProveedor;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.TextBox textBoxCUIT;
        private System.Windows.Forms.Label labelCUIT;
        private System.Windows.Forms.GroupBox groupBoxInformacionCompra;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxTipoDocumento;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelFehca;
        private System.Windows.Forms.Button buttonLimpiarBuscardor;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.Label labelDetalleCompra;
    }
}