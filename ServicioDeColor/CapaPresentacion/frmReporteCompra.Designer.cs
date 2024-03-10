namespace CapaPresentacion
{
    partial class frmReporteCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCompra));
            this.buttonDescarcarExcel = new System.Windows.Forms.Button();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLimpiar2 = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonBuscar2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLimpiar3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColumna = new System.Windows.Forms.ComboBox();
            this.buttonBuscar3 = new System.Windows.Forms.Button();
            this.comboBoxMonto = new System.Windows.Forms.ComboBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.buttonBuscar1 = new System.Windows.Forms.Button();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.panelReporteCompras = new System.Windows.Forms.Panel();
            this.buttonLimpiar1 = new System.Windows.Forms.Button();
            this.buttonGrafico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.panelReporteCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDescarcarExcel
            // 
            this.buttonDescarcarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDescarcarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.buttonDescarcarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDescarcarExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.buttonDescarcarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDescarcarExcel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDescarcarExcel.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDescarcarExcel.Location = new System.Drawing.Point(1322, 619);
            this.buttonDescarcarExcel.Name = "buttonDescarcarExcel";
            this.buttonDescarcarExcel.Size = new System.Drawing.Size(150, 30);
            this.buttonDescarcarExcel.TabIndex = 10;
            this.buttonDescarcarExcel.Text = "Descargar Excel";
            this.buttonDescarcarExcel.UseVisualStyleBackColor = false;
            this.buttonDescarcarExcel.Click += new System.EventHandler(this.buttonDescarcarExcel_Click);
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(83, 46);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(200, 27);
            this.comboBoxBusqueda.TabIndex = 6;
            this.comboBoxBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxBusqueda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 86;
            this.label2.Text = "Opciones de búsqueda";
            // 
            // buttonLimpiar2
            // 
            this.buttonLimpiar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLimpiar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar2.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLimpiar2.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiar2.Location = new System.Drawing.Point(576, 43);
            this.buttonLimpiar2.Name = "buttonLimpiar2";
            this.buttonLimpiar2.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiar2.TabIndex = 9;
            this.buttonLimpiar2.Text = "Limpiar";
            this.buttonLimpiar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar2.UseVisualStyleBackColor = false;
            this.buttonLimpiar2.Click += new System.EventHandler(this.buttonLimpiar2_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxBusqueda.Location = new System.Drawing.Point(289, 46);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(200, 27);
            this.textBoxBusqueda.TabIndex = 7;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            // 
            // buttonBuscar2
            // 
            this.buttonBuscar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar2.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscar2.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscar2.Location = new System.Drawing.Point(495, 43);
            this.buttonBuscar2.Name = "buttonBuscar2";
            this.buttonBuscar2.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscar2.TabIndex = 8;
            this.buttonBuscar2.Text = "Buscar";
            this.buttonBuscar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar2.UseVisualStyleBackColor = false;
            this.buttonBuscar2.Click += new System.EventHandler(this.buttonBuscar2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonLimpiar3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxColumna);
            this.panel1.Controls.Add(this.buttonBuscar3);
            this.panel1.Controls.Add(this.comboBoxMonto);
            this.panel1.Controls.Add(this.textBoxMonto);
            this.panel1.Controls.Add(this.comboBoxBusqueda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonBuscar2);
            this.panel1.Controls.Add(this.buttonLimpiar2);
            this.panel1.Controls.Add(this.labelBuscarPor);
            this.panel1.Controls.Add(this.textBoxBusqueda);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1460, 86);
            this.panel1.TabIndex = 3;
            // 
            // buttonLimpiar3
            // 
            this.buttonLimpiar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar3.FlatAppearance.BorderSize = 0;
            this.buttonLimpiar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar3.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLimpiar3.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiar3.Location = new System.Drawing.Point(1382, 43);
            this.buttonLimpiar3.Name = "buttonLimpiar3";
            this.buttonLimpiar3.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiar3.TabIndex = 101;
            this.buttonLimpiar3.Text = "Limpiar";
            this.buttonLimpiar3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar3.UseVisualStyleBackColor = false;
            this.buttonLimpiar3.Click += new System.EventHandler(this.buttonLimpiar3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(891, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "Filtrar por:";
            // 
            // comboBoxColumna
            // 
            this.comboBoxColumna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumna.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColumna.FormattingEnabled = true;
            this.comboBoxColumna.Location = new System.Drawing.Point(962, 44);
            this.comboBoxColumna.Name = "comboBoxColumna";
            this.comboBoxColumna.Size = new System.Drawing.Size(115, 27);
            this.comboBoxColumna.TabIndex = 94;
            this.comboBoxColumna.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumna_SelectedIndexChanged);
            // 
            // buttonBuscar3
            // 
            this.buttonBuscar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar3.AutoSize = true;
            this.buttonBuscar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar3.FlatAppearance.BorderSize = 0;
            this.buttonBuscar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar3.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscar3.Image = global::CapaPresentacion.Properties.Resources.Filtro;
            this.buttonBuscar3.Location = new System.Drawing.Point(1301, 43);
            this.buttonBuscar3.Name = "buttonBuscar3";
            this.buttonBuscar3.Size = new System.Drawing.Size(75, 29);
            this.buttonBuscar3.TabIndex = 93;
            this.buttonBuscar3.Text = "Filtrar";
            this.buttonBuscar3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar3.UseVisualStyleBackColor = false;
            this.buttonBuscar3.Click += new System.EventHandler(this.buttonBuscar3_Click);
            // 
            // comboBoxMonto
            // 
            this.comboBoxMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMonto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonto.FormattingEnabled = true;
            this.comboBoxMonto.Location = new System.Drawing.Point(1083, 43);
            this.comboBoxMonto.Name = "comboBoxMonto";
            this.comboBoxMonto.Size = new System.Drawing.Size(107, 27);
            this.comboBoxMonto.TabIndex = 90;
            this.comboBoxMonto.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonto_SelectedIndexChanged);
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMonto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMonto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxMonto.Location = new System.Drawing.Point(1196, 43);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(99, 27);
            this.textBoxMonto.TabIndex = 91;
            this.textBoxMonto.TextChanged += new System.EventHandler(this.textBoxMonto_TextChanged);
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBuscarPor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelBuscarPor.Location = new System.Drawing.Point(13, 49);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(69, 19);
            this.labelBuscarPor.TabIndex = 89;
            this.labelBuscarPor.Text = "Buscar por:";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.UsuarioRegistro,
            this.DocumentoProveedor,
            this.RazonSocial,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.MontoTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 190);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.Size = new System.Drawing.Size(1460, 423);
            this.dataGridViewData.TabIndex = 1;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Número Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // DocumentoProveedor
            // 
            this.DocumentoProveedor.HeaderText = "CUIT Proveedor";
            this.DocumentoProveedor.Name = "DocumentoProveedor";
            this.DocumentoProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Código Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoía";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProveedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(1095, 32);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(200, 27);
            this.comboBoxProveedor.TabIndex = 3;
            this.comboBoxProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxProveedor_SelectedIndexChanged);
            // 
            // buttonBuscar1
            // 
            this.buttonBuscar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar1.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscar1.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscar1.Location = new System.Drawing.Point(1301, 30);
            this.buttonBuscar1.Name = "buttonBuscar1";
            this.buttonBuscar1.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscar1.TabIndex = 4;
            this.buttonBuscar1.Text = "Buscar";
            this.buttonBuscar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar1.UseVisualStyleBackColor = false;
            this.buttonBuscar1.Click += new System.EventHandler(this.buttonBuscar1_Click);
            // 
            // labelProveedor
            // 
            this.labelProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProveedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelProveedor.Location = new System.Drawing.Point(1025, 36);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(64, 19);
            this.labelProveedor.TabIndex = 85;
            this.labelProveedor.Text = "Proveedor:";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFechaFin.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelFechaFin.Location = new System.Drawing.Point(835, 36);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(76, 19);
            this.labelFechaFin.TabIndex = 81;
            this.labelFechaFin.Text = "Fecha de fin:";
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFechaFin.CustomFormat = "";
            this.dateTimePickerFechaFin.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(919, 33);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(100, 27);
            this.dateTimePickerFechaFin.TabIndex = 2;
            this.dateTimePickerFechaFin.ValueChanged += new System.EventHandler(this.dateTimePickerFechaFin_ValueChanged);
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFechaInicio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelFechaInicio.Location = new System.Drawing.Point(633, 36);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(90, 19);
            this.labelFechaInicio.TabIndex = 79;
            this.labelFechaInicio.Text = "Fecha de inicio:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(10, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(229, 39);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Reporte de compras";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFechaInicio.CustomFormat = "";
            this.dateTimePickerFechaInicio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(729, 33);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(100, 27);
            this.dateTimePickerFechaInicio.TabIndex = 1;
            this.dateTimePickerFechaInicio.ValueChanged += new System.EventHandler(this.dateTimePickerFechaInicio_ValueChanged);
            // 
            // panelReporteCompras
            // 
            this.panelReporteCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReporteCompras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelReporteCompras.Controls.Add(this.buttonLimpiar1);
            this.panelReporteCompras.Controls.Add(this.comboBoxProveedor);
            this.panelReporteCompras.Controls.Add(this.labelTitulo);
            this.panelReporteCompras.Controls.Add(this.labelProveedor);
            this.panelReporteCompras.Controls.Add(this.dateTimePickerFechaFin);
            this.panelReporteCompras.Controls.Add(this.labelFechaFin);
            this.panelReporteCompras.Controls.Add(this.dateTimePickerFechaInicio);
            this.panelReporteCompras.Controls.Add(this.buttonBuscar1);
            this.panelReporteCompras.Controls.Add(this.labelFechaInicio);
            this.panelReporteCompras.Location = new System.Drawing.Point(12, 12);
            this.panelReporteCompras.Name = "panelReporteCompras";
            this.panelReporteCompras.Size = new System.Drawing.Size(1460, 80);
            this.panelReporteCompras.TabIndex = 2;
            // 
            // buttonLimpiar1
            // 
            this.buttonLimpiar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar1.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLimpiar1.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiar1.Location = new System.Drawing.Point(1382, 30);
            this.buttonLimpiar1.Name = "buttonLimpiar1";
            this.buttonLimpiar1.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiar1.TabIndex = 5;
            this.buttonLimpiar1.Text = "Limpiar";
            this.buttonLimpiar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar1.UseVisualStyleBackColor = false;
            this.buttonLimpiar1.Click += new System.EventHandler(this.buttonLimpiar1_Click);
            // 
            // buttonGrafico
            // 
            this.buttonGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.buttonGrafico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.buttonGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrafico.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrafico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGrafico.Location = new System.Drawing.Point(1241, 619);
            this.buttonGrafico.Name = "buttonGrafico";
            this.buttonGrafico.Size = new System.Drawing.Size(75, 30);
            this.buttonGrafico.TabIndex = 11;
            this.buttonGrafico.Text = "Gráfico";
            this.buttonGrafico.UseVisualStyleBackColor = false;
            this.buttonGrafico.Click += new System.EventHandler(this.buttonGrafico_Click);
            // 
            // frmReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.buttonGrafico);
            this.Controls.Add(this.buttonDescarcarExcel);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelReporteCompras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteCompra";
            this.Text = "Reporte de compras";
            this.Load += new System.EventHandler(this.frmReporteCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.panelReporteCompras.ResumeLayout(false);
            this.panelReporteCompras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDescarcarExcel;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLimpiar2;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button buttonBuscar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private System.Windows.Forms.Button buttonBuscar1;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Panel panelReporteCompras;
        private System.Windows.Forms.Button buttonLimpiar1;
        private System.Windows.Forms.Button buttonGrafico;
        private System.Windows.Forms.ComboBox comboBoxMonto;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Button buttonBuscar3;
        private System.Windows.Forms.ComboBox comboBoxColumna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.Button buttonLimpiar3;
    }
}