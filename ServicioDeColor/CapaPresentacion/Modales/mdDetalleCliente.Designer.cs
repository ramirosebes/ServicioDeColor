namespace CapaPresentacion.Modales
{
    partial class mdDetalleCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdDetalleCliente));
            this.paneTitulo = new System.Windows.Forms.Panel();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelLineCorreo = new System.Windows.Forms.Label();
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.textBoxNombreCompleto = new System.Windows.Forms.TextBox();
            this.labelLineNombreCompleto = new System.Windows.Forms.Label();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.labelLineDocumento = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelInfo = new System.Windows.Forms.Label();
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
            this.labelSubTitulo.Size = new System.Drawing.Size(178, 33);
            this.labelSubTitulo.TabIndex = 1;
            this.labelSubTitulo.Text = "Detalle del cliente";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContenedor.Controls.Add(this.buttonVolver);
            this.panelContenedor.Controls.Add(this.buttonConfirmar);
            this.panelContenedor.Controls.Add(this.labelTelefono);
            this.panelContenedor.Controls.Add(this.textBoxTelefono);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.labelCorreo);
            this.panelContenedor.Controls.Add(this.textBoxCorreo);
            this.panelContenedor.Controls.Add(this.labelLineCorreo);
            this.panelContenedor.Controls.Add(this.labelNombreCompleto);
            this.panelContenedor.Controls.Add(this.textBoxNombreCompleto);
            this.panelContenedor.Controls.Add(this.labelLineNombreCompleto);
            this.panelContenedor.Controls.Add(this.labelDocumento);
            this.panelContenedor.Controls.Add(this.textBoxDocumento);
            this.panelContenedor.Controls.Add(this.labelLineDocumento);
            this.panelContenedor.Controls.Add(this.labelEstado);
            this.panelContenedor.Controls.Add(this.comboBoxEstado);
            this.panelContenedor.Controls.Add(this.labelInfo);
            this.panelContenedor.Location = new System.Drawing.Point(12, 68);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(460, 315);
            this.panelContenedor.TabIndex = 2;
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVolver.Location = new System.Drawing.Point(190, 276);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(80, 30);
            this.buttonVolver.TabIndex = 7;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.buttonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConfirmar.Location = new System.Drawing.Point(155, 240);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(150, 30);
            this.buttonConfirmar.TabIndex = 6;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.labelTelefono.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelTelefono.Location = new System.Drawing.Point(245, 111);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(56, 19);
            this.labelTelefono.TabIndex = 49;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefono.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxTelefono.Location = new System.Drawing.Point(245, 139);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelefono.TabIndex = 4;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            this.textBoxTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTelefono_KeyDown);
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(245, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 1);
            this.label2.TabIndex = 48;
            this.label2.Text = "label2";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.labelCorreo.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelCorreo.Location = new System.Drawing.Point(249, 46);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(47, 19);
            this.labelCorreo.TabIndex = 46;
            this.labelCorreo.Text = "Correo:";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxCorreo.Location = new System.Drawing.Point(249, 74);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(200, 20);
            this.textBoxCorreo.TabIndex = 3;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            this.textBoxCorreo.Leave += new System.EventHandler(this.textBoxCorreo_Leave);
            // 
            // labelLineCorreo
            // 
            this.labelLineCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineCorreo.Location = new System.Drawing.Point(249, 97);
            this.labelLineCorreo.Name = "labelLineCorreo";
            this.labelLineCorreo.Size = new System.Drawing.Size(200, 1);
            this.labelLineCorreo.TabIndex = 45;
            this.labelLineCorreo.Text = "label2";
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.BackColor = System.Drawing.SystemColors.Window;
            this.labelNombreCompleto.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelNombreCompleto.Location = new System.Drawing.Point(9, 111);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(103, 19);
            this.labelNombreCompleto.TabIndex = 44;
            this.labelNombreCompleto.Text = "Nombre completo:";
            // 
            // textBoxNombreCompleto
            // 
            this.textBoxNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreCompleto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCompleto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxNombreCompleto.Location = new System.Drawing.Point(9, 139);
            this.textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            this.textBoxNombreCompleto.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreCompleto.TabIndex = 2;
            this.textBoxNombreCompleto.TextChanged += new System.EventHandler(this.textBoxNombreCompleto_TextChanged);
            this.textBoxNombreCompleto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombreCompleto_KeyDown);
            this.textBoxNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreCompleto_KeyPress);
            // 
            // labelLineNombreCompleto
            // 
            this.labelLineNombreCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombreCompleto.Location = new System.Drawing.Point(9, 162);
            this.labelLineNombreCompleto.Name = "labelLineNombreCompleto";
            this.labelLineNombreCompleto.Size = new System.Drawing.Size(200, 1);
            this.labelLineNombreCompleto.TabIndex = 43;
            this.labelLineNombreCompleto.Text = "label2";
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.labelDocumento.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelDocumento.Location = new System.Drawing.Point(9, 46);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(129, 19);
            this.labelDocumento.TabIndex = 42;
            this.labelDocumento.Text = "Número de documento:";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDocumento.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocumento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxDocumento.Location = new System.Drawing.Point(9, 74);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(200, 20);
            this.textBoxDocumento.TabIndex = 1;
            this.textBoxDocumento.TextChanged += new System.EventHandler(this.textBoxDocumento_TextChanged);
            this.textBoxDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDocumento_KeyDown);
            this.textBoxDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDocumento_KeyPress);
            this.textBoxDocumento.Leave += new System.EventHandler(this.textBoxDocumento_Leave);
            // 
            // labelLineDocumento
            // 
            this.labelLineDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineDocumento.Location = new System.Drawing.Point(9, 97);
            this.labelLineDocumento.Name = "labelLineDocumento";
            this.labelLineDocumento.Size = new System.Drawing.Size(200, 1);
            this.labelLineDocumento.TabIndex = 41;
            this.labelLineDocumento.Text = "label2";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.SystemColors.Window;
            this.labelEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(9, 175);
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
            this.comboBoxEstado.Location = new System.Drawing.Point(9, 197);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(200, 27);
            this.comboBoxEstado.TabIndex = 5;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(5, 10);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(155, 23);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Información del cliente";
            // 
            // mdDetalleCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 396);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.paneTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 435);
            this.MinimumSize = new System.Drawing.Size(500, 435);
            this.Name = "mdDetalleCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle cliente";
            this.Load += new System.EventHandler(this.mdDetalleCliente_Load);
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
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label labelLineCorreo;
        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.TextBox textBoxNombreCompleto;
        private System.Windows.Forms.Label labelLineNombreCompleto;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label labelLineDocumento;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonVolver;
    }
}