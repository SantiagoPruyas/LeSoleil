﻿namespace LeSoleil_Taller2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LFondoProductos = new System.Windows.Forms.Label();
            this.LProductos = new System.Windows.Forms.Label();
            this.LDesde = new System.Windows.Forms.Label();
            this.fechainicio = new System.Windows.Forms.DateTimePicker();
            this.fechafin = new System.Windows.Forms.DateTimePicker();
            this.LHasta = new System.Windows.Forms.Label();
            this.DGVTotalVentas = new System.Windows.Forms.DataGridView();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.Lbuscador = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BBuscarFiltro = new System.Windows.Forms.Button();
            this.BLimpiarBuscador = new System.Windows.Forms.Button();
            this.LFondoUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTotalVentas)).BeginInit();
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
            // fechainicio
            // 
            this.fechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechainicio.Location = new System.Drawing.Point(78, 84);
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.Size = new System.Drawing.Size(106, 20);
            this.fechainicio.TabIndex = 47;
            // 
            // fechafin
            // 
            this.fechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechafin.Location = new System.Drawing.Point(262, 84);
            this.fechafin.Name = "fechafin";
            this.fechafin.Size = new System.Drawing.Size(106, 20);
            this.fechafin.TabIndex = 48;
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
            // DGVTotalVentas
            // 
            this.DGVTotalVentas.BackgroundColor = System.Drawing.Color.Tan;
            this.DGVTotalVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTotalVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaVenta,
            this.TipoFactura,
            this.NroFactura,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DNICliente,
            this.NombreCliente,
            this.CodigoProducto,
            this.NombreProducto,
            this.CategoriaProducto,
            this.PrecioVenta,
            this.cantidad,
            this.subtotal});
            this.DGVTotalVentas.Location = new System.Drawing.Point(18, 61);
            this.DGVTotalVentas.Name = "DGVTotalVentas";
            this.DGVTotalVentas.Size = new System.Drawing.Size(1217, 326);
            this.DGVTotalVentas.TabIndex = 55;
            // 
            // FechaVenta
            // 
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.Black;
            this.FechaVenta.DefaultCellStyle = dataGridViewCellStyle66;
            this.FechaVenta.HeaderText = "Fecha Registro";
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.Width = 150;
            // 
            // TipoFactura
            // 
            dataGridViewCellStyle67.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.Color.Black;
            this.TipoFactura.DefaultCellStyle = dataGridViewCellStyle67;
            this.TipoFactura.HeaderText = "Tipo Factura";
            this.TipoFactura.Name = "TipoFactura";
            // 
            // NroFactura
            // 
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.Color.Black;
            this.NroFactura.DefaultCellStyle = dataGridViewCellStyle68;
            this.NroFactura.HeaderText = "Numero Factura";
            this.NroFactura.Name = "NroFactura";
            // 
            // MontoTotal
            // 
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.Black;
            this.MontoTotal.DefaultCellStyle = dataGridViewCellStyle69;
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // UsuarioRegistro
            // 
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.Black;
            this.UsuarioRegistro.DefaultCellStyle = dataGridViewCellStyle70;
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            // 
            // DNICliente
            // 
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.Color.Black;
            this.DNICliente.DefaultCellStyle = dataGridViewCellStyle71;
            this.DNICliente.HeaderText = "DNI Cliente";
            this.DNICliente.Name = "DNICliente";
            this.DNICliente.Width = 120;
            // 
            // NombreCliente
            // 
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.Black;
            this.NombreCliente.DefaultCellStyle = dataGridViewCellStyle72;
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // CodigoProducto
            // 
            dataGridViewCellStyle73.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.Color.Black;
            this.CodigoProducto.DefaultCellStyle = dataGridViewCellStyle73;
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            // 
            // NombreProducto
            // 
            dataGridViewCellStyle74.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle74.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle74.SelectionForeColor = System.Drawing.Color.Black;
            this.NombreProducto.DefaultCellStyle = dataGridViewCellStyle74;
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // CategoriaProducto
            // 
            dataGridViewCellStyle75.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle75.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle75.SelectionForeColor = System.Drawing.Color.Black;
            this.CategoriaProducto.DefaultCellStyle = dataGridViewCellStyle75;
            this.CategoriaProducto.HeaderText = "Categoria";
            this.CategoriaProducto.Name = "CategoriaProducto";
            // 
            // PrecioVenta
            // 
            dataGridViewCellStyle76.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle76.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle76.SelectionForeColor = System.Drawing.Color.Black;
            this.PrecioVenta.DefaultCellStyle = dataGridViewCellStyle76;
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Width = 104;
            // 
            // cantidad
            // 
            dataGridViewCellStyle77.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle77.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.Color.Black;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle77;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            dataGridViewCellStyle78.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.Color.Black;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle78;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BLimpiarBuscador);
            this.panel1.Controls.Add(this.BBuscarFiltro);
            this.panel1.Controls.Add(this.txtbusqueda);
            this.panel1.Controls.Add(this.Lbuscador);
            this.panel1.Controls.Add(this.cbobusqueda);
            this.panel1.Controls.Add(this.DGVTotalVentas);
            this.panel1.Location = new System.Drawing.Point(12, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 428);
            this.panel1.TabIndex = 56;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.Color.Coral;
            this.txtbusqueda.Location = new System.Drawing.Point(876, 20);
            this.txtbusqueda.Multiline = true;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(163, 25);
            this.txtbusqueda.TabIndex = 58;
            // 
            // Lbuscador
            // 
            this.Lbuscador.AutoSize = true;
            this.Lbuscador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbuscador.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscador.ForeColor = System.Drawing.Color.Black;
            this.Lbuscador.Location = new System.Drawing.Point(615, 22);
            this.Lbuscador.Name = "Lbuscador";
            this.Lbuscador.Size = new System.Drawing.Size(79, 18);
            this.Lbuscador.TabIndex = 58;
            this.Lbuscador.Text = "Buscar Por:";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(700, 22);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(170, 21);
            this.cbobusqueda.TabIndex = 58;
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.LightSalmon;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.Black;
            this.BBuscar.Image = global::LeSoleil_Taller2.Properties.Resources.lupapng;
            this.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscar.Location = new System.Drawing.Point(387, 77);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(86, 33);
            this.BBuscar.TabIndex = 57;
            this.BBuscar.Text = "    Buscar";
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // BBuscarFiltro
            // 
            this.BBuscarFiltro.BackColor = System.Drawing.Color.LightSalmon;
            this.BBuscarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarFiltro.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarFiltro.ForeColor = System.Drawing.Color.Black;
            this.BBuscarFiltro.Image = global::LeSoleil_Taller2.Properties.Resources.lupapng;
            this.BBuscarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscarFiltro.Location = new System.Drawing.Point(1053, 15);
            this.BBuscarFiltro.Name = "BBuscarFiltro";
            this.BBuscarFiltro.Size = new System.Drawing.Size(86, 33);
            this.BBuscarFiltro.TabIndex = 58;
            this.BBuscarFiltro.Text = "    Buscar";
            this.BBuscarFiltro.UseVisualStyleBackColor = false;
            this.BBuscarFiltro.Click += new System.EventHandler(this.BBuscarFiltro_Click);
            // 
            // BLimpiarBuscador
            // 
            this.BLimpiarBuscador.BackColor = System.Drawing.Color.LightSalmon;
            this.BLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarBuscador.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarBuscador.ForeColor = System.Drawing.Color.Black;
            this.BLimpiarBuscador.Image = global::LeSoleil_Taller2.Properties.Resources.escobapng;
            this.BLimpiarBuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiarBuscador.Location = new System.Drawing.Point(1148, 15);
            this.BLimpiarBuscador.Name = "BLimpiarBuscador";
            this.BLimpiarBuscador.Size = new System.Drawing.Size(86, 33);
            this.BLimpiarBuscador.TabIndex = 61;
            this.BLimpiarBuscador.Text = "    Limpiar";
            this.BLimpiarBuscador.UseVisualStyleBackColor = false;
            this.BLimpiarBuscador.Click += new System.EventHandler(this.BLimpiarBuscador_Click);
            // 
            // LFondoUser
            // 
            this.LFondoUser.BackColor = System.Drawing.Color.DarkGray;
            this.LFondoUser.Location = new System.Drawing.Point(-7, -28);
            this.LFondoUser.Name = "LFondoUser";
            this.LFondoUser.Size = new System.Drawing.Size(1326, 739);
            this.LFondoUser.TabIndex = 58;
            // 
            // FormReporteGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.fechafin);
            this.Controls.Add(this.fechainicio);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.LProductos);
            this.Controls.Add(this.LFondoProductos);
            this.Controls.Add(this.LFondoUser);
            this.Name = "FormReporteGerente";
            this.Text = "Reportes Gerente";
            this.Load += new System.EventHandler(this.FormReporteGerente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTotalVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFondoProductos;
        private System.Windows.Forms.Label LProductos;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.DateTimePicker fechainicio;
        private System.Windows.Forms.DateTimePicker fechafin;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.DataGridView DGVTotalVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Label Lbuscador;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button BLimpiarBuscador;
        private System.Windows.Forms.Button BBuscarFiltro;
        private System.Windows.Forms.Label LFondoUser;
    }
}