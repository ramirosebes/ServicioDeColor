namespace CapaPresentacion.Modales
{
    partial class mdAgregarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdAgregarVenta));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.textBoxTotalAPagar = new System.Windows.Forms.TextBox();
            this.labelTotalAPagar = new System.Windows.Forms.Label();
            this.textBoxPagaCon = new System.Windows.Forms.TextBox();
            this.labelPagaCon = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.labelCambio = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBoxInformacionProducto = new System.Windows.Forms.GroupBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.buttonBuscarProducto = new System.Windows.Forms.Button();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.labelProducto = new System.Windows.Forms.Label();
            this.textBoxCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxInformacionProveedor = new System.Windows.Forms.GroupBox();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.textBoxNombreCompleto = new System.Windows.Forms.TextBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.textBoxDocumentoCliente = new System.Windows.Forms.TextBox();
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.groupBoxInformacionCompra = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.labelFehca = new System.Windows.Forms.Label();
            this.labelRegistrarVentas = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.groupBoxInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBoxInformacionProveedor.SuspendLayout();
            this.groupBoxInformacionCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContenedor.Controls.Add(this.textBoxTotalAPagar);
            this.panelContenedor.Controls.Add(this.labelTotalAPagar);
            this.panelContenedor.Controls.Add(this.textBoxPagaCon);
            this.panelContenedor.Controls.Add(this.labelPagaCon);
            this.panelContenedor.Controls.Add(this.buttonRegistrar);
            this.panelContenedor.Controls.Add(this.textBoxCambio);
            this.panelContenedor.Controls.Add(this.labelCambio);
            this.panelContenedor.Controls.Add(this.dataGridViewData);
            this.panelContenedor.Controls.Add(this.buttonAgregar);
            this.panelContenedor.Controls.Add(this.groupBoxInformacionProducto);
            this.panelContenedor.Controls.Add(this.groupBoxInformacionProveedor);
            this.panelContenedor.Controls.Add(this.groupBoxInformacionCompra);
            this.panelContenedor.Controls.Add(this.labelRegistrarVentas);
            this.panelContenedor.Location = new System.Drawing.Point(12, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(835, 613);
            this.panelContenedor.TabIndex = 1;
            // 
            // textBoxTotalAPagar
            // 
            this.textBoxTotalAPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAPagar.Location = new System.Drawing.Point(688, 432);
            this.textBoxTotalAPagar.Name = "textBoxTotalAPagar";
            this.textBoxTotalAPagar.ReadOnly = true;
            this.textBoxTotalAPagar.Size = new System.Drawing.Size(129, 27);
            this.textBoxTotalAPagar.TabIndex = 22;
            this.textBoxTotalAPagar.Text = "0.00";
            // 
            // labelTotalAPagar
            // 
            this.labelTotalAPagar.AutoSize = true;
            this.labelTotalAPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAPagar.Location = new System.Drawing.Point(684, 410);
            this.labelTotalAPagar.Name = "labelTotalAPagar";
            this.labelTotalAPagar.Size = new System.Drawing.Size(81, 19);
            this.labelTotalAPagar.TabIndex = 21;
            this.labelTotalAPagar.Text = "Total a pagar:";
            // 
            // textBoxPagaCon
            // 
            this.textBoxPagaCon.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPagaCon.Location = new System.Drawing.Point(688, 484);
            this.textBoxPagaCon.Name = "textBoxPagaCon";
            this.textBoxPagaCon.Size = new System.Drawing.Size(129, 27);
            this.textBoxPagaCon.TabIndex = 20;
            this.textBoxPagaCon.Text = "0.00";
            this.textBoxPagaCon.TextChanged += new System.EventHandler(this.textBoxPagaCon_TextChanged);
            this.textBoxPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPagaCon_KeyDown);
            this.textBoxPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPagaCon_KeyPress);
            // 
            // labelPagaCon
            // 
            this.labelPagaCon.AutoSize = true;
            this.labelPagaCon.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagaCon.Location = new System.Drawing.Point(684, 462);
            this.labelPagaCon.Name = "labelPagaCon";
            this.labelPagaCon.Size = new System.Drawing.Size(61, 19);
            this.labelPagaCon.TabIndex = 19;
            this.labelPagaCon.Text = "Paga con:";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.buttonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegistrar.Location = new System.Drawing.Point(688, 569);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(129, 30);
            this.buttonRegistrar.TabIndex = 18;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCambio.Location = new System.Drawing.Point(688, 536);
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.ReadOnly = true;
            this.textBoxCambio.Size = new System.Drawing.Size(129, 27);
            this.textBoxCambio.TabIndex = 17;
            this.textBoxCambio.Text = "0.00";
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(684, 514);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(51, 19);
            this.labelCambio.TabIndex = 15;
            this.labelCambio.Text = "Cambio:";
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
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.buttonEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.Location = new System.Drawing.Point(19, 234);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewData.Size = new System.Drawing.Size(663, 365);
            this.dataGridViewData.TabIndex = 16;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            this.dataGridViewData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewData_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 50;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 230;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 120;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 120;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 120;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.HeaderText = "";
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.ReadOnly = true;
            this.buttonEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buttonEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.buttonEliminar.Width = 30;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregar.Location = new System.Drawing.Point(758, 152);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(59, 76);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // groupBoxInformacionProducto
            // 
            this.groupBoxInformacionProducto.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxInformacionProducto.Controls.Add(this.labelCantidad);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxStock);
            this.groupBoxInformacionProducto.Controls.Add(this.labelStock);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxPrecio);
            this.groupBoxInformacionProducto.Controls.Add(this.labelPrecio);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxIdProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.buttonBuscarProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.labelProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxCodigoProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.label2);
            this.groupBoxInformacionProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionProducto.Location = new System.Drawing.Point(19, 141);
            this.groupBoxInformacionProducto.Name = "groupBoxInformacionProducto";
            this.groupBoxInformacionProducto.Size = new System.Drawing.Size(733, 87);
            this.groupBoxInformacionProducto.TabIndex = 6;
            this.groupBoxInformacionProducto.TabStop = false;
            this.groupBoxInformacionProducto.Text = "Información del producto";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(625, 44);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(100, 27);
            this.numericUpDownCantidad.TabIndex = 11;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(621, 22);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(59, 19);
            this.labelCantidad.TabIndex = 23;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(519, 45);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.ReadOnly = true;
            this.textBoxStock.Size = new System.Drawing.Size(100, 27);
            this.textBoxStock.TabIndex = 10;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(515, 23);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(41, 19);
            this.labelStock.TabIndex = 21;
            this.labelStock.Text = "Stock:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(413, 45);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 27);
            this.textBoxPrecio.TabIndex = 9;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(409, 23);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(45, 19);
            this.labelPrecio.TabIndex = 19;
            this.labelPrecio.Text = "Precio:";
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Location = new System.Drawing.Point(126, 19);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(34, 27);
            this.textBoxIdProducto.TabIndex = 101;
            this.textBoxIdProducto.Visible = false;
            // 
            // buttonBuscarProducto
            // 
            this.buttonBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscarProducto.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscarProducto.Location = new System.Drawing.Point(166, 45);
            this.buttonBuscarProducto.Name = "buttonBuscarProducto";
            this.buttonBuscarProducto.Size = new System.Drawing.Size(35, 27);
            this.buttonBuscarProducto.TabIndex = 7;
            this.buttonBuscarProducto.UseVisualStyleBackColor = false;
            this.buttonBuscarProducto.Click += new System.EventHandler(this.buttonBuscarProducto_Click);
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(207, 45);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(200, 27);
            this.textBoxProducto.TabIndex = 8;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(203, 22);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(59, 19);
            this.labelProducto.TabIndex = 16;
            this.labelProducto.Text = "Producto:";
            // 
            // textBoxCodigoProducto
            // 
            this.textBoxCodigoProducto.Location = new System.Drawing.Point(10, 45);
            this.textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            this.textBoxCodigoProducto.Size = new System.Drawing.Size(150, 27);
            this.textBoxCodigoProducto.TabIndex = 6;
            this.textBoxCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoProducto_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo del producto:";
            // 
            // groupBoxInformacionProveedor
            // 
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxIdCliente);
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxNombreCompleto);
            this.groupBoxInformacionProveedor.Controls.Add(this.buttonBuscarCliente);
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxDocumentoCliente);
            this.groupBoxInformacionProveedor.Controls.Add(this.labelNombreCompleto);
            this.groupBoxInformacionProveedor.Controls.Add(this.labelNumeroDocumento);
            this.groupBoxInformacionProveedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionProveedor.Location = new System.Drawing.Point(401, 48);
            this.groupBoxInformacionProveedor.Name = "groupBoxInformacionProveedor";
            this.groupBoxInformacionProveedor.Size = new System.Drawing.Size(416, 87);
            this.groupBoxInformacionProveedor.TabIndex = 5;
            this.groupBoxInformacionProveedor.TabStop = false;
            this.groupBoxInformacionProveedor.Text = "Información del cliente";
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(373, 18);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(34, 27);
            this.textBoxIdCliente.TabIndex = 102;
            this.textBoxIdCliente.Visible = false;
            // 
            // textBoxNombreCompleto
            // 
            this.textBoxNombreCompleto.Location = new System.Drawing.Point(207, 45);
            this.textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            this.textBoxNombreCompleto.Size = new System.Drawing.Size(200, 27);
            this.textBoxNombreCompleto.TabIndex = 5;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscarCliente.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscarCliente.Location = new System.Drawing.Point(166, 45);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(35, 27);
            this.buttonBuscarCliente.TabIndex = 4;
            this.buttonBuscarCliente.UseVisualStyleBackColor = false;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // textBoxDocumentoCliente
            // 
            this.textBoxDocumentoCliente.Location = new System.Drawing.Point(10, 45);
            this.textBoxDocumentoCliente.Name = "textBoxDocumentoCliente";
            this.textBoxDocumentoCliente.Size = new System.Drawing.Size(150, 27);
            this.textBoxDocumentoCliente.TabIndex = 3;
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.Location = new System.Drawing.Point(203, 23);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(103, 19);
            this.labelNombreCompleto.TabIndex = 1;
            this.labelNombreCompleto.Text = "Nombre completo:";
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.Location = new System.Drawing.Point(6, 23);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(126, 19);
            this.labelNumeroDocumento.TabIndex = 0;
            this.labelNumeroDocumento.Text = "Numero de documento";
            // 
            // groupBoxInformacionCompra
            // 
            this.groupBoxInformacionCompra.Controls.Add(this.comboBoxTipoDocumento);
            this.groupBoxInformacionCompra.Controls.Add(this.textBoxFecha);
            this.groupBoxInformacionCompra.Controls.Add(this.labelTipoDocumento);
            this.groupBoxInformacionCompra.Controls.Add(this.labelFehca);
            this.groupBoxInformacionCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionCompra.Location = new System.Drawing.Point(19, 48);
            this.groupBoxInformacionCompra.Name = "groupBoxInformacionCompra";
            this.groupBoxInformacionCompra.Size = new System.Drawing.Size(376, 87);
            this.groupBoxInformacionCompra.TabIndex = 2;
            this.groupBoxInformacionCompra.TabStop = false;
            this.groupBoxInformacionCompra.Text = "Información de la venta";
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(166, 45);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(200, 27);
            this.comboBoxTipoDocumento.TabIndex = 2;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(10, 45);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(150, 27);
            this.textBoxFecha.TabIndex = 1;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(162, 23);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(109, 19);
            this.labelTipoDocumento.TabIndex = 1;
            this.labelTipoDocumento.Text = "Tipo de documento:";
            // 
            // labelFehca
            // 
            this.labelFehca.AutoSize = true;
            this.labelFehca.Location = new System.Drawing.Point(6, 23);
            this.labelFehca.Name = "labelFehca";
            this.labelFehca.Size = new System.Drawing.Size(44, 19);
            this.labelFehca.TabIndex = 0;
            this.labelFehca.Text = "Fecha:";
            // 
            // labelRegistrarVentas
            // 
            this.labelRegistrarVentas.AutoSize = true;
            this.labelRegistrarVentas.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarVentas.Location = new System.Drawing.Point(13, 12);
            this.labelRegistrarVentas.Name = "labelRegistrarVentas";
            this.labelRegistrarVentas.Size = new System.Drawing.Size(162, 33);
            this.labelRegistrarVentas.TabIndex = 1;
            this.labelRegistrarVentas.Text = "Registrar ventas";
            // 
            // mdAgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(859, 636);
            this.Controls.Add(this.panelContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mdAgregarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar venta";
            this.Load += new System.EventHandler(this.mdAgregarVenta_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.groupBoxInformacionProducto.ResumeLayout(false);
            this.groupBoxInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBoxInformacionProveedor.ResumeLayout(false);
            this.groupBoxInformacionProveedor.PerformLayout();
            this.groupBoxInformacionCompra.ResumeLayout(false);
            this.groupBoxInformacionCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TextBox textBoxTotalAPagar;
        private System.Windows.Forms.Label labelTotalAPagar;
        private System.Windows.Forms.TextBox textBoxPagaCon;
        private System.Windows.Forms.Label labelPagaCon;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxCambio;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.GroupBox groupBoxInformacionProducto;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.Button buttonBuscarProducto;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.TextBox textBoxCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxInformacionProveedor;
        private System.Windows.Forms.TextBox textBoxNombreCompleto;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox textBoxDocumentoCliente;
        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.GroupBox groupBoxInformacionCompra;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.Label labelFehca;
        private System.Windows.Forms.Label labelRegistrarVentas;
        private System.Windows.Forms.TextBox textBoxIdCliente;
    }
}