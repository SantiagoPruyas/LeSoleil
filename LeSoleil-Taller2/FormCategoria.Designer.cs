namespace LeSoleil_Taller2
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            this.BInactivosCategory = new System.Windows.Forms.Button();
            this.BActivosCategory = new System.Windows.Forms.Button();
            this.BCancelarCategoria = new System.Windows.Forms.Button();
            this.BGuardarCategoria = new System.Windows.Forms.Button();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.DGVCategorias = new System.Windows.Forms.DataGridView();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bajaCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LNombreUser = new System.Windows.Forms.Label();
            this.LUsers = new System.Windows.Forms.Label();
            this.LFondoUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BInactivosCategory
            // 
            this.BInactivosCategory.BackColor = System.Drawing.Color.Brown;
            this.BInactivosCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInactivosCategory.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInactivosCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BInactivosCategory.Location = new System.Drawing.Point(861, 296);
            this.BInactivosCategory.Name = "BInactivosCategory";
            this.BInactivosCategory.Size = new System.Drawing.Size(173, 41);
            this.BInactivosCategory.TabIndex = 67;
            this.BInactivosCategory.Text = "Categorias Inactivas";
            this.BInactivosCategory.UseVisualStyleBackColor = false;
            this.BInactivosCategory.Click += new System.EventHandler(this.BInactivosCategory_Click);
            // 
            // BActivosCategory
            // 
            this.BActivosCategory.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BActivosCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BActivosCategory.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActivosCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BActivosCategory.Location = new System.Drawing.Point(139, 296);
            this.BActivosCategory.Name = "BActivosCategory";
            this.BActivosCategory.Size = new System.Drawing.Size(163, 41);
            this.BActivosCategory.TabIndex = 66;
            this.BActivosCategory.Text = "Categorias Activas";
            this.BActivosCategory.UseVisualStyleBackColor = false;
            this.BActivosCategory.Click += new System.EventHandler(this.BActivosCategory_Click);
            // 
            // BCancelarCategoria
            // 
            this.BCancelarCategoria.BackColor = System.Drawing.Color.Coral;
            this.BCancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelarCategoria.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCancelarCategoria.Location = new System.Drawing.Point(530, 185);
            this.BCancelarCategoria.Name = "BCancelarCategoria";
            this.BCancelarCategoria.Size = new System.Drawing.Size(94, 38);
            this.BCancelarCategoria.TabIndex = 65;
            this.BCancelarCategoria.Text = "Cancelar";
            this.BCancelarCategoria.UseVisualStyleBackColor = false;
            this.BCancelarCategoria.Click += new System.EventHandler(this.BCancelarCategoria_Click);
            // 
            // BGuardarCategoria
            // 
            this.BGuardarCategoria.BackColor = System.Drawing.Color.Coral;
            this.BGuardarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarCategoria.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardarCategoria.Location = new System.Drawing.Point(421, 185);
            this.BGuardarCategoria.Name = "BGuardarCategoria";
            this.BGuardarCategoria.Size = new System.Drawing.Size(94, 38);
            this.BGuardarCategoria.TabIndex = 64;
            this.BGuardarCategoria.Text = "Guardar";
            this.BGuardarCategoria.UseVisualStyleBackColor = false;
            this.BGuardarCategoria.Click += new System.EventHandler(this.BGuardarCategoria_Click);
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.ForeColor = System.Drawing.Color.Black;
            this.LDescripcion.Location = new System.Drawing.Point(335, 91);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(80, 18);
            this.LDescripcion.TabIndex = 63;
            this.LDescripcion.Text = "Descripcion";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.ForeColor = System.Drawing.Color.Coral;
            this.TBDescripcion.Location = new System.Drawing.Point(421, 91);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(359, 70);
            this.TBDescripcion.TabIndex = 62;
            this.TBDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.TBDescripcion_Validating);
            // 
            // DGVCategorias
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Usuario,
            this.nombreUsuario,
            this.Descripcion,
            this.editarCategoria,
            this.bajaCategoria});
            this.DGVCategorias.Location = new System.Drawing.Point(139, 351);
            this.DGVCategorias.Name = "DGVCategorias";
            this.DGVCategorias.ReadOnly = true;
            this.DGVCategorias.Size = new System.Drawing.Size(895, 224);
            this.DGVCategorias.TabIndex = 61;
            this.DGVCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategorias_CellClick);
            this.DGVCategorias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVCategorias_CellPainting);
            // 
            // Id_Usuario
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Id_Usuario.DefaultCellStyle = dataGridViewCellStyle7;
            this.Id_Usuario.HeaderText = "ID";
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.ReadOnly = true;
            this.Id_Usuario.Width = 50;
            // 
            // nombreUsuario
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.nombreUsuario.DefaultCellStyle = dataGridViewCellStyle8;
            this.nombreUsuario.HeaderText = "Nombre";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle9;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 500;
            // 
            // editarCategoria
            // 
            this.editarCategoria.HeaderText = "Editar ";
            this.editarCategoria.Name = "editarCategoria";
            this.editarCategoria.ReadOnly = true;
            this.editarCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editarCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editarCategoria.Text = "editar";
            // 
            // bajaCategoria
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bajaCategoria.DefaultCellStyle = dataGridViewCellStyle10;
            this.bajaCategoria.HeaderText = "Dar de Baja";
            this.bajaCategoria.Name = "bajaCategoria";
            this.bajaCategoria.ReadOnly = true;
            this.bajaCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bajaCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bajaCategoria.Text = "Eliminar";
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.ForeColor = System.Drawing.Color.Coral;
            this.TBNombre.Location = new System.Drawing.Point(421, 46);
            this.TBNombre.Multiline = true;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(134, 25);
            this.TBNombre.TabIndex = 45;
            this.TBNombre.Leave += new System.EventHandler(this.TBNombre_Leave);
            // 
            // LNombreUser
            // 
            this.LNombreUser.AutoSize = true;
            this.LNombreUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUser.ForeColor = System.Drawing.Color.Black;
            this.LNombreUser.Location = new System.Drawing.Point(335, 48);
            this.LNombreUser.Name = "LNombreUser";
            this.LNombreUser.Size = new System.Drawing.Size(56, 18);
            this.LNombreUser.TabIndex = 43;
            this.LNombreUser.Text = "Nombre";
            // 
            // LUsers
            // 
            this.LUsers.AutoSize = true;
            this.LUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LUsers.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsers.ForeColor = System.Drawing.Color.Coral;
            this.LUsers.Location = new System.Drawing.Point(18, 22);
            this.LUsers.Name = "LUsers";
            this.LUsers.Size = new System.Drawing.Size(152, 29);
            this.LUsers.TabIndex = 42;
            this.LUsers.Text = "CATEGORIAS";
            this.LUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LFondoUser
            // 
            this.LFondoUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoUser.Location = new System.Drawing.Point(-31, -13);
            this.LFondoUser.Name = "LFondoUser";
            this.LFondoUser.Size = new System.Drawing.Size(1337, 306);
            this.LFondoUser.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1291, 420);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.BInactivosCategory);
            this.Controls.Add(this.BActivosCategory);
            this.Controls.Add(this.BCancelarCategoria);
            this.Controls.Add(this.BGuardarCategoria);
            this.Controls.Add(this.LDescripcion);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.DGVCategorias);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LNombreUser);
            this.Controls.Add(this.LUsers);
            this.Controls.Add(this.LFondoUser);
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BInactivosCategory;
        private System.Windows.Forms.Button BActivosCategory;
        private System.Windows.Forms.Button BCancelarCategoria;
        private System.Windows.Forms.Button BGuardarCategoria;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.DataGridView DGVCategorias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LNombreUser;
        private System.Windows.Forms.Label LUsers;
        private System.Windows.Forms.Label LFondoUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn editarCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn bajaCategoria;
    }
}