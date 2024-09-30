namespace LeSoleil_Taller2
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LUsers = new System.Windows.Forms.Label();
            this.LNombreUser = new System.Windows.Forms.Label();
            this.LApellidoUser = new System.Windows.Forms.Label();
            this.TBNombreUser = new System.Windows.Forms.TextBox();
            this.TBApellidoUser = new System.Windows.Forms.TextBox();
            this.LUsuarioUser = new System.Windows.Forms.Label();
            this.TBUsuarioUser = new System.Windows.Forms.TextBox();
            this.TBContraseñaUser = new System.Windows.Forms.TextBox();
            this.LContraseñaUser = new System.Windows.Forms.Label();
            this.LPerfilUser = new System.Windows.Forms.Label();
            this.CBPerfilUser = new System.Windows.Forms.ComboBox();
            this.LDNIUser = new System.Windows.Forms.Label();
            this.LDireccionUser = new System.Windows.Forms.Label();
            this.TBDniUser = new System.Windows.Forms.TextBox();
            this.TBDirecionUser = new System.Windows.Forms.TextBox();
            this.LTelefonoUser = new System.Windows.Forms.Label();
            this.TBTelefonoUser = new System.Windows.Forms.TextBox();
            this.BGuardarUser = new FontAwesome.Sharp.IconButton();
            this.BCancelarUser = new FontAwesome.Sharp.IconButton();
            this.LFondoUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BActivos = new FontAwesome.Sharp.IconButton();
            this.BInactivos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LUsers
            // 
            this.LUsers.AutoSize = true;
            this.LUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LUsers.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsers.ForeColor = System.Drawing.Color.Coral;
            this.LUsers.Location = new System.Drawing.Point(330, 12);
            this.LUsers.Name = "LUsers";
            this.LUsers.Size = new System.Drawing.Size(123, 29);
            this.LUsers.TabIndex = 3;
            this.LUsers.Text = "USUARIOS";
            this.LUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LNombreUser
            // 
            this.LNombreUser.AutoSize = true;
            this.LNombreUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUser.ForeColor = System.Drawing.Color.Black;
            this.LNombreUser.Location = new System.Drawing.Point(142, 58);
            this.LNombreUser.Name = "LNombreUser";
            this.LNombreUser.Size = new System.Drawing.Size(56, 18);
            this.LNombreUser.TabIndex = 4;
            this.LNombreUser.Text = "Nombre";
            // 
            // LApellidoUser
            // 
            this.LApellidoUser.AutoSize = true;
            this.LApellidoUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LApellidoUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidoUser.ForeColor = System.Drawing.Color.Black;
            this.LApellidoUser.Location = new System.Drawing.Point(142, 99);
            this.LApellidoUser.Name = "LApellidoUser";
            this.LApellidoUser.Size = new System.Drawing.Size(58, 18);
            this.LApellidoUser.TabIndex = 5;
            this.LApellidoUser.Text = "Apellido";
            // 
            // TBNombreUser
            // 
            this.TBNombreUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreUser.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreUser.Location = new System.Drawing.Point(222, 56);
            this.TBNombreUser.Multiline = true;
            this.TBNombreUser.Name = "TBNombreUser";
            this.TBNombreUser.Size = new System.Drawing.Size(134, 25);
            this.TBNombreUser.TabIndex = 7;
            // 
            // TBApellidoUser
            // 
            this.TBApellidoUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellidoUser.ForeColor = System.Drawing.Color.Coral;
            this.TBApellidoUser.Location = new System.Drawing.Point(222, 97);
            this.TBApellidoUser.Multiline = true;
            this.TBApellidoUser.Name = "TBApellidoUser";
            this.TBApellidoUser.Size = new System.Drawing.Size(134, 25);
            this.TBApellidoUser.TabIndex = 8;
            // 
            // LUsuarioUser
            // 
            this.LUsuarioUser.AutoSize = true;
            this.LUsuarioUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LUsuarioUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuarioUser.ForeColor = System.Drawing.Color.Black;
            this.LUsuarioUser.Location = new System.Drawing.Point(142, 141);
            this.LUsuarioUser.Name = "LUsuarioUser";
            this.LUsuarioUser.Size = new System.Drawing.Size(55, 18);
            this.LUsuarioUser.TabIndex = 9;
            this.LUsuarioUser.Text = "Usuario";
            // 
            // TBUsuarioUser
            // 
            this.TBUsuarioUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuarioUser.ForeColor = System.Drawing.Color.Coral;
            this.TBUsuarioUser.Location = new System.Drawing.Point(222, 141);
            this.TBUsuarioUser.Multiline = true;
            this.TBUsuarioUser.Name = "TBUsuarioUser";
            this.TBUsuarioUser.Size = new System.Drawing.Size(134, 25);
            this.TBUsuarioUser.TabIndex = 10;
            // 
            // TBContraseñaUser
            // 
            this.TBContraseñaUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContraseñaUser.ForeColor = System.Drawing.Color.Coral;
            this.TBContraseñaUser.Location = new System.Drawing.Point(222, 184);
            this.TBContraseñaUser.Multiline = true;
            this.TBContraseñaUser.Name = "TBContraseñaUser";
            this.TBContraseñaUser.Size = new System.Drawing.Size(134, 25);
            this.TBContraseñaUser.TabIndex = 11;
            // 
            // LContraseñaUser
            // 
            this.LContraseñaUser.AutoSize = true;
            this.LContraseñaUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LContraseñaUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseñaUser.ForeColor = System.Drawing.Color.Black;
            this.LContraseñaUser.Location = new System.Drawing.Point(142, 186);
            this.LContraseñaUser.Name = "LContraseñaUser";
            this.LContraseñaUser.Size = new System.Drawing.Size(77, 18);
            this.LContraseñaUser.TabIndex = 12;
            this.LContraseñaUser.Text = "Contraseña";
            // 
            // LPerfilUser
            // 
            this.LPerfilUser.AutoSize = true;
            this.LPerfilUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPerfilUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPerfilUser.ForeColor = System.Drawing.Color.Black;
            this.LPerfilUser.Location = new System.Drawing.Point(414, 141);
            this.LPerfilUser.Name = "LPerfilUser";
            this.LPerfilUser.Size = new System.Drawing.Size(41, 18);
            this.LPerfilUser.TabIndex = 13;
            this.LPerfilUser.Text = "Perfil";
            // 
            // CBPerfilUser
            // 
            this.CBPerfilUser.FormattingEnabled = true;
            this.CBPerfilUser.Location = new System.Drawing.Point(481, 143);
            this.CBPerfilUser.Name = "CBPerfilUser";
            this.CBPerfilUser.Size = new System.Drawing.Size(134, 21);
            this.CBPerfilUser.TabIndex = 14;
            // 
            // LDNIUser
            // 
            this.LDNIUser.AutoSize = true;
            this.LDNIUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDNIUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDNIUser.ForeColor = System.Drawing.Color.Black;
            this.LDNIUser.Location = new System.Drawing.Point(414, 58);
            this.LDNIUser.Name = "LDNIUser";
            this.LDNIUser.Size = new System.Drawing.Size(29, 18);
            this.LDNIUser.TabIndex = 15;
            this.LDNIUser.Text = "DNI";
            // 
            // LDireccionUser
            // 
            this.LDireccionUser.AutoSize = true;
            this.LDireccionUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDireccionUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccionUser.ForeColor = System.Drawing.Color.Black;
            this.LDireccionUser.Location = new System.Drawing.Point(414, 99);
            this.LDireccionUser.Name = "LDireccionUser";
            this.LDireccionUser.Size = new System.Drawing.Size(66, 18);
            this.LDireccionUser.TabIndex = 16;
            this.LDireccionUser.Text = "Direccion";
            // 
            // TBDniUser
            // 
            this.TBDniUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDniUser.ForeColor = System.Drawing.Color.Coral;
            this.TBDniUser.Location = new System.Drawing.Point(481, 56);
            this.TBDniUser.Multiline = true;
            this.TBDniUser.Name = "TBDniUser";
            this.TBDniUser.Size = new System.Drawing.Size(134, 25);
            this.TBDniUser.TabIndex = 17;
            // 
            // TBDirecionUser
            // 
            this.TBDirecionUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDirecionUser.ForeColor = System.Drawing.Color.Coral;
            this.TBDirecionUser.Location = new System.Drawing.Point(481, 97);
            this.TBDirecionUser.Multiline = true;
            this.TBDirecionUser.Name = "TBDirecionUser";
            this.TBDirecionUser.Size = new System.Drawing.Size(134, 25);
            this.TBDirecionUser.TabIndex = 18;
            // 
            // LTelefonoUser
            // 
            this.LTelefonoUser.AutoSize = true;
            this.LTelefonoUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefonoUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoUser.ForeColor = System.Drawing.Color.Black;
            this.LTelefonoUser.Location = new System.Drawing.Point(414, 186);
            this.LTelefonoUser.Name = "LTelefonoUser";
            this.LTelefonoUser.Size = new System.Drawing.Size(60, 18);
            this.LTelefonoUser.TabIndex = 21;
            this.LTelefonoUser.Text = "Telefono";
            // 
            // TBTelefonoUser
            // 
            this.TBTelefonoUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefonoUser.ForeColor = System.Drawing.Color.Coral;
            this.TBTelefonoUser.Location = new System.Drawing.Point(481, 184);
            this.TBTelefonoUser.Multiline = true;
            this.TBTelefonoUser.Name = "TBTelefonoUser";
            this.TBTelefonoUser.Size = new System.Drawing.Size(134, 25);
            this.TBTelefonoUser.TabIndex = 25;
            // 
            // BGuardarUser
            // 
            this.BGuardarUser.BackColor = System.Drawing.Color.Coral;
            this.BGuardarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarUser.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardarUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BGuardarUser.IconColor = System.Drawing.Color.Black;
            this.BGuardarUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardarUser.Location = new System.Drawing.Point(280, 263);
            this.BGuardarUser.Name = "BGuardarUser";
            this.BGuardarUser.Size = new System.Drawing.Size(94, 41);
            this.BGuardarUser.TabIndex = 26;
            this.BGuardarUser.Text = "Guardar";
            this.BGuardarUser.UseVisualStyleBackColor = false;
            // 
            // BCancelarUser
            // 
            this.BCancelarUser.BackColor = System.Drawing.Color.Coral;
            this.BCancelarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelarUser.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelarUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelarUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BCancelarUser.IconColor = System.Drawing.Color.Black;
            this.BCancelarUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCancelarUser.Location = new System.Drawing.Point(396, 263);
            this.BCancelarUser.Name = "BCancelarUser";
            this.BCancelarUser.Size = new System.Drawing.Size(94, 41);
            this.BCancelarUser.TabIndex = 27;
            this.BCancelarUser.Text = "Cancelar";
            this.BCancelarUser.UseVisualStyleBackColor = false;
            // 
            // LFondoUser
            // 
            this.LFondoUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoUser.Location = new System.Drawing.Point(-6, -3);
            this.LFondoUser.Name = "LFondoUser";
            this.LFondoUser.Size = new System.Drawing.Size(813, 324);
            this.LFondoUser.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 280);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // DGVUsuarios
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.IdPerfil,
            this.nombre,
            this.apellido,
            this.usuario,
            this.dni,
            this.email,
            this.direccion,
            this.fechaNacimiento,
            this.telefono,
            this.sexo});
            this.DGVUsuarios.Location = new System.Drawing.Point(12, 369);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.ReadOnly = true;
            this.DGVUsuarios.Size = new System.Drawing.Size(781, 217);
            this.DGVUsuarios.TabIndex = 30;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "ID Usuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // IdPerfil
            // 
            this.IdPerfil.HeaderText = "ID Perfil";
            this.IdPerfil.Name = "IdPerfil";
            this.IdPerfil.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.HeaderText = "dni";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // BActivos
            // 
            this.BActivos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BActivos.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActivos.ForeColor = System.Drawing.Color.Coral;
            this.BActivos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BActivos.IconColor = System.Drawing.Color.Black;
            this.BActivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BActivos.Location = new System.Drawing.Point(12, 334);
            this.BActivos.Name = "BActivos";
            this.BActivos.Size = new System.Drawing.Size(94, 29);
            this.BActivos.TabIndex = 31;
            this.BActivos.Text = "Activos";
            this.BActivos.UseVisualStyleBackColor = false;
            // 
            // BInactivos
            // 
            this.BInactivos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInactivos.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInactivos.ForeColor = System.Drawing.Color.Coral;
            this.BInactivos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BInactivos.IconColor = System.Drawing.Color.Black;
            this.BInactivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BInactivos.Location = new System.Drawing.Point(122, 334);
            this.BInactivos.Name = "BInactivos";
            this.BInactivos.Size = new System.Drawing.Size(94, 29);
            this.BInactivos.TabIndex = 32;
            this.BInactivos.Text = "Inactivos";
            this.BInactivos.UseVisualStyleBackColor = false;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 598);
            this.Controls.Add(this.BInactivos);
            this.Controls.Add(this.BActivos);
            this.Controls.Add(this.DGVUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BCancelarUser);
            this.Controls.Add(this.BGuardarUser);
            this.Controls.Add(this.TBTelefonoUser);
            this.Controls.Add(this.LTelefonoUser);
            this.Controls.Add(this.TBDirecionUser);
            this.Controls.Add(this.TBDniUser);
            this.Controls.Add(this.LDireccionUser);
            this.Controls.Add(this.LDNIUser);
            this.Controls.Add(this.CBPerfilUser);
            this.Controls.Add(this.LPerfilUser);
            this.Controls.Add(this.LContraseñaUser);
            this.Controls.Add(this.TBContraseñaUser);
            this.Controls.Add(this.TBUsuarioUser);
            this.Controls.Add(this.LUsuarioUser);
            this.Controls.Add(this.TBApellidoUser);
            this.Controls.Add(this.TBNombreUser);
            this.Controls.Add(this.LApellidoUser);
            this.Controls.Add(this.LNombreUser);
            this.Controls.Add(this.LUsers);
            this.Controls.Add(this.LFondoUser);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LUsers;
        private System.Windows.Forms.Label LNombreUser;
        private System.Windows.Forms.Label LApellidoUser;
        private System.Windows.Forms.TextBox TBNombreUser;
        private System.Windows.Forms.TextBox TBApellidoUser;
        private System.Windows.Forms.Label LUsuarioUser;
        private System.Windows.Forms.TextBox TBUsuarioUser;
        private System.Windows.Forms.TextBox TBContraseñaUser;
        private System.Windows.Forms.Label LContraseñaUser;
        private System.Windows.Forms.Label LPerfilUser;
        private System.Windows.Forms.ComboBox CBPerfilUser;
        private System.Windows.Forms.Label LDNIUser;
        private System.Windows.Forms.Label LDireccionUser;
        private System.Windows.Forms.TextBox TBDniUser;
        private System.Windows.Forms.TextBox TBDirecionUser;
        private System.Windows.Forms.Label LTelefonoUser;
        private System.Windows.Forms.TextBox TBTelefonoUser;
        private FontAwesome.Sharp.IconButton BGuardarUser;
        private FontAwesome.Sharp.IconButton BCancelarUser;
        private System.Windows.Forms.Label LFondoUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private FontAwesome.Sharp.IconButton BActivos;
        private FontAwesome.Sharp.IconButton BInactivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
    }
}