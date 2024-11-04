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
            this.TBDNIProveedor = new System.Windows.Forms.TextBox();
            this.TBEmailProveedor = new System.Windows.Forms.TextBox();
            this.TBNombreProveedor = new System.Windows.Forms.TextBox();
            this.LDniProveedor = new System.Windows.Forms.Label();
            this.LEmailProveedor = new System.Windows.Forms.Label();
            this.LNombreProveedor = new System.Windows.Forms.Label();
            this.LProveedor = new System.Windows.Forms.Label();
            this.LFondoClientes = new System.Windows.Forms.Label();
            this.PBFondoClientes = new System.Windows.Forms.PictureBox();
            this.TBRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.LRazonSocialProveedor = new System.Windows.Forms.Label();
            this.LEstadoProveedor = new System.Windows.Forms.Label();
            this.CBEstadoProveedor = new System.Windows.Forms.ComboBox();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarProveedor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminarProveedor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BActivosProveedores = new System.Windows.Forms.Button();
            this.BInactivosProveedores = new System.Windows.Forms.Button();
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
            this.BCancelarProveedor.Location = new System.Drawing.Point(679, 206);
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
            this.BGuardarProveedor.Location = new System.Drawing.Point(561, 206);
            this.BGuardarProveedor.Name = "BGuardarProveedor";
            this.BGuardarProveedor.Size = new System.Drawing.Size(94, 38);
            this.BGuardarProveedor.TabIndex = 79;
            this.BGuardarProveedor.Text = "Guardar";
            this.BGuardarProveedor.UseVisualStyleBackColor = false;
            // 
            // DGVProveedores
            // 
            this.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.dniProveedor,
            this.nombreProveedor,
            this.emailProveedor,
            this.telefonoProveedor,
            this.direccionProveedor,
            this.razonSocialProveedor,
            this.estadoProveedor,
            this.editarProveedor,
            this.eliminarProveedor});
            this.DGVProveedores.Location = new System.Drawing.Point(138, 352);
            this.DGVProveedores.Name = "DGVProveedores";
            this.DGVProveedores.Size = new System.Drawing.Size(1040, 307);
            this.DGVProveedores.TabIndex = 78;
            // 
            // TBTelefonoProveedor
            // 
            this.TBTelefonoProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefonoProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBTelefonoProveedor.Location = new System.Drawing.Point(492, 158);
            this.TBTelefonoProveedor.Multiline = true;
            this.TBTelefonoProveedor.Name = "TBTelefonoProveedor";
            this.TBTelefonoProveedor.Size = new System.Drawing.Size(134, 25);
            this.TBTelefonoProveedor.TabIndex = 73;
            // 
            // TBDireccionProveedor
            // 
            this.TBDireccionProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDireccionProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBDireccionProveedor.Location = new System.Drawing.Point(808, 30);
            this.TBDireccionProveedor.Multiline = true;
            this.TBDireccionProveedor.Name = "TBDireccionProveedor";
            this.TBDireccionProveedor.Size = new System.Drawing.Size(134, 25);
            this.TBDireccionProveedor.TabIndex = 72;
            // 
            // LTelefonoProveedor
            // 
            this.LTelefonoProveedor.AutoSize = true;
            this.LTelefonoProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefonoProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoProveedor.ForeColor = System.Drawing.Color.Black;
            this.LTelefonoProveedor.Location = new System.Drawing.Point(416, 160);
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
            this.LDireccionProveedor.Location = new System.Drawing.Point(707, 32);
            this.LDireccionProveedor.Name = "LDireccionProveedor";
            this.LDireccionProveedor.Size = new System.Drawing.Size(66, 18);
            this.LDireccionProveedor.TabIndex = 68;
            this.LDireccionProveedor.Text = "Direccion";
            // 
            // TBDNIProveedor
            // 
            this.TBDNIProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDNIProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBDNIProveedor.Location = new System.Drawing.Point(492, 72);
            this.TBDNIProveedor.Multiline = true;
            this.TBDNIProveedor.Name = "TBDNIProveedor";
            this.TBDNIProveedor.Size = new System.Drawing.Size(134, 25);
            this.TBDNIProveedor.TabIndex = 67;
            // 
            // TBEmailProveedor
            // 
            this.TBEmailProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmailProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBEmailProveedor.Location = new System.Drawing.Point(492, 113);
            this.TBEmailProveedor.Multiline = true;
            this.TBEmailProveedor.Name = "TBEmailProveedor";
            this.TBEmailProveedor.Size = new System.Drawing.Size(134, 25);
            this.TBEmailProveedor.TabIndex = 66;
            // 
            // TBNombreProveedor
            // 
            this.TBNombreProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreProveedor.Location = new System.Drawing.Point(492, 30);
            this.TBNombreProveedor.Multiline = true;
            this.TBNombreProveedor.Name = "TBNombreProveedor";
            this.TBNombreProveedor.Size = new System.Drawing.Size(134, 25);
            this.TBNombreProveedor.TabIndex = 64;
            // 
            // LDniProveedor
            // 
            this.LDniProveedor.AutoSize = true;
            this.LDniProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDniProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDniProveedor.ForeColor = System.Drawing.Color.Black;
            this.LDniProveedor.Location = new System.Drawing.Point(416, 74);
            this.LDniProveedor.Name = "LDniProveedor";
            this.LDniProveedor.Size = new System.Drawing.Size(29, 18);
            this.LDniProveedor.TabIndex = 63;
            this.LDniProveedor.Text = "DNI";
            // 
            // LEmailProveedor
            // 
            this.LEmailProveedor.AutoSize = true;
            this.LEmailProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmailProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmailProveedor.ForeColor = System.Drawing.Color.Black;
            this.LEmailProveedor.Location = new System.Drawing.Point(416, 115);
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
            this.LNombreProveedor.Location = new System.Drawing.Point(416, 32);
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
            this.LFondoClientes.Location = new System.Drawing.Point(-41, -5);
            this.LFondoClientes.Name = "LFondoClientes";
            this.LFondoClientes.Size = new System.Drawing.Size(1366, 281);
            this.LFondoClientes.TabIndex = 58;
            // 
            // PBFondoClientes
            // 
            this.PBFondoClientes.Image = ((System.Drawing.Image)(resources.GetObject("PBFondoClientes.Image")));
            this.PBFondoClientes.Location = new System.Drawing.Point(-13, 259);
            this.PBFondoClientes.Name = "PBFondoClientes";
            this.PBFondoClientes.Size = new System.Drawing.Size(1286, 439);
            this.PBFondoClientes.TabIndex = 77;
            this.PBFondoClientes.TabStop = false;
            // 
            // TBRazonSocialProveedor
            // 
            this.TBRazonSocialProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRazonSocialProveedor.ForeColor = System.Drawing.Color.Coral;
            this.TBRazonSocialProveedor.Location = new System.Drawing.Point(808, 72);
            this.TBRazonSocialProveedor.Multiline = true;
            this.TBRazonSocialProveedor.Name = "TBRazonSocialProveedor";
            this.TBRazonSocialProveedor.Size = new System.Drawing.Size(134, 25);
            this.TBRazonSocialProveedor.TabIndex = 81;
            // 
            // LRazonSocialProveedor
            // 
            this.LRazonSocialProveedor.AutoSize = true;
            this.LRazonSocialProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LRazonSocialProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRazonSocialProveedor.ForeColor = System.Drawing.Color.Black;
            this.LRazonSocialProveedor.Location = new System.Drawing.Point(707, 76);
            this.LRazonSocialProveedor.Name = "LRazonSocialProveedor";
            this.LRazonSocialProveedor.Size = new System.Drawing.Size(85, 18);
            this.LRazonSocialProveedor.TabIndex = 82;
            this.LRazonSocialProveedor.Text = "Razon Social";
            // 
            // LEstadoProveedor
            // 
            this.LEstadoProveedor.AutoSize = true;
            this.LEstadoProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEstadoProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstadoProveedor.ForeColor = System.Drawing.Color.Black;
            this.LEstadoProveedor.Location = new System.Drawing.Point(707, 115);
            this.LEstadoProveedor.Name = "LEstadoProveedor";
            this.LEstadoProveedor.Size = new System.Drawing.Size(48, 18);
            this.LEstadoProveedor.TabIndex = 83;
            this.LEstadoProveedor.Text = "Estado";
            // 
            // CBEstadoProveedor
            // 
            this.CBEstadoProveedor.FormattingEnabled = true;
            this.CBEstadoProveedor.Location = new System.Drawing.Point(808, 117);
            this.CBEstadoProveedor.Name = "CBEstadoProveedor";
            this.CBEstadoProveedor.Size = new System.Drawing.Size(134, 21);
            this.CBEstadoProveedor.TabIndex = 84;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "ID";
            this.IdProveedor.Name = "IdProveedor";
            // 
            // dniProveedor
            // 
            this.dniProveedor.HeaderText = "DNI";
            this.dniProveedor.Name = "dniProveedor";
            // 
            // nombreProveedor
            // 
            this.nombreProveedor.HeaderText = "Nombre";
            this.nombreProveedor.Name = "nombreProveedor";
            // 
            // emailProveedor
            // 
            this.emailProveedor.HeaderText = "Email";
            this.emailProveedor.Name = "emailProveedor";
            // 
            // telefonoProveedor
            // 
            this.telefonoProveedor.HeaderText = "Telefono";
            this.telefonoProveedor.Name = "telefonoProveedor";
            // 
            // direccionProveedor
            // 
            this.direccionProveedor.HeaderText = "Direccion";
            this.direccionProveedor.Name = "direccionProveedor";
            // 
            // razonSocialProveedor
            // 
            this.razonSocialProveedor.HeaderText = "Razon Social";
            this.razonSocialProveedor.Name = "razonSocialProveedor";
            // 
            // estadoProveedor
            // 
            this.estadoProveedor.HeaderText = "Estado";
            this.estadoProveedor.Name = "estadoProveedor";
            // 
            // editarProveedor
            // 
            this.editarProveedor.HeaderText = "Editar";
            this.editarProveedor.Name = "editarProveedor";
            // 
            // eliminarProveedor
            // 
            this.eliminarProveedor.HeaderText = "Dar de Baja";
            this.eliminarProveedor.Name = "eliminarProveedor";
            // 
            // BActivosProveedores
            // 
            this.BActivosProveedores.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BActivosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BActivosProveedores.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActivosProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BActivosProveedores.Location = new System.Drawing.Point(138, 294);
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
            this.BInactivosProveedores.Location = new System.Drawing.Point(990, 294);
            this.BInactivosProveedores.Name = "BInactivosProveedores";
            this.BInactivosProveedores.Size = new System.Drawing.Size(188, 41);
            this.BInactivosProveedores.TabIndex = 86;
            this.BInactivosProveedores.Text = "Proveedores Inactivos";
            this.BInactivosProveedores.UseVisualStyleBackColor = false;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.BInactivosProveedores);
            this.Controls.Add(this.BActivosProveedores);
            this.Controls.Add(this.CBEstadoProveedor);
            this.Controls.Add(this.LEstadoProveedor);
            this.Controls.Add(this.LRazonSocialProveedor);
            this.Controls.Add(this.TBRazonSocialProveedor);
            this.Controls.Add(this.BCancelarProveedor);
            this.Controls.Add(this.BGuardarProveedor);
            this.Controls.Add(this.DGVProveedores);
            this.Controls.Add(this.TBTelefonoProveedor);
            this.Controls.Add(this.TBDireccionProveedor);
            this.Controls.Add(this.LTelefonoProveedor);
            this.Controls.Add(this.LDireccionProveedor);
            this.Controls.Add(this.TBDNIProveedor);
            this.Controls.Add(this.TBEmailProveedor);
            this.Controls.Add(this.TBNombreProveedor);
            this.Controls.Add(this.LDniProveedor);
            this.Controls.Add(this.LEmailProveedor);
            this.Controls.Add(this.LNombreProveedor);
            this.Controls.Add(this.LProveedor);
            this.Controls.Add(this.LFondoClientes);
            this.Controls.Add(this.PBFondoClientes);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
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
        private System.Windows.Forms.TextBox TBDNIProveedor;
        private System.Windows.Forms.TextBox TBEmailProveedor;
        private System.Windows.Forms.TextBox TBNombreProveedor;
        private System.Windows.Forms.Label LDniProveedor;
        private System.Windows.Forms.Label LEmailProveedor;
        private System.Windows.Forms.Label LNombreProveedor;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.Label LFondoClientes;
        private System.Windows.Forms.PictureBox PBFondoClientes;
        private System.Windows.Forms.TextBox TBRazonSocialProveedor;
        private System.Windows.Forms.Label LRazonSocialProveedor;
        private System.Windows.Forms.Label LEstadoProveedor;
        private System.Windows.Forms.ComboBox CBEstadoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProveedor;
        private System.Windows.Forms.DataGridViewButtonColumn editarProveedor;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarProveedor;
        private System.Windows.Forms.Button BActivosProveedores;
        private System.Windows.Forms.Button BInactivosProveedores;
    }
}