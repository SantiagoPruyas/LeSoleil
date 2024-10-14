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
            this.TBPrecioProducto = new System.Windows.Forms.TextBox();
            this.LPrecioProducto = new System.Windows.Forms.Label();
            this.TBStockProducto = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.DUDCantidad = new System.Windows.Forms.DomainUpDown();
            this.TBTelaProducto = new System.Windows.Forms.TextBox();
            this.LTelaProducto = new System.Windows.Forms.Label();
            this.LProductos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LPrecioVenta = new System.Windows.Forms.Label();
            this.TBPrecioVenta = new System.Windows.Forms.TextBox();
            this.LStockMin = new System.Windows.Forms.Label();
            this.TBStockMin = new System.Windows.Forms.TextBox();
            this.CBCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.LCategoriaProducto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BGuardarProducto = new System.Windows.Forms.Button();
            this.BCancelarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LFondoProductos
            // 
            this.LFondoProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoProductos.Location = new System.Drawing.Point(-6, -7);
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
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.LNombreProducto.Location = new System.Drawing.Point(325, 23);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(64, 18);
            this.LNombreProducto.TabIndex = 31;
            this.LNombreProducto.Text = "Producto";
            // 
            // TBPrecioProducto
            // 
            this.TBPrecioProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBPrecioProducto.Location = new System.Drawing.Point(327, 119);
            this.TBPrecioProducto.Multiline = true;
            this.TBPrecioProducto.Name = "TBPrecioProducto";
            this.TBPrecioProducto.Size = new System.Drawing.Size(134, 23);
            this.TBPrecioProducto.TabIndex = 32;
            this.TBPrecioProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LPrecioProducto
            // 
            this.LPrecioProducto.AutoSize = true;
            this.LPrecioProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPrecioProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioProducto.ForeColor = System.Drawing.Color.Black;
            this.LPrecioProducto.Location = new System.Drawing.Point(323, 94);
            this.LPrecioProducto.Name = "LPrecioProducto";
            this.LPrecioProducto.Size = new System.Drawing.Size(85, 18);
            this.LPrecioProducto.TabIndex = 33;
            this.LPrecioProducto.Text = "Precio Venta";
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
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LStock.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.ForeColor = System.Drawing.Color.Black;
            this.LStock.Location = new System.Drawing.Point(328, 157);
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
            this.LCantidad.Location = new System.Drawing.Point(687, 157);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(63, 18);
            this.LCantidad.TabIndex = 36;
            this.LCantidad.Text = "Cantidad";
            // 
            // DUDCantidad
            // 
            this.DUDCantidad.Location = new System.Drawing.Point(690, 185);
            this.DUDCantidad.Name = "DUDCantidad";
            this.DUDCantidad.Size = new System.Drawing.Size(60, 20);
            this.DUDCantidad.TabIndex = 38;
            // 
            // TBTelaProducto
            // 
            this.TBTelaProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelaProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBTelaProducto.Location = new System.Drawing.Point(503, 53);
            this.TBTelaProducto.Multiline = true;
            this.TBTelaProducto.Name = "TBTelaProducto";
            this.TBTelaProducto.Size = new System.Drawing.Size(134, 23);
            this.TBTelaProducto.TabIndex = 41;
            // 
            // LTelaProducto
            // 
            this.LTelaProducto.AutoSize = true;
            this.LTelaProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelaProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelaProducto.ForeColor = System.Drawing.Color.Black;
            this.LTelaProducto.Location = new System.Drawing.Point(500, 23);
            this.LTelaProducto.Name = "LTelaProducto";
            this.LTelaProducto.Size = new System.Drawing.Size(33, 18);
            this.LTelaProducto.TabIndex = 42;
            this.LTelaProducto.Text = "Tela";
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
            this.dataGridView1.Location = new System.Drawing.Point(326, 392);
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
            this.pictureBox1.Size = new System.Drawing.Size(1293, 383);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
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
            this.CBCategoriaProducto.Location = new System.Drawing.Point(688, 119);
            this.CBCategoriaProducto.Name = "CBCategoriaProducto";
            this.CBCategoriaProducto.Size = new System.Drawing.Size(134, 21);
            this.CBCategoriaProducto.TabIndex = 52;
            // 
            // LCategoriaProducto
            // 
            this.LCategoriaProducto.AutoSize = true;
            this.LCategoriaProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCategoriaProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoriaProducto.ForeColor = System.Drawing.Color.Black;
            this.LCategoriaProducto.Location = new System.Drawing.Point(687, 94);
            this.LCategoriaProducto.Name = "LCategoriaProducto";
            this.LCategoriaProducto.Size = new System.Drawing.Size(66, 18);
            this.LCategoriaProducto.TabIndex = 53;
            this.LCategoriaProducto.Text = "Categoria";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Coral;
            this.textBox1.Location = new System.Drawing.Point(688, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 23);
            this.textBox1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(686, 23);
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
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.BCancelarProducto);
            this.Controls.Add(this.BGuardarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LCategoriaProducto);
            this.Controls.Add(this.CBCategoriaProducto);
            this.Controls.Add(this.LStockMin);
            this.Controls.Add(this.TBStockMin);
            this.Controls.Add(this.LPrecioVenta);
            this.Controls.Add(this.TBPrecioVenta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LProductos);
            this.Controls.Add(this.LTelaProducto);
            this.Controls.Add(this.TBTelaProducto);
            this.Controls.Add(this.DUDCantidad);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.TBStockProducto);
            this.Controls.Add(this.LPrecioProducto);
            this.Controls.Add(this.TBPrecioProducto);
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
        private System.Windows.Forms.TextBox TBPrecioProducto;
        private System.Windows.Forms.Label LPrecioProducto;
        private System.Windows.Forms.TextBox TBStockProducto;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.DomainUpDown DUDCantidad;
        private System.Windows.Forms.TextBox TBTelaProducto;
        private System.Windows.Forms.Label LTelaProducto;
        private System.Windows.Forms.Label LProductos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LPrecioVenta;
        private System.Windows.Forms.TextBox TBPrecioVenta;
        private System.Windows.Forms.Label LStockMin;
        private System.Windows.Forms.TextBox TBStockMin;
        private System.Windows.Forms.ComboBox CBCategoriaProducto;
        private System.Windows.Forms.Label LCategoriaProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BGuardarProducto;
        private System.Windows.Forms.Button BCancelarProducto;
    }
}