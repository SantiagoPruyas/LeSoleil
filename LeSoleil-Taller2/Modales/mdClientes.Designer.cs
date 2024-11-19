namespace LeSoleil_Taller2.Modales
{
    partial class mdClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBBusquedaCliente = new System.Windows.Forms.ComboBox();
            this.TBusquedaCliente = new System.Windows.Forms.TextBox();
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.BTBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVClientes
            // 
            this.DGVClientes.BackgroundColor = System.Drawing.Color.Tan;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.DNI,
            this.Nombre,
            this.Apellido});
            this.DGVClientes.Location = new System.Drawing.Point(11, 119);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.Size = new System.Drawing.Size(776, 319);
            this.DGVClientes.TabIndex = 56;
            this.DGVClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClientes_CellDoubleClick);
            // 
            // IdCliente
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.IdCliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.IdCliente.HeaderText = "ID Cliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // DNI
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.DNI.DefaultCellStyle = dataGridViewCellStyle6;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle7;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle8;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCliente.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCliente.ForeColor = System.Drawing.Color.Coral;
            this.LCliente.Location = new System.Drawing.Point(30, 20);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(199, 29);
            this.LCliente.TabIndex = 57;
            this.LCliente.Text = "Lista de Clientes";
            this.LCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Buscar por:";
            // 
            // CBBusquedaCliente
            // 
            this.CBBusquedaCliente.FormattingEnabled = true;
            this.CBBusquedaCliente.Location = new System.Drawing.Point(370, 77);
            this.CBBusquedaCliente.Name = "CBBusquedaCliente";
            this.CBBusquedaCliente.Size = new System.Drawing.Size(129, 21);
            this.CBBusquedaCliente.TabIndex = 59;
            // 
            // TBusquedaCliente
            // 
            this.TBusquedaCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusquedaCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBusquedaCliente.Location = new System.Drawing.Point(505, 76);
            this.TBusquedaCliente.Multiline = true;
            this.TBusquedaCliente.Name = "TBusquedaCliente";
            this.TBusquedaCliente.Size = new System.Drawing.Size(201, 21);
            this.TBusquedaCliente.TabIndex = 60;
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Image = global::LeSoleil_Taller2.Properties.Resources.escobapng;
            this.BTLimpiar.Location = new System.Drawing.Point(749, 72);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(31, 28);
            this.BTLimpiar.TabIndex = 62;
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // BTBuscarCliente
            // 
            this.BTBuscarCliente.Image = global::LeSoleil_Taller2.Properties.Resources.lupapng;
            this.BTBuscarCliente.Location = new System.Drawing.Point(712, 72);
            this.BTBuscarCliente.Name = "BTBuscarCliente";
            this.BTBuscarCliente.Size = new System.Drawing.Size(31, 28);
            this.BTBuscarCliente.TabIndex = 61;
            this.BTBuscarCliente.UseVisualStyleBackColor = true;
            this.BTBuscarCliente.Click += new System.EventHandler(this.BTBuscarCliente_Click);
            // 
            // mdClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.BTBuscarCliente);
            this.Controls.Add(this.TBusquedaCliente);
            this.Controls.Add(this.CBBusquedaCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LCliente);
            this.Controls.Add(this.DGVClientes);
            this.Name = "mdClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdClientes";
            this.Load += new System.EventHandler(this.mdClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBBusquedaCliente;
        private System.Windows.Forms.TextBox TBusquedaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button BTBuscarCliente;
        private System.Windows.Forms.Button BTLimpiar;
    }
}