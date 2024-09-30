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
            this.TBPrecioVenta = new System.Windows.Forms.TextBox();
            this.LPrecioVenta = new System.Windows.Forms.Label();
            this.TBStockProducto = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.DUDCantidad = new System.Windows.Forms.DomainUpDown();
            this.BBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.LDescripcionProducto = new System.Windows.Forms.Label();
            this.LProductos = new System.Windows.Forms.Label();
            this.BGuardarProducto = new FontAwesome.Sharp.IconButton();
            this.BCancelarProducto = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BActivosProductos = new FontAwesome.Sharp.IconButton();
            this.BInactivosProductos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LFondoProductos
            // 
            this.LFondoProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoProductos.Location = new System.Drawing.Point(-9, -5);
            this.LFondoProductos.Name = "LFondoProductos";
            this.LFondoProductos.Size = new System.Drawing.Size(813, 334);
            this.LFondoProductos.TabIndex = 29;
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreProducto.Location = new System.Drawing.Point(37, 78);
            this.TBNombreProducto.Multiline = true;
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.Size = new System.Drawing.Size(134, 25);
            this.TBNombreProducto.TabIndex = 30;
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.LNombreProducto.Location = new System.Drawing.Point(37, 52);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(64, 18);
            this.LNombreProducto.TabIndex = 31;
            this.LNombreProducto.Text = "Producto";
            // 
            // TBPrecioVenta
            // 
            this.TBPrecioVenta.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioVenta.ForeColor = System.Drawing.Color.Coral;
            this.TBPrecioVenta.Location = new System.Drawing.Point(39, 139);
            this.TBPrecioVenta.Multiline = true;
            this.TBPrecioVenta.Name = "TBPrecioVenta";
            this.TBPrecioVenta.Size = new System.Drawing.Size(134, 23);
            this.TBPrecioVenta.TabIndex = 32;
            this.TBPrecioVenta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LPrecioVenta
            // 
            this.LPrecioVenta.AutoSize = true;
            this.LPrecioVenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPrecioVenta.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.LPrecioVenta.Location = new System.Drawing.Point(37, 114);
            this.LPrecioVenta.Name = "LPrecioVenta";
            this.LPrecioVenta.Size = new System.Drawing.Size(85, 18);
            this.LPrecioVenta.TabIndex = 33;
            this.LPrecioVenta.Text = "Precio Venta";
            // 
            // TBStockProducto
            // 
            this.TBStockProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBStockProducto.Location = new System.Drawing.Point(190, 139);
            this.TBStockProducto.Multiline = true;
            this.TBStockProducto.Name = "TBStockProducto";
            this.TBStockProducto.Size = new System.Drawing.Size(134, 23);
            this.TBStockProducto.TabIndex = 34;
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LStock.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.ForeColor = System.Drawing.Color.Black;
            this.LStock.Location = new System.Drawing.Point(187, 114);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(41, 18);
            this.LStock.TabIndex = 35;
            this.LStock.Text = "Stock";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCantidad.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.ForeColor = System.Drawing.Color.Black;
            this.LCantidad.Location = new System.Drawing.Point(337, 114);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(63, 18);
            this.LCantidad.TabIndex = 36;
            this.LCantidad.Text = "Cantidad";
            // 
            // DUDCantidad
            // 
            this.DUDCantidad.Location = new System.Drawing.Point(340, 142);
            this.DUDCantidad.Name = "DUDCantidad";
            this.DUDCantidad.Size = new System.Drawing.Size(60, 20);
            this.DUDCantidad.TabIndex = 38;
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.BackColor = System.Drawing.Color.Coral;
            this.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.BBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BBuscarProducto.Location = new System.Drawing.Point(190, 78);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(85, 25);
            this.BBuscarProducto.TabIndex = 40;
            this.BBuscarProducto.Text = "Buscar";
            this.BBuscarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.ForeColor = System.Drawing.Color.Coral;
            this.TBDescripcion.Location = new System.Drawing.Point(40, 196);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(360, 23);
            this.TBDescripcion.TabIndex = 41;
            // 
            // LDescripcionProducto
            // 
            this.LDescripcionProducto.AutoSize = true;
            this.LDescripcionProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDescripcionProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcionProducto.ForeColor = System.Drawing.Color.Black;
            this.LDescripcionProducto.Location = new System.Drawing.Point(38, 172);
            this.LDescripcionProducto.Name = "LDescripcionProducto";
            this.LDescripcionProducto.Size = new System.Drawing.Size(80, 18);
            this.LDescripcionProducto.TabIndex = 42;
            this.LDescripcionProducto.Text = "Descripcion";
            // 
            // LProductos
            // 
            this.LProductos.AutoSize = true;
            this.LProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LProductos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductos.ForeColor = System.Drawing.Color.Coral;
            this.LProductos.Location = new System.Drawing.Point(321, 20);
            this.LProductos.Name = "LProductos";
            this.LProductos.Size = new System.Drawing.Size(148, 29);
            this.LProductos.TabIndex = 43;
            this.LProductos.Text = "PRODUCTOS";
            this.LProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BGuardarProducto
            // 
            this.BGuardarProducto.BackColor = System.Drawing.Color.Coral;
            this.BGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarProducto.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BGuardarProducto.IconColor = System.Drawing.Color.Black;
            this.BGuardarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardarProducto.Location = new System.Drawing.Point(39, 254);
            this.BGuardarProducto.Name = "BGuardarProducto";
            this.BGuardarProducto.Size = new System.Drawing.Size(94, 41);
            this.BGuardarProducto.TabIndex = 44;
            this.BGuardarProducto.Text = "Guardar";
            this.BGuardarProducto.UseVisualStyleBackColor = false;
            // 
            // BCancelarProducto
            // 
            this.BCancelarProducto.BackColor = System.Drawing.Color.Coral;
            this.BCancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelarProducto.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BCancelarProducto.IconColor = System.Drawing.Color.Black;
            this.BCancelarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCancelarProducto.Location = new System.Drawing.Point(155, 254);
            this.BCancelarProducto.Name = "BCancelarProducto";
            this.BCancelarProducto.Size = new System.Drawing.Size(94, 41);
            this.BCancelarProducto.TabIndex = 45;
            this.BCancelarProducto.Text = "Cancelar";
            this.BCancelarProducto.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.nombre,
            this.cantidad,
            this.subtotal,
            this.descripcion,
            this.eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(69, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 212);
            this.dataGridView1.TabIndex = 46;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID Producto";
            this.IdProducto.Name = "IdProducto";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "eliminar";
            this.eliminar.Name = "eliminar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 280);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // BActivosProductos
            // 
            this.BActivosProductos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BActivosProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BActivosProductos.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActivosProductos.ForeColor = System.Drawing.Color.FloralWhite;
            this.BActivosProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BActivosProductos.IconColor = System.Drawing.Color.Black;
            this.BActivosProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BActivosProductos.Location = new System.Drawing.Point(69, 332);
            this.BActivosProductos.Name = "BActivosProductos";
            this.BActivosProductos.Size = new System.Drawing.Size(147, 29);
            this.BActivosProductos.TabIndex = 48;
            this.BActivosProductos.Text = "Productos Activos";
            this.BActivosProductos.UseVisualStyleBackColor = false;
            // 
            // BInactivosProductos
            // 
            this.BInactivosProductos.BackColor = System.Drawing.Color.DarkRed;
            this.BInactivosProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInactivosProductos.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInactivosProductos.ForeColor = System.Drawing.Color.FloralWhite;
            this.BInactivosProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BInactivosProductos.IconColor = System.Drawing.Color.Black;
            this.BInactivosProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BInactivosProductos.Location = new System.Drawing.Point(540, 332);
            this.BInactivosProductos.Name = "BInactivosProductos";
            this.BInactivosProductos.Size = new System.Drawing.Size(169, 29);
            this.BInactivosProductos.TabIndex = 49;
            this.BInactivosProductos.Text = "Productos Inactivos";
            this.BInactivosProductos.UseVisualStyleBackColor = false;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.BInactivosProductos);
            this.Controls.Add(this.BActivosProductos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BCancelarProducto);
            this.Controls.Add(this.BGuardarProducto);
            this.Controls.Add(this.LProductos);
            this.Controls.Add(this.LDescripcionProducto);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.BBuscarProducto);
            this.Controls.Add(this.DUDCantidad);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.TBStockProducto);
            this.Controls.Add(this.LPrecioVenta);
            this.Controls.Add(this.TBPrecioVenta);
            this.Controls.Add(this.LNombreProducto);
            this.Controls.Add(this.TBNombreProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LFondoProductos);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFondoProductos;
        private System.Windows.Forms.TextBox TBNombreProducto;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.TextBox TBPrecioVenta;
        private System.Windows.Forms.Label LPrecioVenta;
        private System.Windows.Forms.TextBox TBStockProducto;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.DomainUpDown DUDCantidad;
        private FontAwesome.Sharp.IconButton BBuscarProducto;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label LDescripcionProducto;
        private System.Windows.Forms.Label LProductos;
        private FontAwesome.Sharp.IconButton BGuardarProducto;
        private FontAwesome.Sharp.IconButton BCancelarProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BActivosProductos;
        private FontAwesome.Sharp.IconButton BInactivosProductos;
    }
}