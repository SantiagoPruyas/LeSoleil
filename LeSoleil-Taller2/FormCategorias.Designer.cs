namespace LeSoleil_Taller2
{
    partial class FormCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LCategorias = new System.Windows.Forms.Label();
            this.LEstado = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.TBNombreProducto = new System.Windows.Forms.TextBox();
            this.CBCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.LFondoProductos = new System.Windows.Forms.Label();
            this.BCancelarCategoria = new System.Windows.Forms.Button();
            this.BGuardarCategoria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGVCategorias = new System.Windows.Forms.DataGridView();
            this.BCatActivas = new System.Windows.Forms.Button();
            this.BCatInactivas = new System.Windows.Forms.Button();
            this.Id_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.estadoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // LCategorias
            // 
            this.LCategorias.AutoSize = true;
            this.LCategorias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCategorias.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategorias.ForeColor = System.Drawing.Color.Coral;
            this.LCategorias.Location = new System.Drawing.Point(23, 22);
            this.LCategorias.Name = "LCategorias";
            this.LCategorias.Size = new System.Drawing.Size(152, 29);
            this.LCategorias.TabIndex = 44;
            this.LCategorias.Text = "CATEGORIAS";
            this.LCategorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEstado.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.ForeColor = System.Drawing.Color.Black;
            this.LEstado.Location = new System.Drawing.Point(490, 88);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(48, 18);
            this.LEstado.TabIndex = 45;
            this.LEstado.Text = "Estado";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.ForeColor = System.Drawing.Color.Black;
            this.LDescripcion.Location = new System.Drawing.Point(202, 88);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(80, 18);
            this.LDescripcion.TabIndex = 46;
            this.LDescripcion.Text = "Descripcion";
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreProducto.Location = new System.Drawing.Point(205, 122);
            this.TBNombreProducto.Multiline = true;
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.Size = new System.Drawing.Size(234, 25);
            this.TBNombreProducto.TabIndex = 47;
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
            this.CBCategoriaProducto.Location = new System.Drawing.Point(493, 122);
            this.CBCategoriaProducto.Name = "CBCategoriaProducto";
            this.CBCategoriaProducto.Size = new System.Drawing.Size(234, 21);
            this.CBCategoriaProducto.TabIndex = 53;
            // 
            // LFondoProductos
            // 
            this.LFondoProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoProductos.Location = new System.Drawing.Point(-6, -7);
            this.LFondoProductos.Name = "LFondoProductos";
            this.LFondoProductos.Size = new System.Drawing.Size(1293, 251);
            this.LFondoProductos.TabIndex = 54;
            // 
            // BCancelarCategoria
            // 
            this.BCancelarCategoria.BackColor = System.Drawing.Color.Coral;
            this.BCancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelarCategoria.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelarCategoria.Location = new System.Drawing.Point(326, 176);
            this.BCancelarCategoria.Name = "BCancelarCategoria";
            this.BCancelarCategoria.Size = new System.Drawing.Size(94, 38);
            this.BCancelarCategoria.TabIndex = 57;
            this.BCancelarCategoria.Text = "Cancelar";
            this.BCancelarCategoria.UseVisualStyleBackColor = false;
            // 
            // BGuardarCategoria
            // 
            this.BGuardarCategoria.BackColor = System.Drawing.Color.Coral;
            this.BGuardarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarCategoria.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardarCategoria.Location = new System.Drawing.Point(205, 176);
            this.BGuardarCategoria.Name = "BGuardarCategoria";
            this.BGuardarCategoria.Size = new System.Drawing.Size(94, 38);
            this.BGuardarCategoria.TabIndex = 58;
            this.BGuardarCategoria.Text = "Guardar";
            this.BGuardarCategoria.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1293, 467);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // DGVCategorias
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Categoria,
            this.descripcion,
            this.estadoValor,
            this.estadoCategoria,
            this.bajaUsuario});
            this.DGVCategorias.Location = new System.Drawing.Point(363, 317);
            this.DGVCategorias.Name = "DGVCategorias";
            this.DGVCategorias.ReadOnly = true;
            this.DGVCategorias.Size = new System.Drawing.Size(787, 323);
            this.DGVCategorias.TabIndex = 60;
            // 
            // BCatActivas
            // 
            this.BCatActivas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BCatActivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCatActivas.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCatActivas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCatActivas.Location = new System.Drawing.Point(363, 261);
            this.BCatActivas.Name = "BCatActivas";
            this.BCatActivas.Size = new System.Drawing.Size(166, 41);
            this.BCatActivas.TabIndex = 61;
            this.BCatActivas.Text = "Categorias Activas";
            this.BCatActivas.UseVisualStyleBackColor = false;
            // 
            // BCatInactivas
            // 
            this.BCatInactivas.BackColor = System.Drawing.Color.Brown;
            this.BCatInactivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCatInactivas.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCatInactivas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCatInactivas.Location = new System.Drawing.Point(976, 261);
            this.BCatInactivas.Name = "BCatInactivas";
            this.BCatInactivas.Size = new System.Drawing.Size(174, 41);
            this.BCatInactivas.TabIndex = 62;
            this.BCatInactivas.Text = "Categorias Inactivas";
            this.BCatInactivas.UseVisualStyleBackColor = false;
            // 
            // Id_Categoria
            // 
            this.Id_Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Id_Categoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id_Categoria.HeaderText = "ID";
            this.Id_Categoria.Name = "Id_Categoria";
            this.Id_Categoria.ReadOnly = true;
            this.Id_Categoria.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // estadoValor
            // 
            this.estadoValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoValor.HeaderText = "Estado Valor";
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.ReadOnly = true;
            this.estadoValor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.estadoValor.Text = "editar";
            this.estadoValor.Visible = false;
            // 
            // estadoCategoria
            // 
            this.estadoCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoCategoria.HeaderText = "Estado";
            this.estadoCategoria.Name = "estadoCategoria";
            this.estadoCategoria.ReadOnly = true;
            // 
            // bajaUsuario
            // 
            this.bajaUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bajaUsuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.bajaUsuario.HeaderText = "Dar de Baja";
            this.bajaUsuario.Name = "bajaUsuario";
            this.bajaUsuario.ReadOnly = true;
            this.bajaUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bajaUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bajaUsuario.Text = "Eliminar";
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.BCatInactivas);
            this.Controls.Add(this.BCatActivas);
            this.Controls.Add(this.DGVCategorias);
            this.Controls.Add(this.BGuardarCategoria);
            this.Controls.Add(this.BCancelarCategoria);
            this.Controls.Add(this.CBCategoriaProducto);
            this.Controls.Add(this.TBNombreProducto);
            this.Controls.Add(this.LDescripcion);
            this.Controls.Add(this.LEstado);
            this.Controls.Add(this.LCategorias);
            this.Controls.Add(this.LFondoProductos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCategorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCategorias;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.TextBox TBNombreProducto;
        private System.Windows.Forms.ComboBox CBCategoriaProducto;
        private System.Windows.Forms.Label LFondoProductos;
        private System.Windows.Forms.Button BCancelarCategoria;
        private System.Windows.Forms.Button BGuardarCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGVCategorias;
        private System.Windows.Forms.Button BCatActivas;
        private System.Windows.Forms.Button BCatInactivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn bajaUsuario;
    }
}