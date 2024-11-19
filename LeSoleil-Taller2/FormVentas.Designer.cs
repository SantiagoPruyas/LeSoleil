namespace LeSoleil_Taller2
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBInfoCliente = new System.Windows.Forms.GroupBox();
            this.LId_cliente = new System.Windows.Forms.Label();
            this.TBApellidoCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BTBuscarCliente = new System.Windows.Forms.Button();
            this.TBNombreCliente = new System.Windows.Forms.TextBox();
            this.TBDniCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LDNIUser = new System.Windows.Forms.Label();
            this.LUsers = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBTipoFactura = new System.Windows.Forms.ComboBox();
            this.TBFechaActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LId_producto = new System.Windows.Forms.Label();
            this.BTBuscarProducto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DUDCantidad = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.TBCodigoProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BAgregarProducto = new System.Windows.Forms.Button();
            this.DGVProductosVenta = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTEliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBNombreVendedor = new System.Windows.Forms.TextBox();
            this.TBIdVendedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBPrecioTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBCambio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TBPago = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BAgregarCliente = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BRegistrarVenta = new System.Windows.Forms.Button();
            this.GBInfoCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductosVenta)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBInfoCliente
            // 
            this.GBInfoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBInfoCliente.Controls.Add(this.LId_cliente);
            this.GBInfoCliente.Controls.Add(this.TBApellidoCliente);
            this.GBInfoCliente.Controls.Add(this.label12);
            this.GBInfoCliente.Controls.Add(this.BTBuscarCliente);
            this.GBInfoCliente.Controls.Add(this.TBNombreCliente);
            this.GBInfoCliente.Controls.Add(this.TBDniCliente);
            this.GBInfoCliente.Controls.Add(this.label1);
            this.GBInfoCliente.Controls.Add(this.LDNIUser);
            this.GBInfoCliente.ForeColor = System.Drawing.Color.Brown;
            this.GBInfoCliente.Location = new System.Drawing.Point(438, 132);
            this.GBInfoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.GBInfoCliente.Name = "GBInfoCliente";
            this.GBInfoCliente.Padding = new System.Windows.Forms.Padding(4);
            this.GBInfoCliente.Size = new System.Drawing.Size(558, 93);
            this.GBInfoCliente.TabIndex = 0;
            this.GBInfoCliente.TabStop = false;
            this.GBInfoCliente.Text = "Informacion Cliente";
            // 
            // LId_cliente
            // 
            this.LId_cliente.AutoSize = true;
            this.LId_cliente.Location = new System.Drawing.Point(39, 26);
            this.LId_cliente.Name = "LId_cliente";
            this.LId_cliente.Size = new System.Drawing.Size(65, 18);
            this.LId_cliente.TabIndex = 42;
            this.LId_cliente.Text = "Id_cliente";
            this.LId_cliente.Visible = false;
            // 
            // TBApellidoCliente
            // 
            this.TBApellidoCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellidoCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBApellidoCliente.Location = new System.Drawing.Point(395, 50);
            this.TBApellidoCliente.Multiline = true;
            this.TBApellidoCliente.Name = "TBApellidoCliente";
            this.TBApellidoCliente.Size = new System.Drawing.Size(142, 25);
            this.TBApellidoCliente.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(392, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Apellido:";
            // 
            // BTBuscarCliente
            // 
            this.BTBuscarCliente.Location = new System.Drawing.Point(157, 50);
            this.BTBuscarCliente.Name = "BTBuscarCliente";
            this.BTBuscarCliente.Size = new System.Drawing.Size(57, 26);
            this.BTBuscarCliente.TabIndex = 21;
            this.BTBuscarCliente.Text = "Buscar";
            this.BTBuscarCliente.UseVisualStyleBackColor = true;
            this.BTBuscarCliente.Click += new System.EventHandler(this.BTBuscarCliente_Click);
            // 
            // TBNombreCliente
            // 
            this.TBNombreCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreCliente.Location = new System.Drawing.Point(230, 50);
            this.TBNombreCliente.Multiline = true;
            this.TBNombreCliente.Name = "TBNombreCliente";
            this.TBNombreCliente.Size = new System.Drawing.Size(142, 25);
            this.TBNombreCliente.TabIndex = 20;
            // 
            // TBDniCliente
            // 
            this.TBDniCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDniCliente.ForeColor = System.Drawing.Color.Coral;
            this.TBDniCliente.Location = new System.Drawing.Point(11, 50);
            this.TBDniCliente.Multiline = true;
            this.TBDniCliente.Name = "TBDniCliente";
            this.TBDniCliente.Size = new System.Drawing.Size(134, 25);
            this.TBDniCliente.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(227, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre:";
            // 
            // LDNIUser
            // 
            this.LDNIUser.AutoSize = true;
            this.LDNIUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDNIUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDNIUser.ForeColor = System.Drawing.Color.Black;
            this.LDNIUser.Location = new System.Drawing.Point(7, 26);
            this.LDNIUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDNIUser.Name = "LDNIUser";
            this.LDNIUser.Size = new System.Drawing.Size(34, 18);
            this.LDNIUser.TabIndex = 16;
            this.LDNIUser.Text = "DNI:";
            // 
            // LUsers
            // 
            this.LUsers.AutoSize = true;
            this.LUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LUsers.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsers.ForeColor = System.Drawing.Color.Coral;
            this.LUsers.Location = new System.Drawing.Point(34, 41);
            this.LUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LUsers.Name = "LUsers";
            this.LUsers.Size = new System.Drawing.Size(185, 29);
            this.LUsers.TabIndex = 4;
            this.LUsers.Text = "Registrar Venta";
            this.LUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.CBTipoFactura);
            this.groupBox1.Controls.Add(this.TBFechaActual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(40, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(368, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // CBTipoFactura
            // 
            this.CBTipoFactura.FormattingEnabled = true;
            this.CBTipoFactura.Location = new System.Drawing.Point(166, 50);
            this.CBTipoFactura.Name = "CBTipoFactura";
            this.CBTipoFactura.Size = new System.Drawing.Size(183, 26);
            this.CBTipoFactura.TabIndex = 20;
            // 
            // TBFechaActual
            // 
            this.TBFechaActual.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFechaActual.ForeColor = System.Drawing.Color.Coral;
            this.TBFechaActual.Location = new System.Drawing.Point(10, 50);
            this.TBFechaActual.Multiline = true;
            this.TBFechaActual.Name = "TBFechaActual";
            this.TBFechaActual.Size = new System.Drawing.Size(134, 25);
            this.TBFechaActual.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(163, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.LId_producto);
            this.groupBox2.Controls.Add(this.BTBuscarProducto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DUDCantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TBStock);
            this.groupBox2.Controls.Add(this.TBPrecio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TBProducto);
            this.groupBox2.Controls.Add(this.TBCodigoProducto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.Brown;
            this.groupBox2.Location = new System.Drawing.Point(39, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(809, 105);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de Producto";
            // 
            // LId_producto
            // 
            this.LId_producto.AutoSize = true;
            this.LId_producto.Location = new System.Drawing.Point(7, 78);
            this.LId_producto.Name = "LId_producto";
            this.LId_producto.Size = new System.Drawing.Size(76, 18);
            this.LId_producto.TabIndex = 41;
            this.LId_producto.Text = "Id_producto";
            this.LId_producto.Visible = false;
            // 
            // BTBuscarProducto
            // 
            this.BTBuscarProducto.Image = global::LeSoleil_Taller2.Properties.Resources.lupapng;
            this.BTBuscarProducto.Location = new System.Drawing.Point(189, 50);
            this.BTBuscarProducto.Name = "BTBuscarProducto";
            this.BTBuscarProducto.Size = new System.Drawing.Size(45, 26);
            this.BTBuscarProducto.TabIndex = 22;
            this.BTBuscarProducto.UseVisualStyleBackColor = true;
            this.BTBuscarProducto.Click += new System.EventHandler(this.BTBuscarProducto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(703, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Cantidad:";
            // 
            // DUDCantidad
            // 
            this.DUDCantidad.Location = new System.Drawing.Point(706, 50);
            this.DUDCantidad.Name = "DUDCantidad";
            this.DUDCantidad.Size = new System.Drawing.Size(87, 21);
            this.DUDCantidad.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(583, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Stock:";
            // 
            // TBStock
            // 
            this.TBStock.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStock.ForeColor = System.Drawing.Color.Coral;
            this.TBStock.Location = new System.Drawing.Point(586, 50);
            this.TBStock.Multiline = true;
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(103, 25);
            this.TBStock.TabIndex = 24;
            // 
            // TBPrecio
            // 
            this.TBPrecio.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecio.ForeColor = System.Drawing.Color.Coral;
            this.TBPrecio.Location = new System.Drawing.Point(465, 50);
            this.TBPrecio.Multiline = true;
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(103, 25);
            this.TBPrecio.TabIndex = 23;
            this.TBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(462, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Precio:";
            // 
            // TBProducto
            // 
            this.TBProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBProducto.Location = new System.Drawing.Point(240, 50);
            this.TBProducto.Multiline = true;
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(210, 25);
            this.TBProducto.TabIndex = 21;
            // 
            // TBCodigoProducto
            // 
            this.TBCodigoProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBCodigoProducto.Location = new System.Drawing.Point(10, 50);
            this.TBCodigoProducto.Multiline = true;
            this.TBCodigoProducto.Name = "TBCodigoProducto";
            this.TBCodigoProducto.Size = new System.Drawing.Size(173, 25);
            this.TBCodigoProducto.TabIndex = 19;
            this.TBCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBCodigoProducto_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(237, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Codigo de Producto:";
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.BackColor = System.Drawing.Color.Coral;
            this.BAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarProducto.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BAgregarProducto.Location = new System.Drawing.Point(875, 261);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(121, 58);
            this.BAgregarProducto.TabIndex = 57;
            this.BAgregarProducto.Text = "Agregar Producto";
            this.BAgregarProducto.UseVisualStyleBackColor = false;
            this.BAgregarProducto.Click += new System.EventHandler(this.BAgregarProducto_Click);
            // 
            // DGVProductosVenta
            // 
            this.DGVProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Codigo,
            this.nombreProducto,
            this.Precio,
            this.Cantidad,
            this.Subtotal,
            this.BTEliminar});
            this.DGVProductosVenta.Location = new System.Drawing.Point(50, 370);
            this.DGVProductosVenta.Name = "DGVProductosVenta";
            this.DGVProductosVenta.Size = new System.Drawing.Size(689, 202);
            this.DGVProductosVenta.TabIndex = 58;
            this.DGVProductosVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductosVenta_CellClick);
            this.DGVProductosVenta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVProductosVenta_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // Codigo
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // nombreProducto
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.nombreProducto.DefaultCellStyle = dataGridViewCellStyle7;
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Width = 150;
            // 
            // Precio
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle8;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle9;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // BTEliminar
            // 
            this.BTEliminar.HeaderText = "Accion";
            this.BTEliminar.Name = "BTEliminar";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.TBNombreVendedor);
            this.groupBox3.Controls.Add(this.TBIdVendedor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.Color.Brown;
            this.groupBox3.Location = new System.Drawing.Point(692, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(304, 93);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Vendedor";
            // 
            // TBNombreVendedor
            // 
            this.TBNombreVendedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreVendedor.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreVendedor.Location = new System.Drawing.Point(141, 50);
            this.TBNombreVendedor.Multiline = true;
            this.TBNombreVendedor.Name = "TBNombreVendedor";
            this.TBNombreVendedor.Size = new System.Drawing.Size(134, 25);
            this.TBNombreVendedor.TabIndex = 20;
            // 
            // TBIdVendedor
            // 
            this.TBIdVendedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBIdVendedor.ForeColor = System.Drawing.Color.Coral;
            this.TBIdVendedor.Location = new System.Drawing.Point(10, 50);
            this.TBIdVendedor.Multiline = true;
            this.TBIdVendedor.Name = "TBIdVendedor";
            this.TBIdVendedor.Size = new System.Drawing.Size(101, 25);
            this.TBIdVendedor.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(138, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "ID:";
            // 
            // TBPrecioTotal
            // 
            this.TBPrecioTotal.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioTotal.ForeColor = System.Drawing.Color.Coral;
            this.TBPrecioTotal.Location = new System.Drawing.Point(796, 409);
            this.TBPrecioTotal.Multiline = true;
            this.TBPrecioTotal.Name = "TBPrecioTotal";
            this.TBPrecioTotal.Size = new System.Drawing.Size(160, 26);
            this.TBPrecioTotal.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(793, 388);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 41;
            this.label11.Text = "Precio Total:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.TBCambio);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TBPago);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.BAgregarCliente);
            this.panel1.Controls.Add(this.BCancelar);
            this.panel1.Controls.Add(this.BRegistrarVenta);
            this.panel1.Controls.Add(this.TBPrecioTotal);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.DGVProductosVenta);
            this.panel1.Location = new System.Drawing.Point(-1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 761);
            this.panel1.TabIndex = 60;
            // 
            // TBCambio
            // 
            this.TBCambio.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCambio.ForeColor = System.Drawing.Color.Coral;
            this.TBCambio.Location = new System.Drawing.Point(976, 488);
            this.TBCambio.Multiline = true;
            this.TBCambio.Name = "TBCambio";
            this.TBCambio.Size = new System.Drawing.Size(113, 26);
            this.TBCambio.TabIndex = 65;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(973, 467);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 18);
            this.label14.TabIndex = 64;
            this.label14.Text = "Cambio:";
            // 
            // TBPago
            // 
            this.TBPago.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPago.ForeColor = System.Drawing.Color.Coral;
            this.TBPago.Location = new System.Drawing.Point(796, 488);
            this.TBPago.Multiline = true;
            this.TBPago.Name = "TBPago";
            this.TBPago.Size = new System.Drawing.Size(160, 26);
            this.TBPago.TabIndex = 63;
            this.TBPago.TextChanged += new System.EventHandler(this.TBPago_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(793, 467);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 62;
            this.label13.Text = "Paga con:";
            // 
            // BAgregarCliente
            // 
            this.BAgregarCliente.BackColor = System.Drawing.Color.Coral;
            this.BAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarCliente.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BAgregarCliente.Location = new System.Drawing.Point(1024, 157);
            this.BAgregarCliente.Name = "BAgregarCliente";
            this.BAgregarCliente.Size = new System.Drawing.Size(121, 58);
            this.BAgregarCliente.TabIndex = 61;
            this.BAgregarCliente.Text = "Agregar Cliente";
            this.BAgregarCliente.UseVisualStyleBackColor = false;
            this.BAgregarCliente.Click += new System.EventHandler(this.BAgregarCliente_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Brown;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelar.Location = new System.Drawing.Point(976, 532);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(113, 40);
            this.BCancelar.TabIndex = 61;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BRegistrarVenta
            // 
            this.BRegistrarVenta.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegistrarVenta.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BRegistrarVenta.Location = new System.Drawing.Point(796, 532);
            this.BRegistrarVenta.Name = "BRegistrarVenta";
            this.BRegistrarVenta.Size = new System.Drawing.Size(160, 40);
            this.BRegistrarVenta.TabIndex = 60;
            this.BRegistrarVenta.Text = "Registrar Venta";
            this.BRegistrarVenta.UseVisualStyleBackColor = false;
            this.BRegistrarVenta.Click += new System.EventHandler(this.BRegistrarVenta_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BAgregarProducto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LUsers);
            this.Controls.Add(this.GBInfoCliente);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.GBInfoCliente.ResumeLayout(false);
            this.GBInfoCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductosVenta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBInfoCliente;
        private System.Windows.Forms.Label LUsers;
        private System.Windows.Forms.Label LDNIUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNombreCliente;
        private System.Windows.Forms.TextBox TBDniCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBFechaActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBTipoFactura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBProducto;
        private System.Windows.Forms.TextBox TBCodigoProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown DUDCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BAgregarProducto;
        private System.Windows.Forms.Button BTBuscarCliente;
        private System.Windows.Forms.Button BTBuscarProducto;
        private System.Windows.Forms.DataGridView DGVProductosVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TBIdVendedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBNombreVendedor;
        private System.Windows.Forms.TextBox TBPrecioTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BRegistrarVenta;
        private System.Windows.Forms.Button BAgregarCliente;
        private System.Windows.Forms.TextBox TBApellidoCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LId_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTEliminar;
        private System.Windows.Forms.Label LId_cliente;
        private System.Windows.Forms.TextBox TBPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBCambio;
        private System.Windows.Forms.Label label14;
    }
}