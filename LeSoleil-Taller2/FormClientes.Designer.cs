namespace LeSoleil_Taller2
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.LFondoClientes = new System.Windows.Forms.Label();
            this.LCliente = new System.Windows.Forms.Label();
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.LApellidoCliente = new System.Windows.Forms.Label();
            this.LEmailCliente = new System.Windows.Forms.Label();
            this.LDniCliente = new System.Windows.Forms.Label();
            this.TBNombreCliente = new System.Windows.Forms.TextBox();
            this.TBApellidoCliente = new System.Windows.Forms.TextBox();
            this.TBEmailCliente = new System.Windows.Forms.TextBox();
            this.TBDNICliente = new System.Windows.Forms.TextBox();
            this.TBTelefonoCliente = new System.Windows.Forms.TextBox();
            this.TBDireccionCliente = new System.Windows.Forms.TextBox();
            this.LSexoCliente = new System.Windows.Forms.Label();
            this.LTelefonoCliente = new System.Windows.Forms.Label();
            this.LFechaNacCliente = new System.Windows.Forms.Label();
            this.LDireccionCliente = new System.Windows.Forms.Label();
            this.DTPFechaNacCliente = new System.Windows.Forms.DateTimePicker();
            this.RBMujerCliente = new System.Windows.Forms.RadioButton();
            this.RBHombreCliente = new System.Windows.Forms.RadioButton();
            this.PBFondoClientes = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PBFondoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LFondoClientes
            // 
            this.LFondoClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoClientes.Location = new System.Drawing.Point(-3, -9);
            this.LFondoClientes.Name = "LFondoClientes";
            this.LFondoClientes.Size = new System.Drawing.Size(813, 281);
            this.LFondoClientes.TabIndex = 29;
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCliente.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCliente.ForeColor = System.Drawing.Color.Coral;
            this.LCliente.Location = new System.Drawing.Point(241, 11);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(272, 29);
            this.LCliente.TabIndex = 30;
            this.LCliente.Text = "Suscripcion de Clientes";
            this.LCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.LNombreCliente.Location = new System.Drawing.Point(121, 58);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(56, 18);
            this.LNombreCliente.TabIndex = 31;
            this.LNombreCliente.Text = "Nombre";
            // 
            // LApellidoCliente
            // 
            this.LApellidoCliente.AutoSize = true;
            this.LApellidoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LApellidoCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidoCliente.ForeColor = System.Drawing.Color.Black;
            this.LApellidoCliente.Location = new System.Drawing.Point(119, 92);
            this.LApellidoCliente.Name = "LApellidoCliente";
            this.LApellidoCliente.Size = new System.Drawing.Size(58, 18);
            this.LApellidoCliente.TabIndex = 32;
            this.LApellidoCliente.Text = "Apellido";
            // 
            // LEmailCliente
            // 
            this.LEmailCliente.AutoSize = true;
            this.LEmailCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmailCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmailCliente.ForeColor = System.Drawing.Color.Black;
            this.LEmailCliente.Location = new System.Drawing.Point(121, 127);
            this.LEmailCliente.Name = "LEmailCliente";
            this.LEmailCliente.Size = new System.Drawing.Size(41, 18);
            this.LEmailCliente.TabIndex = 33;
            this.LEmailCliente.Text = "Email";
            // 
            // LDniCliente
            // 
            this.LDniCliente.AutoSize = true;
            this.LDniCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDniCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDniCliente.ForeColor = System.Drawing.Color.Black;
            this.LDniCliente.Location = new System.Drawing.Point(121, 163);
            this.LDniCliente.Name = "LDniCliente";
            this.LDniCliente.Size = new System.Drawing.Size(29, 18);
            this.LDniCliente.TabIndex = 34;
            this.LDniCliente.Text = "DNI";
            // 
            // TBNombreCliente
            // 
            this.TBNombreCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreCliente.Location = new System.Drawing.Point(193, 56);
            this.TBNombreCliente.Multiline = true;
            this.TBNombreCliente.Name = "TBNombreCliente";
            this.TBNombreCliente.Size = new System.Drawing.Size(134, 25);
            this.TBNombreCliente.TabIndex = 35;
            // 
            // TBApellidoCliente
            // 
            this.TBApellidoCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellidoCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBApellidoCliente.Location = new System.Drawing.Point(193, 90);
            this.TBApellidoCliente.Multiline = true;
            this.TBApellidoCliente.Name = "TBApellidoCliente";
            this.TBApellidoCliente.Size = new System.Drawing.Size(134, 25);
            this.TBApellidoCliente.TabIndex = 36;
            // 
            // TBEmailCliente
            // 
            this.TBEmailCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmailCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBEmailCliente.Location = new System.Drawing.Point(193, 126);
            this.TBEmailCliente.Multiline = true;
            this.TBEmailCliente.Name = "TBEmailCliente";
            this.TBEmailCliente.Size = new System.Drawing.Size(134, 25);
            this.TBEmailCliente.TabIndex = 37;
            // 
            // TBDNICliente
            // 
            this.TBDNICliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDNICliente.ForeColor = System.Drawing.Color.Coral;
            this.TBDNICliente.Location = new System.Drawing.Point(193, 161);
            this.TBDNICliente.Multiline = true;
            this.TBDNICliente.Name = "TBDNICliente";
            this.TBDNICliente.Size = new System.Drawing.Size(134, 25);
            this.TBDNICliente.TabIndex = 38;
            // 
            // TBTelefonoCliente
            // 
            this.TBTelefonoCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefonoCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBTelefonoCliente.Location = new System.Drawing.Point(480, 126);
            this.TBTelefonoCliente.Multiline = true;
            this.TBTelefonoCliente.Name = "TBTelefonoCliente";
            this.TBTelefonoCliente.Size = new System.Drawing.Size(134, 25);
            this.TBTelefonoCliente.TabIndex = 45;
            // 
            // TBDireccionCliente
            // 
            this.TBDireccionCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDireccionCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBDireccionCliente.Location = new System.Drawing.Point(480, 56);
            this.TBDireccionCliente.Multiline = true;
            this.TBDireccionCliente.Name = "TBDireccionCliente";
            this.TBDireccionCliente.Size = new System.Drawing.Size(134, 25);
            this.TBDireccionCliente.TabIndex = 43;
            // 
            // LSexoCliente
            // 
            this.LSexoCliente.AutoSize = true;
            this.LSexoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSexoCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSexoCliente.ForeColor = System.Drawing.Color.Black;
            this.LSexoCliente.Location = new System.Drawing.Point(408, 163);
            this.LSexoCliente.Name = "LSexoCliente";
            this.LSexoCliente.Size = new System.Drawing.Size(36, 18);
            this.LSexoCliente.TabIndex = 42;
            this.LSexoCliente.Text = "Sexo";
            // 
            // LTelefonoCliente
            // 
            this.LTelefonoCliente.AutoSize = true;
            this.LTelefonoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefonoCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoCliente.ForeColor = System.Drawing.Color.Black;
            this.LTelefonoCliente.Location = new System.Drawing.Point(408, 127);
            this.LTelefonoCliente.Name = "LTelefonoCliente";
            this.LTelefonoCliente.Size = new System.Drawing.Size(60, 18);
            this.LTelefonoCliente.TabIndex = 41;
            this.LTelefonoCliente.Text = "Telefono";
            // 
            // LFechaNacCliente
            // 
            this.LFechaNacCliente.AutoSize = true;
            this.LFechaNacCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFechaNacCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNacCliente.ForeColor = System.Drawing.Color.Black;
            this.LFechaNacCliente.Location = new System.Drawing.Point(406, 92);
            this.LFechaNacCliente.Name = "LFechaNacCliente";
            this.LFechaNacCliente.Size = new System.Drawing.Size(117, 18);
            this.LFechaNacCliente.TabIndex = 40;
            this.LFechaNacCliente.Text = "Fecha Nacimiento";
            // 
            // LDireccionCliente
            // 
            this.LDireccionCliente.AutoSize = true;
            this.LDireccionCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDireccionCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccionCliente.ForeColor = System.Drawing.Color.Black;
            this.LDireccionCliente.Location = new System.Drawing.Point(408, 58);
            this.LDireccionCliente.Name = "LDireccionCliente";
            this.LDireccionCliente.Size = new System.Drawing.Size(66, 18);
            this.LDireccionCliente.TabIndex = 39;
            this.LDireccionCliente.Text = "Direccion";
            // 
            // DTPFechaNacCliente
            // 
            this.DTPFechaNacCliente.Location = new System.Drawing.Point(529, 92);
            this.DTPFechaNacCliente.Name = "DTPFechaNacCliente";
            this.DTPFechaNacCliente.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaNacCliente.TabIndex = 47;
            // 
            // RBMujerCliente
            // 
            this.RBMujerCliente.AutoSize = true;
            this.RBMujerCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RBMujerCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMujerCliente.ForeColor = System.Drawing.Color.Black;
            this.RBMujerCliente.Location = new System.Drawing.Point(480, 164);
            this.RBMujerCliente.Name = "RBMujerCliente";
            this.RBMujerCliente.Size = new System.Drawing.Size(59, 22);
            this.RBMujerCliente.TabIndex = 48;
            this.RBMujerCliente.TabStop = true;
            this.RBMujerCliente.Text = "Mujer";
            this.RBMujerCliente.UseVisualStyleBackColor = false;
            // 
            // RBHombreCliente
            // 
            this.RBHombreCliente.AutoSize = true;
            this.RBHombreCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RBHombreCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHombreCliente.ForeColor = System.Drawing.Color.Black;
            this.RBHombreCliente.Location = new System.Drawing.Point(557, 164);
            this.RBHombreCliente.Name = "RBHombreCliente";
            this.RBHombreCliente.Size = new System.Drawing.Size(70, 22);
            this.RBHombreCliente.TabIndex = 49;
            this.RBHombreCliente.TabStop = true;
            this.RBHombreCliente.Text = "Hombre";
            this.RBHombreCliente.UseVisualStyleBackColor = false;
            
            // 
            // PBFondoClientes
            // 
            this.PBFondoClientes.Image = ((System.Drawing.Image)(resources.GetObject("PBFondoClientes.Image")));
            this.PBFondoClientes.Location = new System.Drawing.Point(0, 264);
            this.PBFondoClientes.Name = "PBFondoClientes";
            this.PBFondoClientes.Size = new System.Drawing.Size(810, 416);
            this.PBFondoClientes.TabIndex = 52;
            this.PBFondoClientes.TabStop = false;
            
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.DNI,
            this.nombre,
            this.apellido,
            this.fechaNacimiento,
            this.email,
            this.direccion,
            this.telefono,
            this.sexo});
            this.dataGridView1.Location = new System.Drawing.Point(17, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 307);
            this.dataGridView1.TabIndex = 55;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "ID Cliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "apellido";
            this.apellido.Name = "apellido";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "fecha nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            // 
            // sexo
            // 
            this.sexo.HeaderText = "sexo";
            this.sexo.Name = "sexo";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 674);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RBHombreCliente);
            this.Controls.Add(this.RBMujerCliente);
            this.Controls.Add(this.DTPFechaNacCliente);
            this.Controls.Add(this.TBTelefonoCliente);
            this.Controls.Add(this.TBDireccionCliente);
            this.Controls.Add(this.LSexoCliente);
            this.Controls.Add(this.LTelefonoCliente);
            this.Controls.Add(this.LFechaNacCliente);
            this.Controls.Add(this.LDireccionCliente);
            this.Controls.Add(this.TBDNICliente);
            this.Controls.Add(this.TBEmailCliente);
            this.Controls.Add(this.TBApellidoCliente);
            this.Controls.Add(this.TBNombreCliente);
            this.Controls.Add(this.LDniCliente);
            this.Controls.Add(this.LEmailCliente);
            this.Controls.Add(this.LApellidoCliente);
            this.Controls.Add(this.LNombreCliente);
            this.Controls.Add(this.LCliente);
            this.Controls.Add(this.LFondoClientes);
            this.Controls.Add(this.PBFondoClientes);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)(this.PBFondoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFondoClientes;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.Label LApellidoCliente;
        private System.Windows.Forms.Label LEmailCliente;
        private System.Windows.Forms.Label LDniCliente;
        private System.Windows.Forms.TextBox TBNombreCliente;
        private System.Windows.Forms.TextBox TBApellidoCliente;
        private System.Windows.Forms.TextBox TBEmailCliente;
        private System.Windows.Forms.TextBox TBDNICliente;
        private System.Windows.Forms.TextBox TBTelefonoCliente;
        private System.Windows.Forms.TextBox TBDireccionCliente;
        private System.Windows.Forms.Label LSexoCliente;
        private System.Windows.Forms.Label LTelefonoCliente;
        private System.Windows.Forms.Label LFechaNacCliente;
        private System.Windows.Forms.Label LDireccionCliente;
        private System.Windows.Forms.DateTimePicker DTPFechaNacCliente;
        private System.Windows.Forms.RadioButton RBMujerCliente;
        private System.Windows.Forms.RadioButton RBHombreCliente;
        private System.Windows.Forms.PictureBox PBFondoClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
    }
}