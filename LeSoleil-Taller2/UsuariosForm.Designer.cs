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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TBDireccionUser = new System.Windows.Forms.TextBox();
            this.LTelefonoUser = new System.Windows.Forms.Label();
            this.TBTelefonoUser = new System.Windows.Forms.TextBox();
            this.LFondoUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.TBEmailUser = new System.Windows.Forms.TextBox();
            this.LEmailUser = new System.Windows.Forms.Label();
            this.BGuardarUsuario = new System.Windows.Forms.Button();
            this.BCancelarUsuario = new System.Windows.Forms.Button();
            this.BActivosUser = new System.Windows.Forms.Button();
            this.BInactivosUsers = new System.Windows.Forms.Button();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.LNombreUser.Location = new System.Drawing.Point(28, 75);
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
            this.LApellidoUser.Location = new System.Drawing.Point(28, 116);
            this.LApellidoUser.Name = "LApellidoUser";
            this.LApellidoUser.Size = new System.Drawing.Size(58, 18);
            this.LApellidoUser.TabIndex = 5;
            this.LApellidoUser.Text = "Apellido";
            // 
            // TBNombreUser
            // 
            this.TBNombreUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreUser.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreUser.Location = new System.Drawing.Point(108, 73);
            this.TBNombreUser.Multiline = true;
            this.TBNombreUser.Name = "TBNombreUser";
            this.TBNombreUser.Size = new System.Drawing.Size(134, 25);
            this.TBNombreUser.TabIndex = 7;
            this.TBNombreUser.Leave += new System.EventHandler(this.TBNombreUser_Leave);
            // 
            // TBApellidoUser
            // 
            this.TBApellidoUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellidoUser.ForeColor = System.Drawing.Color.Coral;
            this.TBApellidoUser.Location = new System.Drawing.Point(108, 114);
            this.TBApellidoUser.Multiline = true;
            this.TBApellidoUser.Name = "TBApellidoUser";
            this.TBApellidoUser.Size = new System.Drawing.Size(134, 25);
            this.TBApellidoUser.TabIndex = 8;
            this.TBApellidoUser.Leave += new System.EventHandler(this.TBApellidoUser_Leave);
            // 
            // LUsuarioUser
            // 
            this.LUsuarioUser.AutoSize = true;
            this.LUsuarioUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LUsuarioUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuarioUser.ForeColor = System.Drawing.Color.Black;
            this.LUsuarioUser.Location = new System.Drawing.Point(299, 75);
            this.LUsuarioUser.Name = "LUsuarioUser";
            this.LUsuarioUser.Size = new System.Drawing.Size(55, 18);
            this.LUsuarioUser.TabIndex = 9;
            this.LUsuarioUser.Text = "Usuario";
            // 
            // TBUsuarioUser
            // 
            this.TBUsuarioUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuarioUser.ForeColor = System.Drawing.Color.Coral;
            this.TBUsuarioUser.Location = new System.Drawing.Point(375, 73);
            this.TBUsuarioUser.Multiline = true;
            this.TBUsuarioUser.Name = "TBUsuarioUser";
            this.TBUsuarioUser.Size = new System.Drawing.Size(134, 25);
            this.TBUsuarioUser.TabIndex = 10;
            this.TBUsuarioUser.Leave += new System.EventHandler(this.TBUsuarioUser_Leave);
            // 
            // TBContraseñaUser
            // 
            this.TBContraseñaUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContraseñaUser.ForeColor = System.Drawing.Color.Coral;
            this.TBContraseñaUser.Location = new System.Drawing.Point(375, 114);
            this.TBContraseñaUser.Multiline = true;
            this.TBContraseñaUser.Name = "TBContraseñaUser";
            this.TBContraseñaUser.PasswordChar = '*';
            this.TBContraseñaUser.Size = new System.Drawing.Size(134, 25);
            this.TBContraseñaUser.TabIndex = 11;
            this.TBContraseñaUser.Leave += new System.EventHandler(this.TBContraseñaUser_Leave);
            // 
            // LContraseñaUser
            // 
            this.LContraseñaUser.AutoSize = true;
            this.LContraseñaUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LContraseñaUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseñaUser.ForeColor = System.Drawing.Color.Black;
            this.LContraseñaUser.Location = new System.Drawing.Point(277, 116);
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
            this.LPerfilUser.Location = new System.Drawing.Point(556, 118);
            this.LPerfilUser.Name = "LPerfilUser";
            this.LPerfilUser.Size = new System.Drawing.Size(41, 18);
            this.LPerfilUser.TabIndex = 13;
            this.LPerfilUser.Text = "Perfil";
            // 
            // CBPerfilUser
            // 
            this.CBPerfilUser.FormattingEnabled = true;
            this.CBPerfilUser.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Repositor de Stock"});
            this.CBPerfilUser.Location = new System.Drawing.Point(623, 120);
            this.CBPerfilUser.Name = "CBPerfilUser";
            this.CBPerfilUser.Size = new System.Drawing.Size(134, 21);
            this.CBPerfilUser.TabIndex = 14;
            this.CBPerfilUser.Leave += new System.EventHandler(this.CBPerfilUser_Leave);
            // 
            // LDNIUser
            // 
            this.LDNIUser.AutoSize = true;
            this.LDNIUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDNIUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDNIUser.ForeColor = System.Drawing.Color.Black;
            this.LDNIUser.Location = new System.Drawing.Point(41, 163);
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
            this.LDireccionUser.Location = new System.Drawing.Point(556, 76);
            this.LDireccionUser.Name = "LDireccionUser";
            this.LDireccionUser.Size = new System.Drawing.Size(66, 18);
            this.LDireccionUser.TabIndex = 16;
            this.LDireccionUser.Text = "Direccion";
            // 
            // TBDniUser
            // 
            this.TBDniUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDniUser.ForeColor = System.Drawing.Color.Coral;
            this.TBDniUser.Location = new System.Drawing.Point(108, 161);
            this.TBDniUser.Multiline = true;
            this.TBDniUser.Name = "TBDniUser";
            this.TBDniUser.Size = new System.Drawing.Size(134, 25);
            this.TBDniUser.TabIndex = 17;
            this.TBDniUser.Leave += new System.EventHandler(this.TBDniUser_Leave);
            // 
            // TBDireccionUser
            // 
            this.TBDireccionUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDireccionUser.ForeColor = System.Drawing.Color.Coral;
            this.TBDireccionUser.Location = new System.Drawing.Point(623, 74);
            this.TBDireccionUser.Multiline = true;
            this.TBDireccionUser.Name = "TBDireccionUser";
            this.TBDireccionUser.Size = new System.Drawing.Size(134, 25);
            this.TBDireccionUser.TabIndex = 18;
            this.TBDireccionUser.Leave += new System.EventHandler(this.TBDireccionUser_Leave);
            // 
            // LTelefonoUser
            // 
            this.LTelefonoUser.AutoSize = true;
            this.LTelefonoUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefonoUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoUser.ForeColor = System.Drawing.Color.Black;
            this.LTelefonoUser.Location = new System.Drawing.Point(556, 163);
            this.LTelefonoUser.Name = "LTelefonoUser";
            this.LTelefonoUser.Size = new System.Drawing.Size(60, 18);
            this.LTelefonoUser.TabIndex = 21;
            this.LTelefonoUser.Text = "Telefono";
            // 
            // TBTelefonoUser
            // 
            this.TBTelefonoUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefonoUser.ForeColor = System.Drawing.Color.Coral;
            this.TBTelefonoUser.Location = new System.Drawing.Point(623, 161);
            this.TBTelefonoUser.Multiline = true;
            this.TBTelefonoUser.Name = "TBTelefonoUser";
            this.TBTelefonoUser.Size = new System.Drawing.Size(134, 25);
            this.TBTelefonoUser.TabIndex = 25;
            this.TBTelefonoUser.Leave += new System.EventHandler(this.TBTelefonoUser_Leave);
            // 
            // LFondoUser
            // 
            this.LFondoUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoUser.Location = new System.Drawing.Point(-6, -3);
            this.LFondoUser.Name = "LFondoUser";
            this.LFondoUser.Size = new System.Drawing.Size(813, 297);
            this.LFondoUser.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 324);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // DGVUsuarios
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuario,
            this.apellidoUsuario,
            this.dniUsuario,
            this.usuario,
            this.emailUsuario,
            this.direccionUsuario,
            this.Perfil,
            this.telefonoUsuario,
            this.eliminarUsuario,
            this.editarUsuario});
            this.DGVUsuarios.Location = new System.Drawing.Point(12, 345);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.ReadOnly = true;
            this.DGVUsuarios.Size = new System.Drawing.Size(781, 245);
            this.DGVUsuarios.TabIndex = 30;
            this.DGVUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsuarios_CellClick);
            // 
            // TBEmailUser
            // 
            this.TBEmailUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmailUser.ForeColor = System.Drawing.Color.Coral;
            this.TBEmailUser.Location = new System.Drawing.Point(375, 161);
            this.TBEmailUser.Multiline = true;
            this.TBEmailUser.Name = "TBEmailUser";
            this.TBEmailUser.Size = new System.Drawing.Size(134, 25);
            this.TBEmailUser.TabIndex = 33;
            this.TBEmailUser.Leave += new System.EventHandler(this.TBEmailUser_Leave);
            // 
            // LEmailUser
            // 
            this.LEmailUser.AutoSize = true;
            this.LEmailUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmailUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmailUser.ForeColor = System.Drawing.Color.Black;
            this.LEmailUser.Location = new System.Drawing.Point(313, 163);
            this.LEmailUser.Name = "LEmailUser";
            this.LEmailUser.Size = new System.Drawing.Size(41, 18);
            this.LEmailUser.TabIndex = 34;
            this.LEmailUser.Text = "Email";
            // 
            // BGuardarUsuario
            // 
            this.BGuardarUsuario.BackColor = System.Drawing.Color.Coral;
            this.BGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardarUsuario.Location = new System.Drawing.Point(31, 216);
            this.BGuardarUsuario.Name = "BGuardarUsuario";
            this.BGuardarUsuario.Size = new System.Drawing.Size(94, 40);
            this.BGuardarUsuario.TabIndex = 35;
            this.BGuardarUsuario.Text = "Guardar";
            this.BGuardarUsuario.UseVisualStyleBackColor = false;
            this.BGuardarUsuario.Click += new System.EventHandler(this.BGuardarUsuario_Click);
            // 
            // BCancelarUsuario
            // 
            this.BCancelarUsuario.BackColor = System.Drawing.Color.Coral;
            this.BCancelarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelarUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelarUsuario.Location = new System.Drawing.Point(146, 216);
            this.BCancelarUsuario.Name = "BCancelarUsuario";
            this.BCancelarUsuario.Size = new System.Drawing.Size(94, 40);
            this.BCancelarUsuario.TabIndex = 36;
            this.BCancelarUsuario.Text = "Cancelar";
            this.BCancelarUsuario.UseVisualStyleBackColor = false;
            this.BCancelarUsuario.Click += new System.EventHandler(this.BCancelarUsuario_Click);
            // 
            // BActivosUser
            // 
            this.BActivosUser.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BActivosUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BActivosUser.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActivosUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BActivosUser.Location = new System.Drawing.Point(12, 297);
            this.BActivosUser.Name = "BActivosUser";
            this.BActivosUser.Size = new System.Drawing.Size(152, 35);
            this.BActivosUser.TabIndex = 37;
            this.BActivosUser.Text = "Usuarios Activos";
            this.BActivosUser.UseVisualStyleBackColor = false;
            // 
            // BInactivosUsers
            // 
            this.BInactivosUsers.BackColor = System.Drawing.Color.Brown;
            this.BInactivosUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInactivosUsers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInactivosUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BInactivosUsers.Location = new System.Drawing.Point(635, 297);
            this.BInactivosUsers.Name = "BInactivosUsers";
            this.BInactivosUsers.Size = new System.Drawing.Size(158, 35);
            this.BInactivosUsers.TabIndex = 38;
            this.BInactivosUsers.Text = "Usuarios Inactivos";
            this.BInactivosUsers.UseVisualStyleBackColor = false;
            // 
            // nombreUsuario
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.nombreUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombreUsuario.HeaderText = "Nombre";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // apellidoUsuario
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.apellidoUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.apellidoUsuario.HeaderText = "Apellido";
            this.apellidoUsuario.Name = "apellidoUsuario";
            this.apellidoUsuario.ReadOnly = true;
            // 
            // dniUsuario
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dniUsuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dniUsuario.HeaderText = "DNI";
            this.dniUsuario.Name = "dniUsuario";
            this.dniUsuario.ReadOnly = true;
            // 
            // usuario
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.usuario.DefaultCellStyle = dataGridViewCellStyle5;
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // emailUsuario
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.emailUsuario.DefaultCellStyle = dataGridViewCellStyle6;
            this.emailUsuario.HeaderText = "Email";
            this.emailUsuario.Name = "emailUsuario";
            this.emailUsuario.ReadOnly = true;
            // 
            // direccionUsuario
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.direccionUsuario.DefaultCellStyle = dataGridViewCellStyle7;
            this.direccionUsuario.HeaderText = "Direccion";
            this.direccionUsuario.Name = "direccionUsuario";
            this.direccionUsuario.ReadOnly = true;
            // 
            // Perfil
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Perfil.DefaultCellStyle = dataGridViewCellStyle8;
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // telefonoUsuario
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.telefonoUsuario.DefaultCellStyle = dataGridViewCellStyle9;
            this.telefonoUsuario.HeaderText = "Telefono";
            this.telefonoUsuario.Name = "telefonoUsuario";
            this.telefonoUsuario.ReadOnly = true;
            // 
            // eliminarUsuario
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.eliminarUsuario.DefaultCellStyle = dataGridViewCellStyle10;
            this.eliminarUsuario.HeaderText = "Dar de Baja";
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.ReadOnly = true;
            this.eliminarUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminarUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminarUsuario.Text = "Eliminar";
            // 
            // editarUsuario
            // 
            this.editarUsuario.HeaderText = "Editar ";
            this.editarUsuario.Name = "editarUsuario";
            this.editarUsuario.ReadOnly = true;
            this.editarUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editarUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editarUsuario.Text = "editar";
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 598);
            this.Controls.Add(this.BInactivosUsers);
            this.Controls.Add(this.BActivosUser);
            this.Controls.Add(this.BCancelarUsuario);
            this.Controls.Add(this.BGuardarUsuario);
            this.Controls.Add(this.LEmailUser);
            this.Controls.Add(this.TBEmailUser);
            this.Controls.Add(this.DGVUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBTelefonoUser);
            this.Controls.Add(this.LTelefonoUser);
            this.Controls.Add(this.TBDireccionUser);
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
        private System.Windows.Forms.TextBox TBDireccionUser;
        private System.Windows.Forms.Label LTelefonoUser;
        private System.Windows.Forms.TextBox TBTelefonoUser;
        //private FontAwesome.Sharp.IconButton BGuardarUser;
        //private FontAwesome.Sharp.IconButton BCancelarUser;
        private System.Windows.Forms.Label LFondoUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        //private FontAwesome.Sharp.IconButton BActivos;
        //private FontAwesome.Sharp.IconButton BInactivos;
        private System.Windows.Forms.TextBox TBEmailUser;
        private System.Windows.Forms.Label LEmailUser;
        private System.Windows.Forms.Button BGuardarUsuario;
        private System.Windows.Forms.Button BCancelarUsuario;
        private System.Windows.Forms.Button BActivosUser;
        private System.Windows.Forms.Button BInactivosUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn editarUsuario;
    }
}