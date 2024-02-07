namespace CapaPresentacion
{
    partial class frmCompra
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuVerDetalleCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEliminarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panelLista = new System.Windows.Forms.Panel();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVerDetalleCompra,
            this.menuAgregarCompra,
            this.menuEliminarCompra});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1484, 34);
            this.menu.TabIndex = 97;
            this.menu.Text = "menuStrip1";
            // 
            // menuVerDetalleCompra
            // 
            this.menuVerDetalleCompra.AutoSize = false;
            this.menuVerDetalleCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menuVerDetalleCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVerDetalleCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuVerDetalleCompra.Name = "menuVerDetalleCompra";
            this.menuVerDetalleCompra.Size = new System.Drawing.Size(88, 30);
            this.menuVerDetalleCompra.Text = "Ver detalle";
            this.menuVerDetalleCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuVerDetalleCompra.Click += new System.EventHandler(this.menuVerDetalleCompra_Click);
            // 
            // menuAgregarCompra
            // 
            this.menuAgregarCompra.AutoSize = false;
            this.menuAgregarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menuAgregarCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAgregarCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuAgregarCompra.Name = "menuAgregarCompra";
            this.menuAgregarCompra.Size = new System.Drawing.Size(73, 30);
            this.menuAgregarCompra.Text = "Agregar";
            this.menuAgregarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAgregarCompra.Click += new System.EventHandler(this.menuAgregarCompra_Click);
            // 
            // menuEliminarCompra
            // 
            this.menuEliminarCompra.AutoSize = false;
            this.menuEliminarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menuEliminarCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEliminarCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuEliminarCompra.Name = "menuEliminarCompra";
            this.menuEliminarCompra.Size = new System.Drawing.Size(75, 30);
            this.menuEliminarCompra.Text = "Eliminar";
            this.menuEliminarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuEliminarCompra.Click += new System.EventHandler(this.menuEliminarCompra_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
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
            this.idCompra,
            this.idUsuario,
            this.idPersona,
            this.nombreCompletoUsuario,
            this.idProveedor,
            this.razonSocial,
            this.tipoDocumento,
            this.numeroDocumento,
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
            this.dataGridView.TabIndex = 99;
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
            // idCompra
            // 
            this.idCompra.HeaderText = "IdCompra";
            this.idCompra.Name = "idCompra";
            this.idCompra.ReadOnly = true;
            this.idCompra.Visible = false;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "IdUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // idPersona
            // 
            this.idPersona.HeaderText = "IdPersona";
            this.idPersona.Name = "idPersona";
            this.idPersona.ReadOnly = true;
            this.idPersona.Visible = false;
            // 
            // nombreCompletoUsuario
            // 
            this.nombreCompletoUsuario.HeaderText = "Usuario";
            this.nombreCompletoUsuario.Name = "nombreCompletoUsuario";
            this.nombreCompletoUsuario.ReadOnly = true;
            this.nombreCompletoUsuario.Width = 200;
            // 
            // idProveedor
            // 
            this.idProveedor.HeaderText = "IdProveedor";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            this.idProveedor.Visible = false;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Proveedor";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 200;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.HeaderText = "Tip de documento";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Width = 200;
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.HeaderText = "Numero de documento";
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.ReadOnly = true;
            this.numeroDocumento.Width = 200;
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Monto total";
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            this.montoTotal.Width = 150;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha de registro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            this.fechaRegistro.Width = 150;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(1266, 11);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 100;
            this.textBoxId.Visible = false;
            // 
            // panelLista
            // 
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
            this.panelLista.TabIndex = 98;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonActualizar.Location = new System.Drawing.Point(1372, 30);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 30);
            this.buttonActualizar.TabIndex = 51;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // labelSubTitulo
            // 
            this.labelSubTitulo.AutoSize = true;
            this.labelSubTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.labelSubTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitulo.Location = new System.Drawing.Point(10, 20);
            this.labelSubTitulo.Name = "labelSubTitulo";
            this.labelSubTitulo.Size = new System.Drawing.Size(198, 39);
            this.labelSubTitulo.TabIndex = 50;
            this.labelSubTitulo.Text = "Lista de compras";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.ItemHeight = 19;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(849, 29);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(174, 27);
            this.comboBoxBusqueda.TabIndex = 42;
            this.comboBoxBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxBusqueda_SelectedIndexChanged);
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBuscarPor.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelBuscarPor.Location = new System.Drawing.Point(774, 32);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(69, 19);
            this.labelBuscarPor.TabIndex = 41;
            this.labelBuscarPor.Text = "Buscar por:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLimpiar.Location = new System.Drawing.Point(1291, 30);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxBusqueda.Location = new System.Drawing.Point(1029, 30);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(175, 27);
            this.textBoxBusqueda.TabIndex = 12;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscar.Location = new System.Drawing.Point(1210, 30);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(1372, 11);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroDocumento.TabIndex = 101;
            this.textBoxNumeroDocumento.Visible = false;
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.textBoxNumeroDocumento);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelLista);
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuVerDetalleCompra;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarCompra;
        private System.Windows.Forms.ToolStripMenuItem menuEliminarCompra;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label labelSubTitulo;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.DataGridViewButtonColumn buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
    }
}