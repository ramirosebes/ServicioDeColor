namespace CapaPresentacion.Modales
{
    partial class mdDetallePermisoSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdDetallePermisoSimple));
            this.paneTitulo = new System.Windows.Forms.Panel();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.labelNombreMenu = new System.Windows.Forms.Label();
            this.textBoxNombreMenu = new System.Windows.Forms.TextBox();
            this.labelLineNombreMenu = new System.Windows.Forms.Label();
            this.labelNombrePermiso = new System.Windows.Forms.Label();
            this.textBoxNombrePermiso = new System.Windows.Forms.TextBox();
            this.labelLineNombre = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelInfoPermiso = new System.Windows.Forms.Label();
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
            this.paneTitulo.Size = new System.Drawing.Size(460, 50);
            this.paneTitulo.TabIndex = 1;
            // 
            // labelSubTitulo
            // 
            this.labelSubTitulo.AutoSize = true;
            this.labelSubTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitulo.Location = new System.Drawing.Point(4, 9);
            this.labelSubTitulo.Name = "labelSubTitulo";
            this.labelSubTitulo.Size = new System.Drawing.Size(189, 33);
            this.labelSubTitulo.TabIndex = 1;
            this.labelSubTitulo.Text = "Detalle del permiso";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContenedor.Controls.Add(this.buttonVolver);
            this.panelContenedor.Controls.Add(this.labelNombreMenu);
            this.panelContenedor.Controls.Add(this.textBoxNombreMenu);
            this.panelContenedor.Controls.Add(this.labelLineNombreMenu);
            this.panelContenedor.Controls.Add(this.labelNombrePermiso);
            this.panelContenedor.Controls.Add(this.textBoxNombrePermiso);
            this.panelContenedor.Controls.Add(this.labelLineNombre);
            this.panelContenedor.Controls.Add(this.labelEstado);
            this.panelContenedor.Controls.Add(this.comboBoxEstado);
            this.panelContenedor.Controls.Add(this.labelInfoPermiso);
            this.panelContenedor.Location = new System.Drawing.Point(12, 68);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(460, 210);
            this.panelContenedor.TabIndex = 8;
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVolver.Location = new System.Drawing.Point(190, 169);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(80, 30);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // labelNombreMenu
            // 
            this.labelNombreMenu.AutoSize = true;
            this.labelNombreMenu.BackColor = System.Drawing.SystemColors.Window;
            this.labelNombreMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelNombreMenu.Location = new System.Drawing.Point(249, 46);
            this.labelNombreMenu.Name = "labelNombreMenu";
            this.labelNombreMenu.Size = new System.Drawing.Size(104, 19);
            this.labelNombreMenu.TabIndex = 44;
            this.labelNombreMenu.Text = "Nombre del menú:";
            // 
            // textBoxNombreMenu
            // 
            this.textBoxNombreMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreMenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxNombreMenu.Location = new System.Drawing.Point(249, 74);
            this.textBoxNombreMenu.Name = "textBoxNombreMenu";
            this.textBoxNombreMenu.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreMenu.TabIndex = 2;
            // 
            // labelLineNombreMenu
            // 
            this.labelLineNombreMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombreMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombreMenu.Location = new System.Drawing.Point(249, 97);
            this.labelLineNombreMenu.Name = "labelLineNombreMenu";
            this.labelLineNombreMenu.Size = new System.Drawing.Size(200, 1);
            this.labelLineNombreMenu.TabIndex = 43;
            this.labelLineNombreMenu.Text = "label2";
            // 
            // labelNombrePermiso
            // 
            this.labelNombrePermiso.AutoSize = true;
            this.labelNombrePermiso.BackColor = System.Drawing.SystemColors.Window;
            this.labelNombrePermiso.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombrePermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelNombrePermiso.Location = new System.Drawing.Point(9, 46);
            this.labelNombrePermiso.Name = "labelNombrePermiso";
            this.labelNombrePermiso.Size = new System.Drawing.Size(116, 19);
            this.labelNombrePermiso.TabIndex = 42;
            this.labelNombrePermiso.Text = "Nombre del permiso:";
            // 
            // textBoxNombrePermiso
            // 
            this.textBoxNombrePermiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombrePermiso.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombrePermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxNombrePermiso.Location = new System.Drawing.Point(9, 74);
            this.textBoxNombrePermiso.Name = "textBoxNombrePermiso";
            this.textBoxNombrePermiso.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombrePermiso.TabIndex = 1;
            // 
            // labelLineNombre
            // 
            this.labelLineNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombre.Location = new System.Drawing.Point(9, 97);
            this.labelLineNombre.Name = "labelLineNombre";
            this.labelLineNombre.Size = new System.Drawing.Size(200, 1);
            this.labelLineNombre.TabIndex = 41;
            this.labelLineNombre.Text = "label2";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.SystemColors.Window;
            this.labelEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(9, 109);
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
            this.comboBoxEstado.Location = new System.Drawing.Point(9, 131);
            this.comboBoxEstado.MaximumSize = new System.Drawing.Size(200, 0);
            this.comboBoxEstado.MinimumSize = new System.Drawing.Size(200, 0);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(200, 27);
            this.comboBoxEstado.TabIndex = 3;
            // 
            // labelInfoPermiso
            // 
            this.labelInfoPermiso.AutoSize = true;
            this.labelInfoPermiso.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoPermiso.Location = new System.Drawing.Point(5, 10);
            this.labelInfoPermiso.Name = "labelInfoPermiso";
            this.labelInfoPermiso.Size = new System.Drawing.Size(164, 23);
            this.labelInfoPermiso.TabIndex = 0;
            this.labelInfoPermiso.Text = "Información del permiso";
            // 
            // mdDetallePermisoSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(484, 291);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.paneTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 330);
            this.MinimumSize = new System.Drawing.Size(500, 330);
            this.Name = "mdDetallePermisoSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle permiso";
            this.Load += new System.EventHandler(this.mdDetallePermisoSimple_Load);
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
        private System.Windows.Forms.Label labelNombreMenu;
        private System.Windows.Forms.TextBox textBoxNombreMenu;
        private System.Windows.Forms.Label labelLineNombreMenu;
        private System.Windows.Forms.Label labelNombrePermiso;
        private System.Windows.Forms.TextBox textBoxNombrePermiso;
        private System.Windows.Forms.Label labelLineNombre;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelInfoPermiso;
        private System.Windows.Forms.Button buttonVolver;
    }
}