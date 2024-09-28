namespace LeSoleil_Taller2
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.LNombreNegocio = new System.Windows.Forms.Label();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.LFondoLogin = new System.Windows.Forms.Label();
            this.LFondoLogin2 = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.BIngresar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNombreNegocio
            // 
            this.LNombreNegocio.AutoSize = true;
            this.LNombreNegocio.BackColor = System.Drawing.Color.Wheat;
            this.LNombreNegocio.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreNegocio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreNegocio.Location = new System.Drawing.Point(318, 49);
            this.LNombreNegocio.Name = "LNombreNegocio";
            this.LNombreNegocio.Size = new System.Drawing.Size(201, 61);
            this.LNombreNegocio.TabIndex = 1;
            this.LNombreNegocio.Text = "le soleil";
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.BackColor = System.Drawing.Color.Wheat;
            this.LBienvenido.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBienvenido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBienvenido.Location = new System.Drawing.Point(356, 114);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(122, 24);
            this.LBienvenido.TabIndex = 2;
            this.LBienvenido.Text = "¡bienvenido!";
            // 
            // LFondoLogin
            // 
            this.LFondoLogin.BackColor = System.Drawing.Color.Wheat;
            this.LFondoLogin.Location = new System.Drawing.Point(256, 0);
            this.LFondoLogin.Name = "LFondoLogin";
            this.LFondoLogin.Size = new System.Drawing.Size(314, 325);
            this.LFondoLogin.TabIndex = 4;
            this.LFondoLogin.Click += new System.EventHandler(this.LFondoLogin_Click);
            // 
            // LFondoLogin2
            // 
            this.LFondoLogin2.Image = ((System.Drawing.Image)(resources.GetObject("LFondoLogin2.Image")));
            this.LFondoLogin2.Location = new System.Drawing.Point(0, 0);
            this.LFondoLogin2.Name = "LFondoLogin2";
            this.LFondoLogin2.Size = new System.Drawing.Size(260, 325);
            this.LFondoLogin2.TabIndex = 5;
            // 
            // TBUsuario
            // 
            this.TBUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.ForeColor = System.Drawing.Color.Coral;
            this.TBUsuario.Location = new System.Drawing.Point(348, 169);
            this.TBUsuario.Multiline = true;
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(140, 25);
            this.TBUsuario.TabIndex = 6;
            this.TBUsuario.Text = "Usuario";
            // 
            // TBContraseña
            // 
            this.TBContraseña.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContraseña.ForeColor = System.Drawing.Color.Coral;
            this.TBContraseña.Location = new System.Drawing.Point(348, 211);
            this.TBContraseña.Multiline = true;
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(140, 24);
            this.TBContraseña.TabIndex = 7;
            this.TBContraseña.Text = "Contraseña";
            // 
            // BIngresar
            // 
            this.BIngresar.BackColor = System.Drawing.Color.Coral;
            this.BIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIngresar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BIngresar.Location = new System.Drawing.Point(329, 260);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(75, 32);
            this.BIngresar.TabIndex = 8;
            this.BIngresar.Text = "Ingresar";
            this.BIngresar.UseVisualStyleBackColor = false;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Coral;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelar.Location = new System.Drawing.Point(424, 260);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 32);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 323);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BIngresar);
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LFondoLogin2);
            this.Controls.Add(this.LBienvenido);
            this.Controls.Add(this.LNombreNegocio);
            this.Controls.Add(this.LFondoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LNombreNegocio;
        private System.Windows.Forms.Label LBienvenido;
        private System.Windows.Forms.Label LFondoLogin;
        private System.Windows.Forms.Label LFondoLogin2;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.Button BIngresar;
        private System.Windows.Forms.Button BCancelar;
    }
}

