namespace LeSoleil_Taller2
{
    partial class FormVentasDetalle
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
            this.LDetalleVenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBTipoFactura = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.LTipoFactura = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LDNIDetalle = new System.Windows.Forms.Label();
            this.TBBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBNombreCliente = new System.Windows.Forms.TextBox();
            this.TBFactura = new System.Windows.Forms.TextBox();
            this.TBDNICliente = new System.Windows.Forms.TextBox();
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.LDNICliente = new System.Windows.Forms.Label();
            this.DGVProductosDetalle = new System.Windows.Forms.DataGridView();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LPrecioTotalDetalle = new System.Windows.Forms.Label();
            this.TBPrecioTotalDetalle = new System.Windows.Forms.TextBox();
            this.BDescargarPDF = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPago = new System.Windows.Forms.TextBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BRegistrarVenta = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LFondoUser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductosDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LDetalleVenta
            // 
            this.LDetalleVenta.AutoSize = true;
            this.LDetalleVenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDetalleVenta.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleVenta.ForeColor = System.Drawing.Color.Black;
            this.LDetalleVenta.Location = new System.Drawing.Point(25, 19);
            this.LDetalleVenta.Name = "LDetalleVenta";
            this.LDetalleVenta.Size = new System.Drawing.Size(143, 27);
            this.LDetalleVenta.TabIndex = 4;
            this.LDetalleVenta.Text = "Detalle Venta";
            this.LDetalleVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.TBTipoFactura);
            this.groupBox1.Controls.Add(this.LUsuario);
            this.groupBox1.Controls.Add(this.TBUsuario);
            this.groupBox1.Controls.Add(this.TBFecha);
            this.groupBox1.Controls.Add(this.LTipoFactura);
            this.groupBox1.Controls.Add(this.LFecha);
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(330, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(629, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // TBTipoFactura
            // 
            this.TBTipoFactura.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTipoFactura.ForeColor = System.Drawing.Color.Coral;
            this.TBTipoFactura.Location = new System.Drawing.Point(218, 50);
            this.TBTipoFactura.Multiline = true;
            this.TBTipoFactura.Name = "TBTipoFactura";
            this.TBTipoFactura.Size = new System.Drawing.Size(187, 25);
            this.TBTipoFactura.TabIndex = 23;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.Black;
            this.LUsuario.Location = new System.Drawing.Point(424, 26);
            this.LUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(55, 18);
            this.LUsuario.TabIndex = 22;
            this.LUsuario.Text = "Usuario";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.ForeColor = System.Drawing.Color.Coral;
            this.TBUsuario.Location = new System.Drawing.Point(427, 50);
            this.TBUsuario.Multiline = true;
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(187, 25);
            this.TBUsuario.TabIndex = 21;
            // 
            // TBFecha
            // 
            this.TBFecha.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFecha.ForeColor = System.Drawing.Color.Coral;
            this.TBFecha.Location = new System.Drawing.Point(10, 50);
            this.TBFecha.Multiline = true;
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.Size = new System.Drawing.Size(187, 25);
            this.TBFecha.TabIndex = 19;
            // 
            // LTipoFactura
            // 
            this.LTipoFactura.AutoSize = true;
            this.LTipoFactura.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTipoFactura.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoFactura.ForeColor = System.Drawing.Color.Black;
            this.LTipoFactura.Location = new System.Drawing.Point(215, 26);
            this.LTipoFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTipoFactura.Name = "LTipoFactura";
            this.LTipoFactura.Size = new System.Drawing.Size(86, 18);
            this.LTipoFactura.TabIndex = 18;
            this.LTipoFactura.Text = "Tipo Factura";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFecha.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.Black;
            this.LFecha.Location = new System.Drawing.Point(7, 26);
            this.LFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(44, 18);
            this.LFecha.TabIndex = 16;
            this.LFecha.Text = "Fecha";
            // 
            // LDNIDetalle
            // 
            this.LDNIDetalle.AutoSize = true;
            this.LDNIDetalle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDNIDetalle.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDNIDetalle.ForeColor = System.Drawing.Color.Black;
            this.LDNIDetalle.Location = new System.Drawing.Point(198, 73);
            this.LDNIDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDNIDetalle.Name = "LDNIDetalle";
            this.LDNIDetalle.Size = new System.Drawing.Size(107, 18);
            this.LDNIDetalle.TabIndex = 24;
            this.LDNIDetalle.Text = "Numero Factura";
            // 
            // TBBusqueda
            // 
            this.TBBusqueda.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBusqueda.ForeColor = System.Drawing.Color.Coral;
            this.TBBusqueda.Location = new System.Drawing.Point(613, 82);
            this.TBBusqueda.Multiline = true;
            this.TBBusqueda.Name = "TBBusqueda";
            this.TBBusqueda.Size = new System.Drawing.Size(186, 25);
            this.TBBusqueda.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.TBNombreCliente);
            this.groupBox2.Controls.Add(this.TBFactura);
            this.groupBox2.Controls.Add(this.TBDNICliente);
            this.groupBox2.Controls.Add(this.LNombreCliente);
            this.groupBox2.Controls.Add(this.LDNICliente);
            this.groupBox2.ForeColor = System.Drawing.Color.Brown;
            this.groupBox2.Location = new System.Drawing.Point(330, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(629, 93);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // TBNombreCliente
            // 
            this.TBNombreCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreCliente.Location = new System.Drawing.Point(218, 50);
            this.TBNombreCliente.Multiline = true;
            this.TBNombreCliente.Name = "TBNombreCliente";
            this.TBNombreCliente.Size = new System.Drawing.Size(285, 25);
            this.TBNombreCliente.TabIndex = 23;
            // 
            // TBFactura
            // 
            this.TBFactura.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFactura.ForeColor = System.Drawing.Color.Coral;
            this.TBFactura.Location = new System.Drawing.Point(551, 50);
            this.TBFactura.Multiline = true;
            this.TBFactura.Name = "TBFactura";
            this.TBFactura.Size = new System.Drawing.Size(63, 25);
            this.TBFactura.TabIndex = 21;
            // 
            // TBDNICliente
            // 
            this.TBDNICliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDNICliente.ForeColor = System.Drawing.Color.Coral;
            this.TBDNICliente.Location = new System.Drawing.Point(10, 50);
            this.TBDNICliente.Multiline = true;
            this.TBDNICliente.Name = "TBDNICliente";
            this.TBDNICliente.Size = new System.Drawing.Size(187, 25);
            this.TBDNICliente.TabIndex = 19;
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.LNombreCliente.Location = new System.Drawing.Point(215, 26);
            this.LNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(103, 18);
            this.LNombreCliente.TabIndex = 18;
            this.LNombreCliente.Text = "Nombre Cliente";
            // 
            // LDNICliente
            // 
            this.LDNICliente.AutoSize = true;
            this.LDNICliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDNICliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDNICliente.ForeColor = System.Drawing.Color.Black;
            this.LDNICliente.Location = new System.Drawing.Point(7, 26);
            this.LDNICliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDNICliente.Name = "LDNICliente";
            this.LDNICliente.Size = new System.Drawing.Size(123, 18);
            this.LDNICliente.TabIndex = 16;
            this.LDNICliente.Text = "Documento Cliente";
            // 
            // DGVProductosDetalle
            // 
            this.DGVProductosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductosDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProducto,
            this.Precio,
            this.Cantidad,
            this.Subtotal});
            this.DGVProductosDetalle.Location = new System.Drawing.Point(330, 323);
            this.DGVProductosDetalle.Name = "DGVProductosDetalle";
            this.DGVProductosDetalle.Size = new System.Drawing.Size(629, 202);
            this.DGVProductosDetalle.TabIndex = 59;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.Name = "nombreProducto";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // LPrecioTotalDetalle
            // 
            this.LPrecioTotalDetalle.AutoSize = true;
            this.LPrecioTotalDetalle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPrecioTotalDetalle.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioTotalDetalle.ForeColor = System.Drawing.Color.Black;
            this.LPrecioTotalDetalle.Location = new System.Drawing.Point(327, 534);
            this.LPrecioTotalDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPrecioTotalDetalle.Name = "LPrecioTotalDetalle";
            this.LPrecioTotalDetalle.Size = new System.Drawing.Size(85, 18);
            this.LPrecioTotalDetalle.TabIndex = 60;
            this.LPrecioTotalDetalle.Text = "Precio Total:";
            // 
            // TBPrecioTotalDetalle
            // 
            this.TBPrecioTotalDetalle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioTotalDetalle.ForeColor = System.Drawing.Color.Coral;
            this.TBPrecioTotalDetalle.Location = new System.Drawing.Point(114, 516);
            this.TBPrecioTotalDetalle.Multiline = true;
            this.TBPrecioTotalDetalle.Name = "TBPrecioTotalDetalle";
            this.TBPrecioTotalDetalle.Size = new System.Drawing.Size(78, 26);
            this.TBPrecioTotalDetalle.TabIndex = 61;
            // 
            // BDescargarPDF
            // 
            this.BDescargarPDF.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BDescargarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDescargarPDF.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDescargarPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BDescargarPDF.Location = new System.Drawing.Point(495, 515);
            this.BDescargarPDF.Name = "BDescargarPDF";
            this.BDescargarPDF.Size = new System.Drawing.Size(163, 33);
            this.BDescargarPDF.TabIndex = 62;
            this.BDescargarPDF.Text = "Descargar en PDF";
            this.BDescargarPDF.UseVisualStyleBackColor = false;
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Tan;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BLimpiar.Location = new System.Drawing.Point(885, 82);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(74, 25);
            this.BLimpiar.TabIndex = 64;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.Tan;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BBuscar.Location = new System.Drawing.Point(805, 82);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(74, 25);
            this.BBuscar.TabIndex = 65;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TBMonto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBPrecioTotalDetalle);
            this.panel1.Controls.Add(this.BDescargarPDF);
            this.panel1.Controls.Add(this.TBPago);
            this.panel1.Controls.Add(this.BCancelar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BRegistrarVenta);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LDetalleVenta);
            this.panel1.Controls.Add(this.LDNIDetalle);
            this.panel1.Location = new System.Drawing.Point(300, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 576);
            this.panel1.TabIndex = 66;
            // 
            // TBMonto
            // 
            this.TBMonto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMonto.ForeColor = System.Drawing.Color.Coral;
            this.TBMonto.Location = new System.Drawing.Point(390, 516);
            this.TBMonto.Multiline = true;
            this.TBMonto.Name = "TBMonto";
            this.TBMonto.Size = new System.Drawing.Size(78, 26);
            this.TBMonto.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(333, 518);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Monto:";
            // 
            // TBPago
            // 
            this.TBPago.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPago.ForeColor = System.Drawing.Color.Coral;
            this.TBPago.Location = new System.Drawing.Point(247, 516);
            this.TBPago.Multiline = true;
            this.TBPago.Name = "TBPago";
            this.TBPago.Size = new System.Drawing.Size(78, 26);
            this.TBPago.TabIndex = 69;
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Brown;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelar.Location = new System.Drawing.Point(995, 557);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(113, 46);
            this.BCancelar.TabIndex = 61;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(199, 518);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "Pago:";
            // 
            // BRegistrarVenta
            // 
            this.BRegistrarVenta.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegistrarVenta.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BRegistrarVenta.Location = new System.Drawing.Point(796, 557);
            this.BRegistrarVenta.Name = "BRegistrarVenta";
            this.BRegistrarVenta.Size = new System.Drawing.Size(160, 46);
            this.BRegistrarVenta.TabIndex = 60;
            this.BRegistrarVenta.Text = "Registrar Venta";
            this.BRegistrarVenta.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Coral;
            this.textBox4.Location = new System.Drawing.Point(796, 505);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 26);
            this.textBox4.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(793, 474);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 41;
            this.label11.Text = "Precio Total:";
            // 
            // LFondoUser
            // 
            this.LFondoUser.BackColor = System.Drawing.Color.Tan;
            this.LFondoUser.Location = new System.Drawing.Point(-7, -45);
            this.LFondoUser.Name = "LFondoUser";
            this.LFondoUser.Size = new System.Drawing.Size(1536, 755);
            this.LFondoUser.TabIndex = 67;
            // 
            // FormVentasDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.LPrecioTotalDetalle);
            this.Controls.Add(this.DGVProductosDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TBBusqueda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LFondoUser);
            this.Name = "FormVentasDetalle";
            this.Text = "Detalle Venta";
            this.Load += new System.EventHandler(this.FormVentasDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductosDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDetalleVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBTipoFactura;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.Label LTipoFactura;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LDNIDetalle;
        private System.Windows.Forms.TextBox TBBusqueda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBNombreCliente;
        private System.Windows.Forms.TextBox TBFactura;
        private System.Windows.Forms.TextBox TBDNICliente;
        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.Label LDNICliente;
        private System.Windows.Forms.DataGridView DGVProductosDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label LPrecioTotalDetalle;
        private System.Windows.Forms.TextBox TBPrecioTotalDetalle;
        private System.Windows.Forms.Button BDescargarPDF;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BBuscar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BRegistrarVenta;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LFondoUser;
        private System.Windows.Forms.TextBox TBPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMonto;
        private System.Windows.Forms.Label label2;
    }
}