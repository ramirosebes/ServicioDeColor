namespace CapaPresentacion.Modales
{
    partial class mdDetalleUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdDetalleUsuario));
            this.paneTitulo = new System.Windows.Forms.Panel();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.panelClave = new System.Windows.Forms.Panel();
            this.buttonVerClave = new System.Windows.Forms.Button();
            this.textBoxConfirmarClave = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.labelConfirmarClave = new System.Windows.Forms.Label();
            this.labelLineClave = new System.Windows.Forms.Label();
            this.labelLineConfirmarClave = new System.Windows.Forms.Label();
            this.panelInfoUsuario = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelLineDocumento = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.labelLineNombreCompleto = new System.Windows.Forms.Label();
            this.textBoxNombreCompleto = new System.Windows.Forms.TextBox();
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.labelLineCorreo = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.paneTitulo.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelClave.SuspendLayout();
            this.panelInfoUsuario.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneTitulo
            // 
            this.paneTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paneTitulo.Controls.Add(this.labelSubTitulo);
            resources.ApplyResources(this.paneTitulo, "paneTitulo");
            this.paneTitulo.Name = "paneTitulo";
            // 
            // labelSubTitulo
            // 
            resources.ApplyResources(this.labelSubTitulo, "labelSubTitulo");
            this.labelSubTitulo.Name = "labelSubTitulo";
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonVolver, "buttonVolver");
            this.buttonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelButtons.Controls.Add(this.buttonConfirmar);
            this.panelButtons.Controls.Add(this.buttonVolver);
            resources.ApplyResources(this.panelButtons, "panelButtons");
            this.panelButtons.Name = "panelButtons";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.buttonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonConfirmar, "buttonConfirmar");
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // panelClave
            // 
            this.panelClave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelClave.Controls.Add(this.buttonVerClave);
            this.panelClave.Controls.Add(this.textBoxConfirmarClave);
            this.panelClave.Controls.Add(this.textBoxClave);
            this.panelClave.Controls.Add(this.labelClave);
            this.panelClave.Controls.Add(this.labelConfirmarClave);
            this.panelClave.Controls.Add(this.labelLineClave);
            this.panelClave.Controls.Add(this.labelLineConfirmarClave);
            resources.ApplyResources(this.panelClave, "panelClave");
            this.panelClave.Name = "panelClave";
            // 
            // buttonVerClave
            // 
            this.buttonVerClave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVerClave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonVerClave, "buttonVerClave");
            this.buttonVerClave.Image = global::CapaPresentacion.Properties.Resources.OjoContrasena1;
            this.buttonVerClave.Name = "buttonVerClave";
            this.buttonVerClave.UseVisualStyleBackColor = false;
            this.buttonVerClave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonVerClave_MouseDown);
            this.buttonVerClave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonVerClave_MouseUp);
            // 
            // textBoxConfirmarClave
            // 
            this.textBoxConfirmarClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxConfirmarClave, "textBoxConfirmarClave");
            this.textBoxConfirmarClave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxConfirmarClave.Name = "textBoxConfirmarClave";
            this.textBoxConfirmarClave.TextChanged += new System.EventHandler(this.textBoxConfirmarClave_TextChanged);
            // 
            // textBoxClave
            // 
            this.textBoxClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxClave, "textBoxClave");
            this.textBoxClave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.TextChanged += new System.EventHandler(this.textBoxClave_TextChanged);
            // 
            // labelClave
            // 
            resources.ApplyResources(this.labelClave, "labelClave");
            this.labelClave.BackColor = System.Drawing.SystemColors.Window;
            this.labelClave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelClave.Name = "labelClave";
            // 
            // labelConfirmarClave
            // 
            resources.ApplyResources(this.labelConfirmarClave, "labelConfirmarClave");
            this.labelConfirmarClave.BackColor = System.Drawing.SystemColors.Window;
            this.labelConfirmarClave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConfirmarClave.Name = "labelConfirmarClave";
            // 
            // labelLineClave
            // 
            this.labelLineClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            resources.ApplyResources(this.labelLineClave, "labelLineClave");
            this.labelLineClave.Name = "labelLineClave";
            // 
            // labelLineConfirmarClave
            // 
            this.labelLineConfirmarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineConfirmarClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            resources.ApplyResources(this.labelLineConfirmarClave, "labelLineConfirmarClave");
            this.labelLineConfirmarClave.Name = "labelLineConfirmarClave";
            // 
            // panelInfoUsuario
            // 
            this.panelInfoUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelInfoUsuario.Controls.Add(this.labelInfo);
            resources.ApplyResources(this.panelInfoUsuario, "panelInfoUsuario");
            this.panelInfoUsuario.Name = "panelInfoUsuario";
            // 
            // labelInfo
            // 
            resources.ApplyResources(this.labelInfo, "labelInfo");
            this.labelInfo.Name = "labelInfo";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxEstado, "comboBoxEstado");
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Name = "comboBoxEstado";
            // 
            // labelEstado
            // 
            resources.ApplyResources(this.labelEstado, "labelEstado");
            this.labelEstado.BackColor = System.Drawing.SystemColors.Window;
            this.labelEstado.Name = "labelEstado";
            // 
            // labelLineDocumento
            // 
            this.labelLineDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            resources.ApplyResources(this.labelLineDocumento, "labelLineDocumento");
            this.labelLineDocumento.Name = "labelLineDocumento";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxDocumento, "textBoxDocumento");
            this.textBoxDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.TextChanged += new System.EventHandler(this.textBoxDocumento_TextChanged);
            this.textBoxDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDocumento_KeyDown);
            this.textBoxDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDocumento_KeyPress);
            this.textBoxDocumento.Leave += new System.EventHandler(this.textBoxDocumento_Leave);
            // 
            // labelDocumento
            // 
            resources.ApplyResources(this.labelDocumento, "labelDocumento");
            this.labelDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.labelDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDocumento.Name = "labelDocumento";
            // 
            // labelLineNombreCompleto
            // 
            this.labelLineNombreCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            resources.ApplyResources(this.labelLineNombreCompleto, "labelLineNombreCompleto");
            this.labelLineNombreCompleto.Name = "labelLineNombreCompleto";
            // 
            // textBoxNombreCompleto
            // 
            this.textBoxNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxNombreCompleto, "textBoxNombreCompleto");
            this.textBoxNombreCompleto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            this.textBoxNombreCompleto.TextChanged += new System.EventHandler(this.textBoxNombreCompleto_TextChanged);
            this.textBoxNombreCompleto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombreCompleto_KeyDown);
            this.textBoxNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreCompleto_KeyPress);
            // 
            // labelNombreCompleto
            // 
            resources.ApplyResources(this.labelNombreCompleto, "labelNombreCompleto");
            this.labelNombreCompleto.BackColor = System.Drawing.SystemColors.Window;
            this.labelNombreCompleto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            // 
            // labelLineCorreo
            // 
            this.labelLineCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            resources.ApplyResources(this.labelLineCorreo, "labelLineCorreo");
            this.labelLineCorreo.Name = "labelLineCorreo";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxCorreo, "textBoxCorreo");
            this.textBoxCorreo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            this.textBoxCorreo.Leave += new System.EventHandler(this.textBoxCorreo_Leave);
            // 
            // labelCorreo
            // 
            resources.ApplyResources(this.labelCorreo, "labelCorreo");
            this.labelCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.labelCorreo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCorreo.Name = "labelCorreo";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            resources.ApplyResources(this.panelContenedor, "panelContenedor");
            this.panelContenedor.Name = "panelContenedor";
            // 
            // mdDetalleUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panelInfoUsuario);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelClave);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.paneTitulo);
            this.MaximizeBox = false;
            this.Name = "mdDetalleUsuario";
            this.Load += new System.EventHandler(this.mdDetalleUsuario_Load);
            this.paneTitulo.ResumeLayout(false);
            this.paneTitulo.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelClave.ResumeLayout(false);
            this.panelClave.PerformLayout();
            this.panelInfoUsuario.ResumeLayout(false);
            this.panelInfoUsuario.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneTitulo;
        private System.Windows.Forms.Label labelSubTitulo;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Panel panelClave;
        private System.Windows.Forms.Button buttonVerClave;
        private System.Windows.Forms.TextBox textBoxConfirmarClave;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.Label labelConfirmarClave;
        private System.Windows.Forms.Label labelLineClave;
        private System.Windows.Forms.Label labelLineConfirmarClave;
        private System.Windows.Forms.Panel panelInfoUsuario;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelLineDocumento;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.Label labelLineNombreCompleto;
        private System.Windows.Forms.TextBox textBoxNombreCompleto;
        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.Label labelLineCorreo;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Panel panelContenedor;
    }
}