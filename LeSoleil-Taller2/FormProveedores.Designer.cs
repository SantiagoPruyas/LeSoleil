namespace LeSoleil_Taller2
{
    partial class FormProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            this.BCancelarProveedor = new System.Windows.Forms.Button();
            this.BGuardarProveedor = new System.Windows.Forms.Button();
            this.DGVProveedores = new System.Windows.Forms.DataGridView();
            this.TBTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.TBDireccionProveedor = new System.Windows.Forms.TextBox();
            this.LTelefonoProveedor = new System.Windows.Forms.Label();
            this.LDireccionProveedor = new System.Windows.Forms.Label();
            this.TBCUITProveedor = new System.Windows.Forms.TextBox();
            this.TBEmailProveedor = new System.Windows.Forms.TextBox();
            this.TBNombreProveedor = new System.Windows.Forms.TextBox();
            this.LCUITProveedor = new System.Windows.Forms.Label();
            this.LEmailProveedor = new System.Windows.Forms.Label();
            this.LNombreProveedor = new System.Windows.Forms.Label();
            this.LProveedor = new System.Windows.Forms.Label();
            this.LFondoClientes = new System.Windows.Forms.Label();
            this.TBRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.LRazonSocialProveedor = new System.Windows.Forms.Label();
            this.BActivosProveedores = new System.Windows.Forms.Button();
            this.BInactivosProveedores = new System.Windows.Forms.Button();
            this.TBCiudadProveedor = new System.Windows.Forms.TextBox();
            this.LCiudadProveedor = new System.Windows.Forms.Label();
            this.LPaisProveedor = new System.Windows.Forms.Label();
            this.TBPaisProveedor = new System.Windows.Forms.TextBox();
            this.LDescripcionProveedor = new System.Windows.Forms.Label();
            this.TBDescripcionProveedor = new System.Windows.Forms.TextBox();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUITProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarProveedor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bajarProveedor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PBFondoClientes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFondoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BCancelarProveedor
            // 
            this.BCancelarProveedor.BackColor = System.Drawing.Color.Coral;
            this.BCancelarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelarProveedor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelarProveedor.Location = new System.Drawing.Point(389, 190);
            this.BCancelarProveedor.Name = "BCancelarProveedor";
            this.BCancelarProveedor.Size = new System.Drawing.Size(94, 38);
            this.BCancelarProveedor.TabIndex = 80;
            this.BCancelarProveedor.Text = "Cancelar";
            this.BCancelarProveedor.UseVisualStyleBackColor = false;
            // 
            // BGuardarProveedor
            // 
            this.BGuardarProveedor.BackColor = System.Drawing.Color.Coral;
            this.BGuardarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarProveedor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardarProveedor.Location = new System.Drawing.Point(258, 190);
            this.BGuardarProveedor.Name = "BGuardarProveedor";
            this.BGuardarProveedor.Size = new System.Drawing.Size(94, 38);
            this.BGuardarProveedor.TabIndex = 79;
            this.BGuardarProveedor.Text = "Guardar";
            this.BGuardarProveedor.UseVisualStyleBackColor = false;
            // 
            // DGVProveedores
            // 
            this.DGVProveedores.BackgroundColor = System.Drawing.Color.Tan;
            this.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.CUITProveedor,
            this.nombreProveedor,
            this.direccionProveedor,
            this.telefonoProveedor,
            this.emailProveedor,
            this.razonSocialProveedor,
            this.ciudadProveedor,
            this.paisProveedor,
            this.descripcionProveedor,
            this.editarProveedor,
            this.bajarProveedor});
            this.DGVProveedores.Location = new System.Drawing.Point(17, 352);
            this.DGVProveedores.Name = "DGVProveedores";
            this.DGVProveedores.Size = new System.Drawing.Size(1242, 281);
            this.DGVProveedores.TabIndex = 78;
            this.DGVProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVProveedores_CellPainting);
            // 
            // TBTelefonoProveedor
            // 
            this.TBTelefonoProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefonoProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBTelefonoProveedor.Location = new System.Drawing.Point(341, 120);
            this.TBTelefonoProveedor.Multiline = true;
            this.TBTelefonoProveedor.Name = "TBTelefonoProveedor";
            this.TBTelefonoProveedor.Size = new System.Drawing.Size(215, 25);
            this.TBTelefonoProveedor.TabIndex = 73;
            // 
            // TBDireccionProveedor
            // 
            this.TBDireccionProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDireccionProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBDireccionProveedor.Location = new System.Drawing.Point(341, 75);
            this.TBDireccionProveedor.Multiline = true;
            this.TBDireccionProveedor.Name = "TBDireccionProveedor";
            this.TBDireccionProveedor.Size = new System.Drawing.Size(215, 25);
            this.TBDireccionProveedor.TabIndex = 72;
            // 
            // LTelefonoProveedor
            // 
            this.LTelefonoProveedor.AutoSize = true;
            this.LTelefonoProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefonoProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoProveedor.ForeColor = System.Drawing.Color.Black;
            this.LTelefonoProveedor.Location = new System.Drawing.Point(261, 122);
            this.LTelefonoProveedor.Name = "LTelefonoProveedor";
            this.LTelefonoProveedor.Size = new System.Drawing.Size(60, 18);
            this.LTelefonoProveedor.TabIndex = 70;
            this.LTelefonoProveedor.Text = "Telefono";
            // 
            // LDireccionProveedor
            // 
            this.LDireccionProveedor.AutoSize = true;
            this.LDireccionProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDireccionProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccionProveedor.ForeColor = System.Drawing.Color.Black;
            this.LDireccionProveedor.Location = new System.Drawing.Point(255, 79);
            this.LDireccionProveedor.Name = "LDireccionProveedor";
            this.LDireccionProveedor.Size = new System.Drawing.Size(66, 18);
            this.LDireccionProveedor.TabIndex = 68;
            this.LDireccionProveedor.Text = "Direccion";
            // 
            // TBCUITProveedor
            // 
            this.TBCUITProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCUITProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBCUITProveedor.Location = new System.Drawing.Point(689, 75);
            this.TBCUITProveedor.Multiline = true;
            this.TBCUITProveedor.Name = "TBCUITProveedor";
            this.TBCUITProveedor.Size = new System.Drawing.Size(215, 25);
            this.TBCUITProveedor.TabIndex = 67;
            // 
            // TBEmailProveedor
            // 
            this.TBEmailProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmailProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBEmailProveedor.Location = new System.Drawing.Point(688, 31);
            this.TBEmailProveedor.Multiline = true;
            this.TBEmailProveedor.Name = "TBEmailProveedor";
            this.TBEmailProveedor.Size = new System.Drawing.Size(215, 25);
            this.TBEmailProveedor.TabIndex = 66;
            // 
            // TBNombreProveedor
            // 
            this.TBNombreProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreProveedor.Location = new System.Drawing.Point(341, 31);
            this.TBNombreProveedor.Multiline = true;
            this.TBNombreProveedor.Name = "TBNombreProveedor";
            this.TBNombreProveedor.Size = new System.Drawing.Size(215, 25);
            this.TBNombreProveedor.TabIndex = 64;
            // 
            // LCUITProveedor
            // 
            this.LCUITProveedor.AutoSize = true;
            this.LCUITProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCUITProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCUITProveedor.ForeColor = System.Drawing.Color.Black;
            this.LCUITProveedor.Location = new System.Drawing.Point(634, 79);
            this.LCUITProveedor.Name = "LCUITProveedor";
            this.LCUITProveedor.Size = new System.Drawing.Size(37, 18);
            this.LCUITProveedor.TabIndex = 63;
            this.LCUITProveedor.Text = "CUIT";
            // 
            // LEmailProveedor
            // 
            this.LEmailProveedor.AutoSize = true;
            this.LEmailProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmailProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmailProveedor.ForeColor = System.Drawing.Color.Black;
            this.LEmailProveedor.Location = new System.Drawing.Point(630, 33);
            this.LEmailProveedor.Name = "LEmailProveedor";
            this.LEmailProveedor.Size = new System.Drawing.Size(41, 18);
            this.LEmailProveedor.TabIndex = 62;
            this.LEmailProveedor.Text = "Email";
            // 
            // LNombreProveedor
            // 
            this.LNombreProveedor.AutoSize = true;
            this.LNombreProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProveedor.ForeColor = System.Drawing.Color.Black;
            this.LNombreProveedor.Location = new System.Drawing.Point(265, 33);
            this.LNombreProveedor.Name = "LNombreProveedor";
            this.LNombreProveedor.Size = new System.Drawing.Size(56, 18);
            this.LNombreProveedor.TabIndex = 60;
            this.LNombreProveedor.Text = "Nombre";
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LProveedor.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProveedor.ForeColor = System.Drawing.Color.Coral;
            this.LProveedor.Location = new System.Drawing.Point(12, 21);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(175, 29);
            this.LProveedor.TabIndex = 59;
            this.LProveedor.Text = "PROVEEDORES";
            this.LProveedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LFondoClientes
            // 
            this.LFondoClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoClientes.Location = new System.Drawing.Point(-71, -10);
            this.LFondoClientes.Name = "LFondoClientes";
            this.LFondoClientes.Size = new System.Drawing.Size(1366, 275);
            this.LFondoClientes.TabIndex = 58;
            // 
            // TBRazonSocialProveedor
            // 
            this.TBRazonSocialProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRazonSocialProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBRazonSocialProveedor.Location = new System.Drawing.Point(689, 120);
            this.TBRazonSocialProveedor.Multiline = true;
            this.TBRazonSocialProveedor.Name = "TBRazonSocialProveedor";
            this.TBRazonSocialProveedor.Size = new System.Drawing.Size(214, 25);
            this.TBRazonSocialProveedor.TabIndex = 81;
            // 
            // LRazonSocialProveedor
            // 
            this.LRazonSocialProveedor.AutoSize = true;
            this.LRazonSocialProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LRazonSocialProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRazonSocialProveedor.ForeColor = System.Drawing.Color.Black;
            this.LRazonSocialProveedor.Location = new System.Drawing.Point(588, 122);
            this.LRazonSocialProveedor.Name = "LRazonSocialProveedor";
            this.LRazonSocialProveedor.Size = new System.Drawing.Size(85, 18);
            this.LRazonSocialProveedor.TabIndex = 82;
            this.LRazonSocialProveedor.Text = "Razon Social";
            // 
            // BActivosProveedores
            // 
            this.BActivosProveedores.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BActivosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BActivosProveedores.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActivosProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BActivosProveedores.Location = new System.Drawing.Point(17, 294);
            this.BActivosProveedores.Name = "BActivosProveedores";
            this.BActivosProveedores.Size = new System.Drawing.Size(181, 41);
            this.BActivosProveedores.TabIndex = 85;
            this.BActivosProveedores.Text = "Proveedores Activos";
            this.BActivosProveedores.UseVisualStyleBackColor = false;
            // 
            // BInactivosProveedores
            // 
            this.BInactivosProveedores.BackColor = System.Drawing.Color.Brown;
            this.BInactivosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInactivosProveedores.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInactivosProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BInactivosProveedores.Location = new System.Drawing.Point(1071, 294);
            this.BInactivosProveedores.Name = "BInactivosProveedores";
            this.BInactivosProveedores.Size = new System.Drawing.Size(188, 41);
            this.BInactivosProveedores.TabIndex = 86;
            this.BInactivosProveedores.Text = "Proveedores Inactivos";
            this.BInactivosProveedores.UseVisualStyleBackColor = false;
            // 
            // TBCiudadProveedor
            // 
            this.TBCiudadProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCiudadProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBCiudadProveedor.Location = new System.Drawing.Point(1015, 34);
            this.TBCiudadProveedor.Multiline = true;
            this.TBCiudadProveedor.Name = "TBCiudadProveedor";
            this.TBCiudadProveedor.Size = new System.Drawing.Size(214, 25);
            this.TBCiudadProveedor.TabIndex = 87;
            // 
            // LCiudadProveedor
            // 
            this.LCiudadProveedor.AutoSize = true;
            this.LCiudadProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCiudadProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCiudadProveedor.ForeColor = System.Drawing.Color.Black;
            this.LCiudadProveedor.Location = new System.Drawing.Point(947, 36);
            this.LCiudadProveedor.Name = "LCiudadProveedor";
            this.LCiudadProveedor.Size = new System.Drawing.Size(51, 18);
            this.LCiudadProveedor.TabIndex = 88;
            this.LCiudadProveedor.Text = "Ciudad";
            // 
            // LPaisProveedor
            // 
            this.LPaisProveedor.AutoSize = true;
            this.LPaisProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPaisProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPaisProveedor.ForeColor = System.Drawing.Color.Black;
            this.LPaisProveedor.Location = new System.Drawing.Point(966, 79);
            this.LPaisProveedor.Name = "LPaisProveedor";
            this.LPaisProveedor.Size = new System.Drawing.Size(32, 18);
            this.LPaisProveedor.TabIndex = 89;
            this.LPaisProveedor.Text = "Pais";
            // 
            // TBPaisProveedor
            // 
            this.TBPaisProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPaisProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBPaisProveedor.Location = new System.Drawing.Point(1015, 75);
            this.TBPaisProveedor.Multiline = true;
            this.TBPaisProveedor.Name = "TBPaisProveedor";
            this.TBPaisProveedor.Size = new System.Drawing.Size(214, 25);
            this.TBPaisProveedor.TabIndex = 90;
            // 
            // LDescripcionProveedor
            // 
            this.LDescripcionProveedor.AutoSize = true;
            this.LDescripcionProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDescripcionProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcionProveedor.ForeColor = System.Drawing.Color.Black;
            this.LDescripcionProveedor.Location = new System.Drawing.Point(920, 122);
            this.LDescripcionProveedor.Name = "LDescripcionProveedor";
            this.LDescripcionProveedor.Size = new System.Drawing.Size(80, 18);
            this.LDescripcionProveedor.TabIndex = 91;
            this.LDescripcionProveedor.Text = "Descripcion";
            // 
            // TBDescripcionProveedor
            // 
            this.TBDescripcionProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcionProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBDescripcionProveedor.Location = new System.Drawing.Point(1015, 120);
            this.TBDescripcionProveedor.Multiline = true;
            this.TBDescripcionProveedor.Name = "TBDescripcionProveedor";
            this.TBDescripcionProveedor.Size = new System.Drawing.Size(215, 73);
            this.TBDescripcionProveedor.TabIndex = 92;
            // 
            // IdProveedor
            // 
            this.IdProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdProveedor.HeaderText = "ID";
            this.IdProveedor.Name = "IdProveedor";
            // 
            // CUITProveedor
            // 
            this.CUITProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUITProveedor.HeaderText = "CUIT";
            this.CUITProveedor.Name = "CUITProveedor";
            // 
            // nombreProveedor
            // 
            this.nombreProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProveedor.HeaderText = "Nombre";
            this.nombreProveedor.Name = "nombreProveedor";
            // 
            // direccionProveedor
            // 
            this.direccionProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccionProveedor.HeaderText = "Direccion";
            this.direccionProveedor.Name = "direccionProveedor";
            // 
            // telefonoProveedor
            // 
            this.telefonoProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonoProveedor.HeaderText = "Telefono";
            this.telefonoProveedor.Name = "telefonoProveedor";
            // 
            // emailProveedor
            // 
            this.emailProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailProveedor.HeaderText = "Email";
            this.emailProveedor.Name = "emailProveedor";
            // 
            // razonSocialProveedor
            // 
            this.razonSocialProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razonSocialProveedor.HeaderText = "Razon Social";
            this.razonSocialProveedor.Name = "razonSocialProveedor";
            // 
            // ciudadProveedor
            // 
            this.ciudadProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciudadProveedor.HeaderText = "Ciudad";
            this.ciudadProveedor.Name = "ciudadProveedor";
            // 
            // paisProveedor
            // 
            this.paisProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paisProveedor.HeaderText = "Pais";
            this.paisProveedor.Name = "paisProveedor";
            // 
            // descripcionProveedor
            // 
            this.descripcionProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionProveedor.HeaderText = "Descripcion";
            this.descripcionProveedor.Name = "descripcionProveedor";
            // 
            // editarProveedor
            // 
            this.editarProveedor.HeaderText = "Editar";
            this.editarProveedor.Name = "editarProveedor";
            // 
            // bajarProveedor
            // 
            this.bajarProveedor.HeaderText = "Dar de Baja";
            this.bajarProveedor.Name = "bajarProveedor";
            // 
            // PBFondoClientes
            // 
            this.PBFondoClientes.Image = ((System.Drawing.Image)(resources.GetObject("PBFondoClientes.Image")));
            this.PBFondoClientes.Location = new System.Drawing.Point(-15, 257);
            this.PBFondoClientes.Name = "PBFondoClientes";
            this.PBFondoClientes.Size = new System.Drawing.Size(1310, 454);
            this.PBFondoClientes.TabIndex = 77;
            this.PBFondoClientes.TabStop = false;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.TBDescripcionProveedor);
            this.Controls.Add(this.LDescripcionProveedor);
            this.Controls.Add(this.TBPaisProveedor);
            this.Controls.Add(this.LPaisProveedor);
            this.Controls.Add(this.LCiudadProveedor);
            this.Controls.Add(this.TBCiudadProveedor);
            this.Controls.Add(this.BInactivosProveedores);
            this.Controls.Add(this.BActivosProveedores);
            this.Controls.Add(this.LRazonSocialProveedor);
            this.Controls.Add(this.TBRazonSocialProveedor);
            this.Controls.Add(this.BCancelarProveedor);
            this.Controls.Add(this.BGuardarProveedor);
            this.Controls.Add(this.DGVProveedores);
            this.Controls.Add(this.TBTelefonoProveedor);
            this.Controls.Add(this.TBDireccionProveedor);
            this.Controls.Add(this.LTelefonoProveedor);
            this.Controls.Add(this.LDireccionProveedor);
            this.Controls.Add(this.TBCUITProveedor);
            this.Controls.Add(this.TBEmailProveedor);
            this.Controls.Add(this.TBNombreProveedor);
            this.Controls.Add(this.LCUITProveedor);
            this.Controls.Add(this.LEmailProveedor);
            this.Controls.Add(this.LNombreProveedor);
            this.Controls.Add(this.LProveedor);
            this.Controls.Add(this.LFondoClientes);
            this.Controls.Add(this.PBFondoClientes);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFondoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCancelarProveedor;
        private System.Windows.Forms.Button BGuardarProveedor;
        private System.Windows.Forms.DataGridView DGVProveedores;
        private System.Windows.Forms.TextBox TBTelefonoProveedor;
        private System.Windows.Forms.TextBox TBDireccionProveedor;
        private System.Windows.Forms.Label LTelefonoProveedor;
        private System.Windows.Forms.Label LDireccionProveedor;
        private System.Windows.Forms.TextBox TBCUITProveedor;
        private System.Windows.Forms.TextBox TBEmailProveedor;
        private System.Windows.Forms.TextBox TBNombreProveedor;
        private System.Windows.Forms.Label LCUITProveedor;
        private System.Windows.Forms.Label LEmailProveedor;
        private System.Windows.Forms.Label LNombreProveedor;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.Label LFondoClientes;
        private System.Windows.Forms.PictureBox PBFondoClientes;
        private System.Windows.Forms.TextBox TBRazonSocialProveedor;
        private System.Windows.Forms.Label LRazonSocialProveedor;
        private System.Windows.Forms.Button BActivosProveedores;
        private System.Windows.Forms.Button BInactivosProveedores;
        private System.Windows.Forms.TextBox TBCiudadProveedor;
        private System.Windows.Forms.Label LCiudadProveedor;
        private System.Windows.Forms.Label LPaisProveedor;
        private System.Windows.Forms.TextBox TBPaisProveedor;
        private System.Windows.Forms.Label LDescripcionProveedor;
        private System.Windows.Forms.TextBox TBDescripcionProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUITProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProveedor;
        private System.Windows.Forms.DataGridViewButtonColumn editarProveedor;
        private System.Windows.Forms.DataGridViewButtonColumn bajarProveedor;
    }
}