namespace CapaPresentacion
{
    partial class frmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentas));
            this.buttonLimpiarClientes = new System.Windows.Forms.Button();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscar1 = new System.Windows.Forms.Button();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.panelReporteCompras = new System.Windows.Forms.Panel();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColumna = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxMonto = new System.Windows.Forms.ComboBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscar2 = new System.Windows.Forms.Button();
            this.buttonLimpiarBuscador = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonDescarcarExcel = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonGrafico = new System.Windows.Forms.Button();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLimpiar3 = new System.Windows.Forms.Button();
            this.panelReporteCompras.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLimpiarClientes
            // 
            this.buttonLimpiarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiarClientes.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLimpiarClientes.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiarClientes.Location = new System.Drawing.Point(1382, 30);
            this.buttonLimpiarClientes.Name = "buttonLimpiarClientes";
            this.buttonLimpiarClientes.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiarClientes.TabIndex = 5;
            this.buttonLimpiarClientes.Text = "Limpiar";
            this.buttonLimpiarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiarClientes.UseVisualStyleBackColor = false;
            this.buttonLimpiarClientes.Click += new System.EventHandler(this.buttonLimpiarClientes_Click);
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(1095, 32);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(200, 27);
            this.comboBoxCliente.TabIndex = 3;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(10, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(208, 39);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Reporte de ventas";
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCliente.AutoSize = true;
            this.labelCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelCliente.Location = new System.Drawing.Point(1040, 36);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(49, 19);
            this.labelCliente.TabIndex = 85;
            this.labelCliente.Text = "Cliente:";
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
            // panelReporteCompras
            // 
            this.panelReporteCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReporteCompras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelReporteCompras.Controls.Add(this.buttonLimpiarClientes);
            this.panelReporteCompras.Controls.Add(this.comboBoxCliente);
            this.panelReporteCompras.Controls.Add(this.labelTitulo);
            this.panelReporteCompras.Controls.Add(this.labelCliente);
            this.panelReporteCompras.Controls.Add(this.dateTimePickerFechaFin);
            this.panelReporteCompras.Controls.Add(this.labelFechaFin);
            this.panelReporteCompras.Controls.Add(this.dateTimePickerFechaInicio);
            this.panelReporteCompras.Controls.Add(this.buttonBuscar1);
            this.panelReporteCompras.Controls.Add(this.labelFechaInicio);
            this.panelReporteCompras.Location = new System.Drawing.Point(12, 12);
            this.panelReporteCompras.Name = "panelReporteCompras";
            this.panelReporteCompras.Size = new System.Drawing.Size(1460, 80);
            this.panelReporteCompras.TabIndex = 93;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonLimpiar3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxColumna);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBoxMonto);
            this.panel1.Controls.Add(this.textBoxMonto);
            this.panel1.Controls.Add(this.comboBoxBusqueda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonBuscar2);
            this.panel1.Controls.Add(this.buttonLimpiarBuscador);
            this.panel1.Controls.Add(this.labelBuscarPor);
            this.panel1.Controls.Add(this.textBoxBusqueda);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1460, 86);
            this.panel1.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(891, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 99;
            this.label1.Text = "Filtrar por:";
            // 
            // comboBoxColumna
            // 
            this.comboBoxColumna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumna.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColumna.FormattingEnabled = true;
            this.comboBoxColumna.Location = new System.Drawing.Point(962, 43);
            this.comboBoxColumna.Name = "comboBoxColumna";
            this.comboBoxColumna.Size = new System.Drawing.Size(115, 27);
            this.comboBoxColumna.TabIndex = 98;
            this.comboBoxColumna.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumna_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Image = global::CapaPresentacion.Properties.Resources.Filtro;
            this.button3.Location = new System.Drawing.Point(1301, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 97;
            this.button3.Text = "Filtrar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonBuscar3_Click);
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
            this.comboBoxMonto.TabIndex = 95;
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
            this.textBoxMonto.TabIndex = 96;
            this.textBoxMonto.TextChanged += new System.EventHandler(this.textBoxMonto_TextChanged);
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.ItemHeight = 19;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(83, 46);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(200, 27);
            this.comboBoxBusqueda.TabIndex = 90;
            this.comboBoxBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxBusqueda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 86;
            this.label2.Text = "Opciones de búsqueda";
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
            // buttonLimpiarBuscador
            // 
            this.buttonLimpiarBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLimpiarBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiarBuscador.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarBuscador.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLimpiarBuscador.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiarBuscador.Location = new System.Drawing.Point(576, 43);
            this.buttonLimpiarBuscador.Name = "buttonLimpiarBuscador";
            this.buttonLimpiarBuscador.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiarBuscador.TabIndex = 9;
            this.buttonLimpiarBuscador.Text = "Limpiar";
            this.buttonLimpiarBuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiarBuscador.UseVisualStyleBackColor = false;
            this.buttonLimpiarBuscador.Click += new System.EventHandler(this.buttonLimpiarBuscador_Click);
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
            this.DocumentoCliente,
            this.NombreCliente,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioVenta,
            this.Cantidad,
            this.tipoDescuento,
            this.montoDescuento,
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
            this.dataGridViewData.TabIndex = 96;
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
            this.buttonGrafico.TabIndex = 97;
            this.buttonGrafico.Text = "Gráfico";
            this.buttonGrafico.UseVisualStyleBackColor = false;
            this.buttonGrafico.Click += new System.EventHandler(this.buttonGrafico_Click);
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
            this.TipoDocumento.Width = 90;
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
            // DocumentoCliente
            // 
            this.DocumentoCliente.HeaderText = "Documento cliente";
            this.DocumentoCliente.Name = "DocumentoCliente";
            this.DocumentoCliente.ReadOnly = true;
            this.DocumentoCliente.Width = 90;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Código Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            this.CodigoProducto.Width = 70;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
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
            this.Cantidad.Width = 60;
            // 
            // tipoDescuento
            // 
            this.tipoDescuento.HeaderText = "Tipo de descuento";
            this.tipoDescuento.Name = "tipoDescuento";
            this.tipoDescuento.ReadOnly = true;
            // 
            // montoDescuento
            // 
            this.montoDescuento.HeaderText = "Monto descuento";
            this.montoDescuento.Name = "montoDescuento";
            this.montoDescuento.ReadOnly = true;
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
            this.buttonLimpiar3.TabIndex = 102;
            this.buttonLimpiar3.Text = "Limpiar";
            this.buttonLimpiar3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar3.UseVisualStyleBackColor = false;
            this.buttonLimpiar3.Click += new System.EventHandler(this.buttonLimpiar3_Click);
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.buttonGrafico);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panelReporteCompras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDescarcarExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteVentas";
            this.Text = "Reporte de ventas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            this.panelReporteCompras.ResumeLayout(false);
            this.panelReporteCompras.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLimpiarClientes;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Button buttonBuscar1;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Panel panelReporteCompras;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscar2;
        private System.Windows.Forms.Button buttonLimpiarBuscador;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button buttonDescarcarExcel;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonGrafico;
        private System.Windows.Forms.ComboBox comboBoxColumna;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxMonto;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.Button buttonLimpiar3;
    }
}