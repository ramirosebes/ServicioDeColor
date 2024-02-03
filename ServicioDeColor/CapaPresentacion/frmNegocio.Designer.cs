namespace CapaPresentacion
{
    partial class frmNegocio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuEditarNegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLista = new System.Windows.Forms.Panel();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelLineDireccion = new System.Windows.Forms.Label();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.textBoxCUIT = new System.Windows.Forms.TextBox();
            this.labelLineRUC = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombreNegocio = new System.Windows.Forms.TextBox();
            this.labelLineNombre = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.panelLista.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditarNegocio});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1484, 34);
            this.menu.TabIndex = 93;
            this.menu.Text = "menuStrip1";
            // 
            // menuEditarNegocio
            // 
            this.menuEditarNegocio.AutoSize = false;
            this.menuEditarNegocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menuEditarNegocio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEditarNegocio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuEditarNegocio.Name = "menuEditarNegocio";
            this.menuEditarNegocio.Size = new System.Drawing.Size(60, 30);
            this.menuEditarNegocio.Text = "Editar";
            this.menuEditarNegocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuEditarNegocio.Click += new System.EventHandler(this.menuEditarNegocio_Click);
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelLista.Controls.Add(this.labelSubTitulo);
            this.panelLista.Location = new System.Drawing.Point(12, 37);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(1460, 80);
            this.panelLista.TabIndex = 94;
            // 
            // labelSubTitulo
            // 
            this.labelSubTitulo.AutoSize = true;
            this.labelSubTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.labelSubTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitulo.Location = new System.Drawing.Point(10, 20);
            this.labelSubTitulo.Name = "labelSubTitulo";
            this.labelSubTitulo.Size = new System.Drawing.Size(218, 39);
            this.labelSubTitulo.TabIndex = 50;
            this.labelSubTitulo.Text = "Detalle del negocio";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContenido.Controls.Add(this.buttonActualizar);
            this.panelContenido.Controls.Add(this.labelDireccion);
            this.panelContenido.Controls.Add(this.textBoxDireccion);
            this.panelContenido.Controls.Add(this.labelLineDireccion);
            this.panelContenido.Controls.Add(this.labelCUIT);
            this.panelContenido.Controls.Add(this.textBoxCUIT);
            this.panelContenido.Controls.Add(this.labelLineRUC);
            this.panelContenido.Controls.Add(this.labelNombre);
            this.panelContenido.Controls.Add(this.textBoxNombreNegocio);
            this.panelContenido.Controls.Add(this.labelLineNombre);
            this.panelContenido.Controls.Add(this.pictureBoxLogo);
            this.panelContenido.Controls.Add(this.labelLogo);
            this.panelContenido.Location = new System.Drawing.Point(12, 123);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(336, 526);
            this.panelContenido.TabIndex = 95;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelLogo.Location = new System.Drawing.Point(13, 13);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(54, 29);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "Logo:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Location = new System.Drawing.Point(18, 45);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.labelDireccion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelDireccion.Location = new System.Drawing.Point(16, 372);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(71, 23);
            this.labelDireccion.TabIndex = 44;
            this.labelDireccion.Text = "Dirección:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxDireccion.Location = new System.Drawing.Point(17, 408);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.ReadOnly = true;
            this.textBoxDireccion.Size = new System.Drawing.Size(300, 20);
            this.textBoxDireccion.TabIndex = 38;
            // 
            // labelLineDireccion
            // 
            this.labelLineDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineDireccion.Location = new System.Drawing.Point(17, 431);
            this.labelLineDireccion.Name = "labelLineDireccion";
            this.labelLineDireccion.Size = new System.Drawing.Size(300, 1);
            this.labelLineDireccion.TabIndex = 43;
            this.labelLineDireccion.Text = "label2";
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.BackColor = System.Drawing.SystemColors.Window;
            this.labelCUIT.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCUIT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelCUIT.Location = new System.Drawing.Point(13, 290);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(40, 23);
            this.labelCUIT.TabIndex = 42;
            this.labelCUIT.Text = "CUIT:";
            // 
            // textBoxCUIT
            // 
            this.textBoxCUIT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCUIT.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCUIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxCUIT.Location = new System.Drawing.Point(17, 326);
            this.textBoxCUIT.Name = "textBoxCUIT";
            this.textBoxCUIT.ReadOnly = true;
            this.textBoxCUIT.Size = new System.Drawing.Size(300, 20);
            this.textBoxCUIT.TabIndex = 37;
            // 
            // labelLineRUC
            // 
            this.labelLineRUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineRUC.Location = new System.Drawing.Point(17, 349);
            this.labelLineRUC.Name = "labelLineRUC";
            this.labelLineRUC.Size = new System.Drawing.Size(300, 1);
            this.labelLineRUC.TabIndex = 41;
            this.labelLineRUC.Text = "label2";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.SystemColors.Window;
            this.labelNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelNombre.Location = new System.Drawing.Point(13, 213);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(136, 23);
            this.labelNombre.TabIndex = 40;
            this.labelNombre.Text = "Nombre del negocio:";
            // 
            // textBoxNombreNegocio
            // 
            this.textBoxNombreNegocio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreNegocio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreNegocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxNombreNegocio.Location = new System.Drawing.Point(17, 244);
            this.textBoxNombreNegocio.Name = "textBoxNombreNegocio";
            this.textBoxNombreNegocio.ReadOnly = true;
            this.textBoxNombreNegocio.Size = new System.Drawing.Size(300, 20);
            this.textBoxNombreNegocio.TabIndex = 36;
            // 
            // labelLineNombre
            // 
            this.labelLineNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombre.Location = new System.Drawing.Point(17, 267);
            this.labelLineNombre.Name = "labelLineNombre";
            this.labelLineNombre.Size = new System.Drawing.Size(300, 1);
            this.labelLineNombre.TabIndex = 39;
            this.labelLineNombre.Text = "label2";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.AutoSize = true;
            this.buttonActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonActualizar.Location = new System.Drawing.Point(125, 445);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(87, 35);
            this.buttonActualizar.TabIndex = 52;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.menu);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuEditarNegocio;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Label labelSubTitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelLineDireccion;
        private System.Windows.Forms.Label labelCUIT;
        private System.Windows.Forms.TextBox textBoxCUIT;
        private System.Windows.Forms.Label labelLineRUC;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombreNegocio;
        private System.Windows.Forms.Label labelLineNombre;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button buttonActualizar;
    }
}