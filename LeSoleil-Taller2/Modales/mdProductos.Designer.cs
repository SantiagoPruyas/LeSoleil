namespace LeSoleil_Taller2.Modales
{
    partial class mdProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdProductos));
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.LProductos = new System.Windows.Forms.Label();
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.BTBuscarProducto = new System.Windows.Forms.Button();
            this.TBusquedaProducto = new System.Windows.Forms.TextBox();
            this.CBBusquedaProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenProducto = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProductos
            // 
            this.DGVProductos.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Codigo,
            this.Nombre,
            this.Stock,
            this.stockMinimo,
            this.Precio,
            this.categoriaProducto,
            this.imagenProducto});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVProductos.DefaultCellStyle = dataGridViewCellStyle30;
            this.DGVProductos.Location = new System.Drawing.Point(12, 140);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.RowTemplate.Height = 70;
            this.DGVProductos.Size = new System.Drawing.Size(921, 298);
            this.DGVProductos.TabIndex = 47;
            this.DGVProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellDoubleClick);
            // 
            // LProductos
            // 
            this.LProductos.AutoSize = true;
            this.LProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LProductos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductos.ForeColor = System.Drawing.Color.Coral;
            this.LProductos.Location = new System.Drawing.Point(41, 25);
            this.LProductos.Name = "LProductos";
            this.LProductos.Size = new System.Drawing.Size(250, 29);
            this.LProductos.TabIndex = 48;
            this.LProductos.Text = "LISTA DE PRODUCTOS";
            this.LProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Image = global::LeSoleil_Taller2.Properties.Resources.escobapng;
            this.BTLimpiar.Location = new System.Drawing.Point(893, 95);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(31, 28);
            this.BTLimpiar.TabIndex = 67;
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // BTBuscarProducto
            // 
            this.BTBuscarProducto.Image = global::LeSoleil_Taller2.Properties.Resources.lupapng;
            this.BTBuscarProducto.Location = new System.Drawing.Point(856, 95);
            this.BTBuscarProducto.Name = "BTBuscarProducto";
            this.BTBuscarProducto.Size = new System.Drawing.Size(31, 28);
            this.BTBuscarProducto.TabIndex = 66;
            this.BTBuscarProducto.UseVisualStyleBackColor = true;
            this.BTBuscarProducto.Click += new System.EventHandler(this.BTBuscarProducto_Click);
            // 
            // TBusquedaProducto
            // 
            this.TBusquedaProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusquedaProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBusquedaProducto.Location = new System.Drawing.Point(649, 99);
            this.TBusquedaProducto.Multiline = true;
            this.TBusquedaProducto.Name = "TBusquedaProducto";
            this.TBusquedaProducto.Size = new System.Drawing.Size(201, 21);
            this.TBusquedaProducto.TabIndex = 65;
            // 
            // CBBusquedaProducto
            // 
            this.CBBusquedaProducto.FormattingEnabled = true;
            this.CBBusquedaProducto.Location = new System.Drawing.Point(514, 100);
            this.CBBusquedaProducto.Name = "CBBusquedaProducto";
            this.CBBusquedaProducto.Size = new System.Drawing.Size(129, 21);
            this.CBBusquedaProducto.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Buscar por:";
            // 
            // IdProducto
            // 
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            this.IdProducto.DefaultCellStyle = dataGridViewCellStyle22;
            this.IdProducto.HeaderText = "ID Producto";
            this.IdProducto.Name = "IdProducto";
            // 
            // Codigo
            // 
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle23;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle24;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Stock
            // 
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            this.Stock.DefaultCellStyle = dataGridViewCellStyle25;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // stockMinimo
            // 
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            this.stockMinimo.DefaultCellStyle = dataGridViewCellStyle26;
            this.stockMinimo.HeaderText = "Stock Minimo";
            this.stockMinimo.Name = "stockMinimo";
            // 
            // Precio
            // 
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle27;
            this.Precio.HeaderText = "Precio Venta";
            this.Precio.Name = "Precio";
            // 
            // categoriaProducto
            // 
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            this.categoriaProducto.DefaultCellStyle = dataGridViewCellStyle28;
            this.categoriaProducto.HeaderText = "Categoria";
            this.categoriaProducto.Name = "categoriaProducto";
            // 
            // imagenProducto
            // 
            this.imagenProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle29.NullValue")));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imagenProducto.DefaultCellStyle = dataGridViewCellStyle29;
            this.imagenProducto.FillWeight = 110F;
            this.imagenProducto.HeaderText = "Imagen";
            this.imagenProducto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imagenProducto.MinimumWidth = 8;
            this.imagenProducto.Name = "imagenProducto";
            // 
            // mdProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.BTBuscarProducto);
            this.Controls.Add(this.TBusquedaProducto);
            this.Controls.Add(this.CBBusquedaProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LProductos);
            this.Controls.Add(this.DGVProductos);
            this.Name = "mdProductos";
            this.Text = "mdProductos";
            this.Load += new System.EventHandler(this.mdProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.Label LProductos;
        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Button BTBuscarProducto;
        private System.Windows.Forms.TextBox TBusquedaProducto;
        private System.Windows.Forms.ComboBox CBBusquedaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProducto;
        private System.Windows.Forms.DataGridViewImageColumn imagenProducto;
    }
}