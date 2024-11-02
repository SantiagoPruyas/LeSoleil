namespace LeSoleil_Taller2
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.LFondoProductos = new System.Windows.Forms.Label();
            this.TBNombreProducto = new System.Windows.Forms.TextBox();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.TBPrecioCompra = new System.Windows.Forms.TextBox();
            this.LPrecioProducto = new System.Windows.Forms.Label();
            this.TBStockProducto = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.TBTelaProducto = new System.Windows.Forms.TextBox();
            this.LTelaProducto = new System.Windows.Forms.Label();
            this.LProductos = new System.Windows.Forms.Label();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenProducto = new System.Windows.Forms.DataGridViewImageColumn();
            this.editarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LPrecioVenta = new System.Windows.Forms.Label();
            this.TBPrecioVenta = new System.Windows.Forms.TextBox();
            this.LStockMin = new System.Windows.Forms.Label();
            this.TBStockMin = new System.Windows.Forms.TextBox();
            this.CBCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.LCategoriaProducto = new System.Windows.Forms.Label();
            this.TBImagenProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BGuardarProducto = new System.Windows.Forms.Button();
            this.BCancelarProducto = new System.Windows.Forms.Button();
            this.BSeleccionarImagen = new System.Windows.Forms.Button();
            this.BInactivosUsers = new System.Windows.Forms.Button();
            this.BActivosUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LFondoProductos
            // 
            this.LFondoProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoProductos.Location = new System.Drawing.Point(-9, -6);
            this.LFondoProductos.Name = "LFondoProductos";
            this.LFondoProductos.Size = new System.Drawing.Size(1293, 332);
            this.LFondoProductos.TabIndex = 29;
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreProducto.Location = new System.Drawing.Point(327, 53);
            this.TBNombreProducto.Multiline = true;
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.Size = new System.Drawing.Size(134, 25);
            this.TBNombreProducto.TabIndex = 30;
            this.TBNombreProducto.Leave += new System.EventHandler(this.TBNombreProducto_Leave);
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.LNombreProducto.Location = new System.Drawing.Point(325, 23);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(139, 18);
            this.LNombreProducto.TabIndex = 31;
            this.LNombreProducto.Text = "Nombre del Producto";
            // 
            // TBPrecioCompra
            // 
            this.TBPrecioCompra.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioCompra.ForeColor = System.Drawing.Color.Coral;
            this.TBPrecioCompra.Location = new System.Drawing.Point(327, 119);
            this.TBPrecioCompra.Multiline = true;
            this.TBPrecioCompra.Name = "TBPrecioCompra";
            this.TBPrecioCompra.Size = new System.Drawing.Size(134, 23);
            this.TBPrecioCompra.TabIndex = 32;
            this.TBPrecioCompra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBPrecioCompra.Leave += new System.EventHandler(this.TBPrecioCompra_Leave);
            // 
            // LPrecioProducto
            // 
            this.LPrecioProducto.AutoSize = true;
            this.LPrecioProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPrecioProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioProducto.ForeColor = System.Drawing.Color.Black;
            this.LPrecioProducto.Location = new System.Drawing.Point(323, 94);
            this.LPrecioProducto.Name = "LPrecioProducto";
            this.LPrecioProducto.Size = new System.Drawing.Size(98, 18);
            this.LPrecioProducto.TabIndex = 33;
            this.LPrecioProducto.Text = "Precio Compra";
            // 
            // TBStockProducto
            // 
            this.TBStockProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBStockProducto.Location = new System.Drawing.Point(326, 182);
            this.TBStockProducto.Multiline = true;
            this.TBStockProducto.Name = "TBStockProducto";
            this.TBStockProducto.Size = new System.Drawing.Size(134, 23);
            this.TBStockProducto.TabIndex = 34;
            this.TBStockProducto.Leave += new System.EventHandler(this.TBStockProducto_Leave);
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LStock.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.ForeColor = System.Drawing.Color.Black;
            this.LStock.Location = new System.Drawing.Point(325, 157);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(41, 18);
            this.LStock.TabIndex = 35;
            this.LStock.Text = "Stock";
            // 
            // TBTelaProducto
            // 
            this.TBTelaProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelaProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBTelaProducto.Location = new System.Drawing.Point(503, 53);
            this.TBTelaProducto.Multiline = true;
            this.TBTelaProducto.Name = "TBTelaProducto";
            this.TBTelaProducto.Size = new System.Drawing.Size(472, 23);
            this.TBTelaProducto.TabIndex = 41;
            this.TBTelaProducto.Text = "Ej: Tipo de tela";
            this.TBTelaProducto.Leave += new System.EventHandler(this.TBTelaProducto_Leave);
            // 
            // LTelaProducto
            // 
            this.LTelaProducto.AutoSize = true;
            this.LTelaProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelaProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelaProducto.ForeColor = System.Drawing.Color.Black;
            this.LTelaProducto.Location = new System.Drawing.Point(500, 23);
            this.LTelaProducto.Name = "LTelaProducto";
            this.LTelaProducto.Size = new System.Drawing.Size(80, 18);
            this.LTelaProducto.TabIndex = 42;
            this.LTelaProducto.Text = "Descripcion";
            // 
            // LProductos
            // 
            this.LProductos.AutoSize = true;
            this.LProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LProductos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductos.ForeColor = System.Drawing.Color.Coral;
            this.LProductos.Location = new System.Drawing.Point(39, 32);
            this.LProductos.Name = "LProductos";
            this.LProductos.Size = new System.Drawing.Size(148, 29);
            this.LProductos.TabIndex = 43;
            this.LProductos.Text = "PRODUCTOS";
            this.LProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.nombreProducto,
            this.stockProducto,
            this.stockMinimo,
            this.precioCompra,
            this.precioVenta,
            this.descripcionProducto,
            this.categoriaProducto,
            this.imagenProducto,
            this.editarProducto,
            this.eliminarProducto});
            this.DGVProductos.Location = new System.Drawing.Point(64, 378);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.Size = new System.Drawing.Size(1138, 236);
            this.DGVProductos.TabIndex = 46;
            this.DGVProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVProductos_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID Producto";
            this.IdProducto.Name = "IdProducto";
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            // 
            // stockProducto
            // 
            this.stockProducto.HeaderText = "Stock";
            this.stockProducto.Name = "stockProducto";
            // 
            // stockMinimo
            // 
            this.stockMinimo.HeaderText = "Stock Minimo";
            this.stockMinimo.Name = "stockMinimo";
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.Name = "precioCompra";
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.HeaderText = "Descripcion";
            this.descripcionProducto.Name = "descripcionProducto";
            // 
            // categoriaProducto
            // 
            this.categoriaProducto.HeaderText = "Categoria";
            this.categoriaProducto.Name = "categoriaProducto";
            // 
            // imagenProducto
            // 
            this.imagenProducto.HeaderText = "Imagen";
            this.imagenProducto.Name = "imagenProducto";
            // 
            // editarProducto
            // 
            this.editarProducto.HeaderText = "Editar";
            this.editarProducto.Name = "editarProducto";
            // 
            // eliminarProducto
            // 
            this.eliminarProducto.HeaderText = "Dar de Baja";
            this.eliminarProducto.Name = "eliminarProducto";
            this.eliminarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminarProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LPrecioVenta
            // 
            this.LPrecioVenta.AutoSize = true;
            this.LPrecioVenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPrecioVenta.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.LPrecioVenta.Location = new System.Drawing.Point(501, 94);
            this.LPrecioVenta.Name = "LPrecioVenta";
            this.LPrecioVenta.Size = new System.Drawing.Size(85, 18);
            this.LPrecioVenta.TabIndex = 49;
            this.LPrecioVenta.Text = "Precio Venta";
            // 
            // TBPrecioVenta
            // 
            this.TBPrecioVenta.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioVenta.ForeColor = System.Drawing.Color.Coral;
            this.TBPrecioVenta.Location = new System.Drawing.Point(503, 119);
            this.TBPrecioVenta.Multiline = true;
            this.TBPrecioVenta.Name = "TBPrecioVenta";
            this.TBPrecioVenta.Size = new System.Drawing.Size(134, 23);
            this.TBPrecioVenta.TabIndex = 48;
            this.TBPrecioVenta.Leave += new System.EventHandler(this.TBPrecioVenta_Leave);
            // 
            // LStockMin
            // 
            this.LStockMin.AutoSize = true;
            this.LStockMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LStockMin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStockMin.ForeColor = System.Drawing.Color.Black;
            this.LStockMin.Location = new System.Drawing.Point(503, 157);
            this.LStockMin.Name = "LStockMin";
            this.LStockMin.Size = new System.Drawing.Size(89, 18);
            this.LStockMin.TabIndex = 51;
            this.LStockMin.Text = "Stock Minimo";
            // 
            // TBStockMin
            // 
            this.TBStockMin.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockMin.ForeColor = System.Drawing.Color.Coral;
            this.TBStockMin.Location = new System.Drawing.Point(503, 182);
            this.TBStockMin.Multiline = true;
            this.TBStockMin.Name = "TBStockMin";
            this.TBStockMin.Size = new System.Drawing.Size(134, 23);
            this.TBStockMin.TabIndex = 50;
            this.TBStockMin.Leave += new System.EventHandler(this.TBStockMin_Leave);
            // 
            // CBCategoriaProducto
            // 
            this.CBCategoriaProducto.FormattingEnabled = true;
            this.CBCategoriaProducto.Items.AddRange(new object[] {
            "Abrigos",
            "Pantalones",
            "Remeras",
            "Vestidos",
            "Shorts",
            "Blusas",
            "Accesorios"});
            this.CBCategoriaProducto.Location = new System.Drawing.Point(841, 180);
            this.CBCategoriaProducto.Name = "CBCategoriaProducto";
            this.CBCategoriaProducto.Size = new System.Drawing.Size(134, 21);
            this.CBCategoriaProducto.TabIndex = 52;
            this.CBCategoriaProducto.Leave += new System.EventHandler(this.CBCategoriaProducto_Leave);
            // 
            // LCategoriaProducto
            // 
            this.LCategoriaProducto.AutoSize = true;
            this.LCategoriaProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCategoriaProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoriaProducto.ForeColor = System.Drawing.Color.Black;
            this.LCategoriaProducto.Location = new System.Drawing.Point(838, 157);
            this.LCategoriaProducto.Name = "LCategoriaProducto";
            this.LCategoriaProducto.Size = new System.Drawing.Size(66, 18);
            this.LCategoriaProducto.TabIndex = 53;
            this.LCategoriaProducto.Text = "Categoria";
            // 
            // TBImagenProducto
            // 
            this.TBImagenProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBImagenProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBImagenProducto.Location = new System.Drawing.Point(671, 119);
            this.TBImagenProducto.Multiline = true;
            this.TBImagenProducto.Name = "TBImagenProducto";
            this.TBImagenProducto.Size = new System.Drawing.Size(304, 23);
            this.TBImagenProducto.TabIndex = 54;
            this.TBImagenProducto.Leave += new System.EventHandler(this.TBImagenProducto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(670, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Imagen";
            // 
            // BGuardarProducto
            // 
            this.BGuardarProducto.BackColor = System.Drawing.Color.Coral;
            this.BGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarProducto.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardarProducto.Location = new System.Drawing.Point(326, 241);
            this.BGuardarProducto.Name = "BGuardarProducto";
            this.BGuardarProducto.Size = new System.Drawing.Size(94, 38);
            this.BGuardarProducto.TabIndex = 56;
            this.BGuardarProducto.Text = "Guardar";
            this.BGuardarProducto.UseVisualStyleBackColor = false;
            this.BGuardarProducto.Click += new System.EventHandler(this.BGuardarProducto_Click);
            // 
            // BCancelarProducto
            // 
            this.BCancelarProducto.BackColor = System.Drawing.Color.Coral;
            this.BCancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelarProducto.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelarProducto.Location = new System.Drawing.Point(444, 241);
            this.BCancelarProducto.Name = "BCancelarProducto";
            this.BCancelarProducto.Size = new System.Drawing.Size(94, 38);
            this.BCancelarProducto.TabIndex = 57;
            this.BCancelarProducto.Text = "Cancelar";
            this.BCancelarProducto.UseVisualStyleBackColor = false;
            this.BCancelarProducto.Click += new System.EventHandler(this.BCancelarProducto_Click);
            // 
            // BSeleccionarImagen
            // 
            this.BSeleccionarImagen.BackColor = System.Drawing.Color.Coral;
            this.BSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSeleccionarImagen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSeleccionarImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BSeleccionarImagen.Location = new System.Drawing.Point(990, 109);
            this.BSeleccionarImagen.Name = "BSeleccionarImagen";
            this.BSeleccionarImagen.Size = new System.Drawing.Size(167, 38);
            this.BSeleccionarImagen.TabIndex = 58;
            this.BSeleccionarImagen.Text = "Seleccionar Imagen";
            this.BSeleccionarImagen.UseVisualStyleBackColor = false;
            this.BSeleccionarImagen.Click += new System.EventHandler(this.BSeleccionarImagen_Click);
            // 
            // BInactivosUsers
            // 
            this.BInactivosUsers.BackColor = System.Drawing.Color.Brown;
            this.BInactivosUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInactivosUsers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInactivosUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BInactivosUsers.Location = new System.Drawing.Point(1028, 329);
            this.BInactivosUsers.Name = "BInactivosUsers";
            this.BInactivosUsers.Size = new System.Drawing.Size(174, 41);
            this.BInactivosUsers.TabIndex = 59;
            this.BInactivosUsers.Text = "Productos Inactivos";
            this.BInactivosUsers.UseVisualStyleBackColor = false;
            // 
            // BActivosUser
            // 
            this.BActivosUser.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BActivosUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BActivosUser.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActivosUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BActivosUser.Location = new System.Drawing.Point(64, 329);
            this.BActivosUser.Name = "BActivosUser";
            this.BActivosUser.Size = new System.Drawing.Size(166, 41);
            this.BActivosUser.TabIndex = 60;
            this.BActivosUser.Text = "Productos Activos";
            this.BActivosUser.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1293, 383);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // TBCodigoProducto
            // 
            this.TBCodigoProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBCodigoProducto.Location = new System.Drawing.Point(671, 180);
            this.TBCodigoProducto.Multiline = true;
            this.TBCodigoProducto.Name = "TBCodigoProducto";
            this.TBCodigoProducto.Size = new System.Drawing.Size(134, 25);
            this.TBCodigoProducto.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(670, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Codigo";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBCodigoProducto);
            this.Controls.Add(this.BActivosUser);
            this.Controls.Add(this.BInactivosUsers);
            this.Controls.Add(this.BSeleccionarImagen);
            this.Controls.Add(this.BCancelarProducto);
            this.Controls.Add(this.BGuardarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBImagenProducto);
            this.Controls.Add(this.LCategoriaProducto);
            this.Controls.Add(this.CBCategoriaProducto);
            this.Controls.Add(this.LStockMin);
            this.Controls.Add(this.TBStockMin);
            this.Controls.Add(this.LPrecioVenta);
            this.Controls.Add(this.TBPrecioVenta);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.LProductos);
            this.Controls.Add(this.LTelaProducto);
            this.Controls.Add(this.TBTelaProducto);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.TBStockProducto);
            this.Controls.Add(this.LPrecioProducto);
            this.Controls.Add(this.TBPrecioCompra);
            this.Controls.Add(this.LNombreProducto);
            this.Controls.Add(this.TBNombreProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LFondoProductos);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFondoProductos;
        private System.Windows.Forms.TextBox TBNombreProducto;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.TextBox TBPrecioCompra;
        private System.Windows.Forms.Label LPrecioProducto;
        private System.Windows.Forms.TextBox TBStockProducto;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.TextBox TBTelaProducto;
        private System.Windows.Forms.Label LTelaProducto;
        private System.Windows.Forms.Label LProductos;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LPrecioVenta;
        private System.Windows.Forms.TextBox TBPrecioVenta;
        private System.Windows.Forms.Label LStockMin;
        private System.Windows.Forms.TextBox TBStockMin;
        private System.Windows.Forms.ComboBox CBCategoriaProducto;
        private System.Windows.Forms.Label LCategoriaProducto;
        private System.Windows.Forms.TextBox TBImagenProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BGuardarProducto;
        private System.Windows.Forms.Button BCancelarProducto;
        private System.Windows.Forms.Button BSeleccionarImagen;
        private System.Windows.Forms.Button BInactivosUsers;
        private System.Windows.Forms.Button BActivosUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProducto;
        private System.Windows.Forms.DataGridViewImageColumn imagenProducto;
        private System.Windows.Forms.DataGridViewButtonColumn editarProducto;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarProducto;
        private System.Windows.Forms.TextBox TBCodigoProducto;
        private System.Windows.Forms.Label label2;
    }
}