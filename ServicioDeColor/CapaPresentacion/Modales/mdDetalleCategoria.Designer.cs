namespace CapaPresentacion.Modales
{
    partial class mdDetalleCategoria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdDetalleCategoria));
            this.paneTitulo = new System.Windows.Forms.Panel();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paneTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneTitulo
            // 
            this.paneTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paneTitulo.Controls.Add(this.labelSubTitulo);
            this.paneTitulo.Location = new System.Drawing.Point(12, 12);
            this.paneTitulo.Name = "paneTitulo";
            this.paneTitulo.Size = new System.Drawing.Size(283, 50);
            this.paneTitulo.TabIndex = 1;
            // 
            // labelSubTitulo
            // 
            this.labelSubTitulo.AutoSize = true;
            this.labelSubTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitulo.Location = new System.Drawing.Point(4, 9);
            this.labelSubTitulo.Name = "labelSubTitulo";
            this.labelSubTitulo.Size = new System.Drawing.Size(217, 33);
            this.labelSubTitulo.TabIndex = 1;
            this.labelSubTitulo.Text = "Detalle de la categoría";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContenedor.Controls.Add(this.richTextBoxDescripcion);
            this.panelContenedor.Controls.Add(this.buttonConfirmar);
            this.panelContenedor.Controls.Add(this.buttonVolver);
            this.panelContenedor.Controls.Add(this.labelEstado);
            this.panelContenedor.Controls.Add(this.comboBoxEstado);
            this.panelContenedor.Controls.Add(this.labelDescripcion);
            this.panelContenedor.Controls.Add(this.labelInfo);
            this.panelContenedor.Location = new System.Drawing.Point(12, 68);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(283, 312);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(9, 68);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(264, 100);
            this.richTextBoxDescripcion.TabIndex = 1;
            this.richTextBoxDescripcion.Text = "";
            this.richTextBoxDescripcion.TextChanged += new System.EventHandler(this.richTextBoxDescripcion_TextChanged_1);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.buttonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConfirmar.Location = new System.Drawing.Point(66, 236);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(150, 30);
            this.buttonConfirmar.TabIndex = 3;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVolver.Location = new System.Drawing.Point(101, 272);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(80, 30);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.SystemColors.Window;
            this.labelEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(9, 171);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(47, 19);
            this.labelEstado.TabIndex = 40;
            this.labelEstado.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.ItemHeight = 19;
            this.comboBoxEstado.Location = new System.Drawing.Point(9, 193);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(264, 27);
            this.comboBoxEstado.TabIndex = 2;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.labelDescripcion.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDescripcion.Location = new System.Drawing.Point(9, 46);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(73, 19);
            this.labelDescripcion.TabIndex = 42;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(5, 10);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(185, 23);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Información de la categoria";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mdDetalleCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 390);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.paneTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 429);
            this.MinimumSize = new System.Drawing.Size(321, 429);
            this.Name = "mdDetalleCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle categoría";
            this.Load += new System.EventHandler(this.mdDetalleCategoria_Load);
            this.paneTitulo.ResumeLayout(false);
            this.paneTitulo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneTitulo;
        private System.Windows.Forms.Label labelSubTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}