namespace CapaPresentacion
{
    partial class frmAuditoriaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoriaVenta));
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdAuditoriaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuarioAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersonaUsuarioAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompletoUsuarioAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoUsuarioAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuarioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersonaUsuarioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompletoUsuarioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoUsuarioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersonaClienteVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompletoClienteVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoClienteVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.panelLista = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.menuVerDetalleAuditoriaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelLista.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(1369, 12);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroDocumento.TabIndex = 111;
            this.textBoxNumeroDocumento.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buttonSeleccionar,
            this.IdAuditoriaVenta,
            this.IdUsuarioAuditoria,
            this.IdPersonaUsuarioAuditoria,
            this.NombreCompletoUsuarioAuditoria,
            this.DocumentoUsuarioAuditoria,
            this.DescripcionAuditoria,
            this.FechaAuditoria,
            this.IdVenta,
            this.IdUsuarioVenta,
            this.IdPersonaUsuarioVenta,
            this.NombreCompletoUsuarioVenta,
            this.DocumentoUsuarioVenta,
            this.IdCliente,
            this.IdPersonaClienteVenta,
            this.NombreCompletoClienteVenta,
            this.DocumentoClienteVenta,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoPago,
            this.MontoCambio,
            this.SubTotal,
            this.MontoTotal,
            this.TipoDescuento,
            this.MontoDescuento,
            this.FechaRegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 123);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1460, 526);
            this.dataGridView.TabIndex = 109;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.HeaderText = "";
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.ReadOnly = true;
            this.buttonSeleccionar.Width = 30;
            // 
            // IdAuditoriaVenta
            // 
            this.IdAuditoriaVenta.HeaderText = "IdAuditoriaVenta";
            this.IdAuditoriaVenta.Name = "IdAuditoriaVenta";
            this.IdAuditoriaVenta.ReadOnly = true;
            this.IdAuditoriaVenta.Visible = false;
            // 
            // IdUsuarioAuditoria
            // 
            this.IdUsuarioAuditoria.HeaderText = "IdUsuarioAuditoria";
            this.IdUsuarioAuditoria.Name = "IdUsuarioAuditoria";
            this.IdUsuarioAuditoria.ReadOnly = true;
            this.IdUsuarioAuditoria.Visible = false;
            // 
            // IdPersonaUsuarioAuditoria
            // 
            this.IdPersonaUsuarioAuditoria.HeaderText = "IdPersonaUsuarioAuditoria";
            this.IdPersonaUsuarioAuditoria.Name = "IdPersonaUsuarioAuditoria";
            this.IdPersonaUsuarioAuditoria.ReadOnly = true;
            this.IdPersonaUsuarioAuditoria.Visible = false;
            // 
            // NombreCompletoUsuarioAuditoria
            // 
            this.NombreCompletoUsuarioAuditoria.HeaderText = "Ultimo usuario";
            this.NombreCompletoUsuarioAuditoria.Name = "NombreCompletoUsuarioAuditoria";
            this.NombreCompletoUsuarioAuditoria.ReadOnly = true;
            // 
            // DocumentoUsuarioAuditoria
            // 
            this.DocumentoUsuarioAuditoria.HeaderText = "DocumentoUsuarioAuditoria";
            this.DocumentoUsuarioAuditoria.Name = "DocumentoUsuarioAuditoria";
            this.DocumentoUsuarioAuditoria.ReadOnly = true;
            this.DocumentoUsuarioAuditoria.Visible = false;
            // 
            // DescripcionAuditoria
            // 
            this.DescripcionAuditoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescripcionAuditoria.HeaderText = "Descripcion";
            this.DescripcionAuditoria.Name = "DescripcionAuditoria";
            this.DescripcionAuditoria.ReadOnly = true;
            // 
            // FechaAuditoria
            // 
            this.FechaAuditoria.HeaderText = "Fecha de auditoria";
            this.FechaAuditoria.Name = "FechaAuditoria";
            this.FechaAuditoria.ReadOnly = true;
            this.FechaAuditoria.Width = 110;
            // 
            // IdVenta
            // 
            this.IdVenta.HeaderText = "IdVenta";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            this.IdVenta.Width = 60;
            // 
            // IdUsuarioVenta
            // 
            this.IdUsuarioVenta.HeaderText = "IdUsuarioVenta";
            this.IdUsuarioVenta.Name = "IdUsuarioVenta";
            this.IdUsuarioVenta.ReadOnly = true;
            this.IdUsuarioVenta.Visible = false;
            // 
            // IdPersonaUsuarioVenta
            // 
            this.IdPersonaUsuarioVenta.HeaderText = "IdPersonaUsuarioVenta";
            this.IdPersonaUsuarioVenta.Name = "IdPersonaUsuarioVenta";
            this.IdPersonaUsuarioVenta.ReadOnly = true;
            this.IdPersonaUsuarioVenta.Visible = false;
            // 
            // NombreCompletoUsuarioVenta
            // 
            this.NombreCompletoUsuarioVenta.HeaderText = "Usuario registro";
            this.NombreCompletoUsuarioVenta.Name = "NombreCompletoUsuarioVenta";
            this.NombreCompletoUsuarioVenta.ReadOnly = true;
            // 
            // DocumentoUsuarioVenta
            // 
            this.DocumentoUsuarioVenta.HeaderText = "DocumentoUsuarioVenta";
            this.DocumentoUsuarioVenta.Name = "DocumentoUsuarioVenta";
            this.DocumentoUsuarioVenta.ReadOnly = true;
            this.DocumentoUsuarioVenta.Visible = false;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // IdPersonaClienteVenta
            // 
            this.IdPersonaClienteVenta.HeaderText = "IdPersonaClienteVenta";
            this.IdPersonaClienteVenta.Name = "IdPersonaClienteVenta";
            this.IdPersonaClienteVenta.ReadOnly = true;
            this.IdPersonaClienteVenta.Visible = false;
            // 
            // NombreCompletoClienteVenta
            // 
            this.NombreCompletoClienteVenta.HeaderText = "Cliente";
            this.NombreCompletoClienteVenta.Name = "NombreCompletoClienteVenta";
            this.NombreCompletoClienteVenta.ReadOnly = true;
            // 
            // DocumentoClienteVenta
            // 
            this.DocumentoClienteVenta.HeaderText = "DocumentoClienteVenta";
            this.DocumentoClienteVenta.Name = "DocumentoClienteVenta";
            this.DocumentoClienteVenta.ReadOnly = true;
            this.DocumentoClienteVenta.Visible = false;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo de documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "NumeroDocumento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Visible = false;
            // 
            // MontoPago
            // 
            this.MontoPago.HeaderText = "Monto pago";
            this.MontoPago.Name = "MontoPago";
            this.MontoPago.ReadOnly = true;
            this.MontoPago.Width = 90;
            // 
            // MontoCambio
            // 
            this.MontoCambio.HeaderText = "Monto cambio";
            this.MontoCambio.Name = "MontoCambio";
            this.MontoCambio.ReadOnly = true;
            this.MontoCambio.Width = 90;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Subtotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 90;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Width = 90;
            // 
            // TipoDescuento
            // 
            this.TipoDescuento.HeaderText = "Tipo de descuento";
            this.TipoDescuento.Name = "TipoDescuento";
            this.TipoDescuento.ReadOnly = true;
            // 
            // MontoDescuento
            // 
            this.MontoDescuento.HeaderText = "Monto del descuento";
            this.MontoDescuento.Name = "MontoDescuento";
            this.MontoDescuento.ReadOnly = true;
            this.MontoDescuento.Width = 90;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 110;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonActualizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonActualizar.Image = global::CapaPresentacion.Properties.Resources.Actualizar2;
            this.buttonActualizar.Location = new System.Drawing.Point(1362, 30);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(95, 30);
            this.buttonActualizar.TabIndex = 5;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // labelSubTitulo
            // 
            this.labelSubTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSubTitulo.AutoSize = true;
            this.labelSubTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.labelSubTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitulo.Location = new System.Drawing.Point(10, 20);
            this.labelSubTitulo.Name = "labelSubTitulo";
            this.labelSubTitulo.Size = new System.Drawing.Size(221, 39);
            this.labelSubTitulo.TabIndex = 50;
            this.labelSubTitulo.Text = "Auditoria de ventas";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.ItemHeight = 19;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(839, 32);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(174, 27);
            this.comboBoxBusqueda.TabIndex = 1;
            this.comboBoxBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxBusqueda_SelectedIndexChanged);
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBuscarPor.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelBuscarPor.Location = new System.Drawing.Point(764, 36);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(69, 19);
            this.labelBuscarPor.TabIndex = 41;
            this.labelBuscarPor.Text = "Buscar por:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLimpiar.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiar.Location = new System.Drawing.Point(1281, 30);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxBusqueda.Location = new System.Drawing.Point(1019, 32);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(175, 27);
            this.textBoxBusqueda.TabIndex = 2;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            // 
            // panelLista
            // 
            this.panelLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelLista.Controls.Add(this.buttonActualizar);
            this.panelLista.Controls.Add(this.labelSubTitulo);
            this.panelLista.Controls.Add(this.comboBoxBusqueda);
            this.panelLista.Controls.Add(this.labelBuscarPor);
            this.panelLista.Controls.Add(this.buttonLimpiar);
            this.panelLista.Controls.Add(this.textBoxBusqueda);
            this.panelLista.Controls.Add(this.buttonBuscar);
            this.panelLista.Location = new System.Drawing.Point(12, 37);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(1460, 80);
            this.panelLista.TabIndex = 108;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscar.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscar.Location = new System.Drawing.Point(1200, 30);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // menuVerDetalleAuditoriaVenta
            // 
            this.menuVerDetalleAuditoriaVenta.AutoSize = false;
            this.menuVerDetalleAuditoriaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menuVerDetalleAuditoriaVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVerDetalleAuditoriaVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuVerDetalleAuditoriaVenta.Name = "menuVerDetalleAuditoriaVenta";
            this.menuVerDetalleAuditoriaVenta.Size = new System.Drawing.Size(88, 30);
            this.menuVerDetalleAuditoriaVenta.Text = "Ver detalle";
            this.menuVerDetalleAuditoriaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuVerDetalleAuditoriaVenta.Click += new System.EventHandler(this.menuVerDetalleAuditoriaVenta_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVerDetalleAuditoriaVenta});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1484, 34);
            this.menu.TabIndex = 107;
            this.menu.Text = "menuStrip1";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(1263, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 110;
            this.textBoxId.Visible = false;
            // 
            // frmAuditoriaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNumeroDocumento);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAuditoriaVenta";
            this.Text = "Auditoria venta";
            this.Load += new System.EventHandler(this.frmAuditoriaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label labelSubTitulo;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ToolStripMenuItem menuVerDetalleAuditoriaVenta;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridViewButtonColumn buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAuditoriaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuarioAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersonaUsuarioAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoUsuarioAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoUsuarioAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuarioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersonaUsuarioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoUsuarioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoUsuarioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersonaClienteVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoClienteVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoClienteVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}