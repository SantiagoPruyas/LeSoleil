namespace LeSoleil_Taller2
{
    partial class FormReporteGerente
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
            this.LFondoProductos = new System.Windows.Forms.Label();
            this.LProductos = new System.Windows.Forms.Label();
            this.LDesde = new System.Windows.Forms.Label();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.LHasta = new System.Windows.Forms.Label();
            this.LTipoReporte = new System.Windows.Forms.Label();
            this.CBTipoReporte = new System.Windows.Forms.ComboBox();
            this.DGVVentas = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNICliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LFondoProductos
            // 
            this.LFondoProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LFondoProductos.Location = new System.Drawing.Point(12, 19);
            this.LFondoProductos.Name = "LFondoProductos";
            this.LFondoProductos.Size = new System.Drawing.Size(1251, 122);
            this.LFondoProductos.TabIndex = 30;
            // 
            // LProductos
            // 
            this.LProductos.AutoSize = true;
            this.LProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LProductos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductos.ForeColor = System.Drawing.Color.Coral;
            this.LProductos.Location = new System.Drawing.Point(26, 31);
            this.LProductos.Name = "LProductos";
            this.LProductos.Size = new System.Drawing.Size(275, 29);
            this.LProductos.TabIndex = 44;
            this.LProductos.Text = "REPORTE DEL GERENTE";
            this.LProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDesde.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.ForeColor = System.Drawing.Color.Black;
            this.LDesde.Location = new System.Drawing.Point(28, 84);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(53, 18);
            this.LDesde.TabIndex = 46;
            this.LDesde.Text = "Desde: ";
            // 
            // DTPDesde
            // 
            this.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesde.Location = new System.Drawing.Point(78, 84);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(106, 20);
            this.DTPDesde.TabIndex = 47;
            // 
            // DTPHasta
            // 
            this.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHasta.Location = new System.Drawing.Point(262, 84);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(106, 20);
            this.DTPHasta.TabIndex = 48;
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LHasta.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.ForeColor = System.Drawing.Color.Black;
            this.LHasta.Location = new System.Drawing.Point(209, 84);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(47, 18);
            this.LHasta.TabIndex = 49;
            this.LHasta.Text = "Hasta:";
            // 
            // LTipoReporte
            // 
            this.LTipoReporte.AutoSize = true;
            this.LTipoReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTipoReporte.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoReporte.ForeColor = System.Drawing.Color.Black;
            this.LTipoReporte.Location = new System.Drawing.Point(439, 84);
            this.LTipoReporte.Name = "LTipoReporte";
            this.LTipoReporte.Size = new System.Drawing.Size(106, 18);
            this.LTipoReporte.TabIndex = 50;
            this.LTipoReporte.Text = "Tipo de Reporte";
            // 
            // CBTipoReporte
            // 
            this.CBTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoReporte.FormattingEnabled = true;
            this.CBTipoReporte.Items.AddRange(new object[] {
            "Reporte de Ventas"});
            this.CBTipoReporte.Location = new System.Drawing.Point(553, 83);
            this.CBTipoReporte.Name = "CBTipoReporte";
            this.CBTipoReporte.Size = new System.Drawing.Size(206, 21);
            this.CBTipoReporte.TabIndex = 54;
            // 
            // DGVVentas
            // 
            this.DGVVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoFactura,
            this.NroFactura,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DNICliente,
            this.NombreCliente,
            this.CodigoProducto,
            this.NombreProducto,
            this.CategoriaProducto,
            this.PrecioVenta});
            this.DGVVentas.Location = new System.Drawing.Point(18, 19);
            this.DGVVentas.Name = "DGVVentas";
            this.DGVVentas.Size = new System.Drawing.Size(1217, 500);
            this.DGVVentas.TabIndex = 55;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.Width = 150;
            // 
            // TipoFactura
            // 
            this.TipoFactura.HeaderText = "Tipo Factura";
            this.TipoFactura.Name = "TipoFactura";
            // 
            // NroFactura
            // 
            this.NroFactura.HeaderText = "Numero Factura";
            this.NroFactura.Name = "NroFactura";
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            // 
            // DNICliente
            // 
            this.DNICliente.HeaderText = "DNI Cliente";
            this.DNICliente.Name = "DNICliente";
            this.DNICliente.Width = 120;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // CategoriaProducto
            // 
            this.CategoriaProducto.HeaderText = "Categoria";
            this.CategoriaProducto.Name = "CategoriaProducto";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Width = 104;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DGVVentas);
            this.panel1.Location = new System.Drawing.Point(12, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 535);
            this.panel1.TabIndex = 56;
            // 
            // BBuscar
            // 
            this.BBuscar.Image = global::LeSoleil_Taller2.Properties.Resources.lupapng;
            this.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscar.Location = new System.Drawing.Point(765, 82);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(75, 23);
            this.BBuscar.TabIndex = 57;
            this.BBuscar.Text = "    Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // FormReporteGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CBTipoReporte);
            this.Controls.Add(this.LTipoReporte);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.DTPHasta);
            this.Controls.Add(this.DTPDesde);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.LProductos);
            this.Controls.Add(this.LFondoProductos);
            this.Name = "FormReporteGerente";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFondoProductos;
        private System.Windows.Forms.Label LProductos;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LTipoReporte;
        private System.Windows.Forms.ComboBox CBTipoReporte;
        private System.Windows.Forms.DataGridView DGVVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNICliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
    }
}