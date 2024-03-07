namespace CapaPresentacion
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panelLista = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuEliminarPedidoVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarPedidoVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerDetallePedidoVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.buttonSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(1372, 12);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroDocumento.TabIndex = 106;
            this.textBoxNumeroDocumento.Visible = false;
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
            this.labelSubTitulo.Size = new System.Drawing.Size(177, 39);
            this.labelSubTitulo.TabIndex = 50;
            this.labelSubTitulo.Text = "Lista de ventas";
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
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(1266, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 105;
            this.textBoxId.Visible = false;
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
            this.panelLista.TabIndex = 103;
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
            this.idVenta,
            this.idUsuario,
            this.idPersonaUsuario,
            this.nombreCompletoUsuario,
            this.documentoUsuario,
            this.idCliente,
            this.idPersonaCliente,
            this.nombreCompletoCliente,
            this.documentoCliente,
            this.tipoDocumento,
            this.numeroDocumento,
            this.montoPago,
            this.montoCambio,
            this.subTotal,
            this.tipoDescuento,
            this.montoDescuento,
            this.montoTotal,
            this.fechaRegistro});
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
            this.dataGridView.TabIndex = 104;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // menuEliminarPedidoVenta
            // 
            this.menuEliminarPedidoVenta.AutoSize = false;
            this.menuEliminarPedidoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menuEliminarPedidoVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEliminarPedidoVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuEliminarPedidoVenta.Name = "menuEliminarPedidoVenta";
            this.menuEliminarPedidoVenta.Size = new System.Drawing.Size(75, 30);
            this.menuEliminarPedidoVenta.Text = "Eliminar";
            this.menuEliminarPedidoVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuEliminarPedidoVenta.Click += new System.EventHandler(this.menuEliminarVenta_Click);
            // 
            // menuAgregarPedidoVenta
            // 
            this.menuAgregarPedidoVenta.AutoSize = false;
            this.menuAgregarPedidoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menuAgregarPedidoVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAgregarPedidoVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuAgregarPedidoVenta.Name = "menuAgregarPedidoVenta";
            this.menuAgregarPedidoVenta.Size = new System.Drawing.Size(73, 30);
            this.menuAgregarPedidoVenta.Text = "Agregar";
            this.menuAgregarPedidoVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAgregarPedidoVenta.Click += new System.EventHandler(this.menuAgregarVenta_Click);
            // 
            // menuVerDetallePedidoVenta
            // 
            this.menuVerDetallePedidoVenta.AutoSize = false;
            this.menuVerDetallePedidoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menuVerDetallePedidoVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVerDetallePedidoVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuVerDetallePedidoVenta.Name = "menuVerDetallePedidoVenta";
            this.menuVerDetallePedidoVenta.Size = new System.Drawing.Size(88, 30);
            this.menuVerDetallePedidoVenta.Text = "Ver detalle";
            this.menuVerDetallePedidoVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuVerDetallePedidoVenta.Click += new System.EventHandler(this.menuVerDetalleVenta_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVerDetallePedidoVenta,
            this.menuAgregarPedidoVenta,
            this.menuEliminarPedidoVenta});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1484, 34);
            this.menu.TabIndex = 102;
            this.menu.Text = "menuStrip1";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.HeaderText = "";
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.ReadOnly = true;
            this.buttonSeleccionar.Width = 30;
            // 
            // idVenta
            // 
            this.idVenta.HeaderText = "IdVenta";
            this.idVenta.Name = "idVenta";
            this.idVenta.ReadOnly = true;
            this.idVenta.Visible = false;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "IdUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // idPersonaUsuario
            // 
            this.idPersonaUsuario.HeaderText = "IdPersonaUsario";
            this.idPersonaUsuario.Name = "idPersonaUsuario";
            this.idPersonaUsuario.ReadOnly = true;
            this.idPersonaUsuario.Visible = false;
            // 
            // nombreCompletoUsuario
            // 
            this.nombreCompletoUsuario.HeaderText = "Usuario";
            this.nombreCompletoUsuario.Name = "nombreCompletoUsuario";
            this.nombreCompletoUsuario.ReadOnly = true;
            this.nombreCompletoUsuario.Width = 140;
            // 
            // documentoUsuario
            // 
            this.documentoUsuario.HeaderText = "Documento usuario";
            this.documentoUsuario.Name = "documentoUsuario";
            this.documentoUsuario.ReadOnly = true;
            this.documentoUsuario.Visible = false;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "IdCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // idPersonaCliente
            // 
            this.idPersonaCliente.HeaderText = "IdPersonaCliente";
            this.idPersonaCliente.Name = "idPersonaCliente";
            this.idPersonaCliente.ReadOnly = true;
            this.idPersonaCliente.Visible = false;
            // 
            // nombreCompletoCliente
            // 
            this.nombreCompletoCliente.HeaderText = "Cliente";
            this.nombreCompletoCliente.Name = "nombreCompletoCliente";
            this.nombreCompletoCliente.ReadOnly = true;
            this.nombreCompletoCliente.Width = 140;
            // 
            // documentoCliente
            // 
            this.documentoCliente.HeaderText = "Documento cliente";
            this.documentoCliente.Name = "documentoCliente";
            this.documentoCliente.ReadOnly = true;
            this.documentoCliente.Visible = false;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.HeaderText = "Tipo de documento";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Width = 125;
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.HeaderText = "Número del documento";
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.ReadOnly = true;
            this.numeroDocumento.Width = 125;
            // 
            // montoPago
            // 
            this.montoPago.HeaderText = "Monto pago";
            this.montoPago.Name = "montoPago";
            this.montoPago.ReadOnly = true;
            this.montoPago.Width = 125;
            // 
            // montoCambio
            // 
            this.montoCambio.HeaderText = "Monto cambio";
            this.montoCambio.Name = "montoCambio";
            this.montoCambio.ReadOnly = true;
            this.montoCambio.Width = 125;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 125;
            // 
            // tipoDescuento
            // 
            this.tipoDescuento.HeaderText = "Tipo de descuento";
            this.tipoDescuento.Name = "tipoDescuento";
            this.tipoDescuento.ReadOnly = true;
            this.tipoDescuento.Width = 125;
            // 
            // montoDescuento
            // 
            this.montoDescuento.HeaderText = "Monto descuento";
            this.montoDescuento.Name = "montoDescuento";
            this.montoDescuento.ReadOnly = true;
            this.montoDescuento.Width = 125;
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Monto total";
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            this.montoTotal.Width = 125;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha de registro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.textBoxNumeroDocumento);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenta";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label labelSubTitulo;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem menuEliminarPedidoVenta;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarPedidoVenta;
        private System.Windows.Forms.ToolStripMenuItem menuVerDetallePedidoVenta;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.DataGridViewButtonColumn buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
    }
}