namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelUsuarioTitulo = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.menuPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPermisosSimples = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPermisosUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrarSesion.Image")));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(1432, 15);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(40, 40);
            this.buttonCerrarSesion.TabIndex = 91;
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUsuario.Location = new System.Drawing.Point(249, 23);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(77, 19);
            this.labelUsuario.TabIndex = 90;
            this.labelUsuario.Text = "labelUsuario";
            // 
            // labelUsuarioTitulo
            // 
            this.labelUsuarioTitulo.AutoSize = true;
            this.labelUsuarioTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelUsuarioTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUsuarioTitulo.Location = new System.Drawing.Point(201, 23);
            this.labelUsuarioTitulo.Name = "labelUsuarioTitulo";
            this.labelUsuarioTitulo.Size = new System.Drawing.Size(53, 19);
            this.labelUsuarioTitulo.TabIndex = 89;
            this.labelUsuarioTitulo.Text = "Usuario:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTitulo.Location = new System.Drawing.Point(15, 15);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(180, 30);
            this.labelTitulo.TabIndex = 88;
            this.labelTitulo.Text = "Servicio De Color";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 94);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1484, 667);
            this.contenedor.TabIndex = 87;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSeguridad});
            this.menu.Location = new System.Drawing.Point(0, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1484, 34);
            this.menu.TabIndex = 86;
            this.menu.Text = "menuStrip1";
            // 
            // menuSeguridad
            // 
            this.menuSeguridad.AutoSize = false;
            this.menuSeguridad.BackColor = System.Drawing.SystemColors.Window;
            this.menuSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuPermisos});
            this.menuSeguridad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSeguridad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuSeguridad.Name = "menuSeguridad";
            this.menuSeguridad.Size = new System.Drawing.Size(122, 30);
            this.menuSeguridad.Text = "Seguridad";
            this.menuSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(180, 28);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1484, 60);
            this.menuTitulo.TabIndex = 85;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // menuPermisos
            // 
            this.menuPermisos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPermisosSimples,
            this.menuGrupos,
            this.menuPermisosUsuarios});
            this.menuPermisos.Name = "menuPermisos";
            this.menuPermisos.Size = new System.Drawing.Size(180, 28);
            this.menuPermisos.Text = "Permisos";
            // 
            // menuPermisosSimples
            // 
            this.menuPermisosSimples.Name = "menuPermisosSimples";
            this.menuPermisosSimples.Size = new System.Drawing.Size(215, 28);
            this.menuPermisosSimples.Text = "Permisos simples";
            this.menuPermisosSimples.Click += new System.EventHandler(this.menuPermisosSimples_Click);
            // 
            // menuGrupos
            // 
            this.menuGrupos.Name = "menuGrupos";
            this.menuGrupos.Size = new System.Drawing.Size(215, 28);
            this.menuGrupos.Text = "Grupos";
            this.menuGrupos.Click += new System.EventHandler(this.menuGrupos_Click);
            // 
            // menuPermisosUsuarios
            // 
            this.menuPermisosUsuarios.Name = "menuPermisosUsuarios";
            this.menuPermisosUsuarios.Size = new System.Drawing.Size(215, 28);
            this.menuPermisosUsuarios.Text = "Permisos de usuarios";
            this.menuPermisosUsuarios.Click += new System.EventHandler(this.menuPermisosUsuarios_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelUsuarioTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelUsuarioTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuSeguridad;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.ToolStripMenuItem menuPermisos;
        private System.Windows.Forms.ToolStripMenuItem menuPermisosSimples;
        private System.Windows.Forms.ToolStripMenuItem menuGrupos;
        private System.Windows.Forms.ToolStripMenuItem menuPermisosUsuarios;
    }
}

