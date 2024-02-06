namespace CapaPresentacion.Modales
{
    partial class mdListaClientes
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
            this.panelCliente = new System.Windows.Forms.Panel();
            this.buttonLimpiarBuscardor = new System.Windows.Forms.Button();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCliente.Controls.Add(this.buttonLimpiarBuscardor);
            this.panelCliente.Controls.Add(this.labelBuscarPor);
            this.panelCliente.Controls.Add(this.buttonBuscar);
            this.panelCliente.Controls.Add(this.textBoxBusqueda);
            this.panelCliente.Controls.Add(this.labelTitulo);
            this.panelCliente.Controls.Add(this.comboBoxBusqueda);
            this.panelCliente.Location = new System.Drawing.Point(12, 12);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(543, 97);
            this.panelCliente.TabIndex = 55;
            // 
            // buttonLimpiarBuscardor
            // 
            this.buttonLimpiarBuscardor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiarBuscardor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiarBuscardor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiarBuscardor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarBuscardor.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLimpiarBuscardor.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiarBuscardor.Location = new System.Drawing.Point(492, 50);
            this.buttonLimpiarBuscardor.Name = "buttonLimpiarBuscardor";
            this.buttonLimpiarBuscardor.Size = new System.Drawing.Size(35, 30);
            this.buttonLimpiarBuscardor.TabIndex = 54;
            this.buttonLimpiarBuscardor.UseVisualStyleBackColor = false;
            this.buttonLimpiarBuscardor.Click += new System.EventHandler(this.buttonLimpiarBuscardor_Click);
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBuscarPor.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelBuscarPor.Location = new System.Drawing.Point(15, 53);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(69, 19);
            this.labelBuscarPor.TabIndex = 51;
            this.labelBuscarPor.Text = "Buscar por:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscar.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscar.Location = new System.Drawing.Point(451, 50);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(35, 30);
            this.buttonBuscar.TabIndex = 53;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxBusqueda.Location = new System.Drawing.Point(270, 50);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(175, 27);
            this.textBoxBusqueda.TabIndex = 52;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(13, 10);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(166, 33);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Lista de clientes:";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.ItemHeight = 19;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(90, 50);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(174, 27);
            this.comboBoxBusqueda.TabIndex = 55;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.documento,
            this.nombreCompleto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewData.RowTemplate.Height = 28;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(543, 377);
            this.dataGridViewData.TabIndex = 56;
            this.dataGridViewData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellDoubleClick);
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "IdCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 150;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.HeaderText = "Nombre completo";
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            this.nombreCompleto.Width = 250;
            // 
            // mdListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(566, 503);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "mdListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista clientes";
            this.Load += new System.EventHandler(this.mdListaClientes_Load);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Button buttonLimpiarBuscardor;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
    }
}