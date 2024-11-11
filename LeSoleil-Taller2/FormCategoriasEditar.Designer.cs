namespace LeSoleil_Taller2
{
    partial class FormCategoriasEditar
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
            this.label1 = new System.Windows.Forms.Label();
            this.LIDCategory = new System.Windows.Forms.Label();
            this.BEditarCancelar = new System.Windows.Forms.Button();
            this.BEditarGuardar = new System.Windows.Forms.Button();
            this.LEditarUsuario = new System.Windows.Forms.Label();
            this.LEmailUser = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LNombreUser = new System.Windows.Forms.Label();
            this.LFondoUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(412, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 80;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LIDCategory
            // 
            this.LIDCategory.AutoSize = true;
            this.LIDCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LIDCategory.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIDCategory.ForeColor = System.Drawing.Color.Coral;
            this.LIDCategory.Location = new System.Drawing.Point(462, 13);
            this.LIDCategory.Name = "LIDCategory";
            this.LIDCategory.Size = new System.Drawing.Size(22, 29);
            this.LIDCategory.TabIndex = 79;
            this.LIDCategory.Text = "-";
            this.LIDCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BEditarCancelar
            // 
            this.BEditarCancelar.BackColor = System.Drawing.Color.Brown;
            this.BEditarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditarCancelar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BEditarCancelar.Location = new System.Drawing.Point(367, 301);
            this.BEditarCancelar.Name = "BEditarCancelar";
            this.BEditarCancelar.Size = new System.Drawing.Size(95, 40);
            this.BEditarCancelar.TabIndex = 76;
            this.BEditarCancelar.Text = "Cancelar";
            this.BEditarCancelar.UseVisualStyleBackColor = false;
            this.BEditarCancelar.Click += new System.EventHandler(this.BEditarCancelar_Click);
            // 
            // BEditarGuardar
            // 
            this.BEditarGuardar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BEditarGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditarGuardar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BEditarGuardar.Location = new System.Drawing.Point(50, 301);
            this.BEditarGuardar.Name = "BEditarGuardar";
            this.BEditarGuardar.Size = new System.Drawing.Size(152, 40);
            this.BEditarGuardar.TabIndex = 75;
            this.BEditarGuardar.Text = "Guardar Cambios";
            this.BEditarGuardar.UseVisualStyleBackColor = false;
            this.BEditarGuardar.Click += new System.EventHandler(this.BEditarGuardar_Click);
            // 
            // LEditarUsuario
            // 
            this.LEditarUsuario.AutoSize = true;
            this.LEditarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEditarUsuario.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEditarUsuario.ForeColor = System.Drawing.Color.Coral;
            this.LEditarUsuario.Location = new System.Drawing.Point(161, 37);
            this.LEditarUsuario.Name = "LEditarUsuario";
            this.LEditarUsuario.Size = new System.Drawing.Size(196, 29);
            this.LEditarUsuario.TabIndex = 74;
            this.LEditarUsuario.Text = "Editar Categoria";
            this.LEditarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LEmailUser
            // 
            this.LEmailUser.AutoSize = true;
            this.LEmailUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmailUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmailUser.ForeColor = System.Drawing.Color.Black;
            this.LEmailUser.Location = new System.Drawing.Point(122, 144);
            this.LEmailUser.Name = "LEmailUser";
            this.LEmailUser.Size = new System.Drawing.Size(80, 18);
            this.LEmailUser.TabIndex = 67;
            this.LEmailUser.Text = "Descripcion";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.ForeColor = System.Drawing.Color.Coral;
            this.TBDescripcion.Location = new System.Drawing.Point(208, 144);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(179, 129);
            this.TBDescripcion.TabIndex = 66;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.ForeColor = System.Drawing.Color.Coral;
            this.TBNombre.Location = new System.Drawing.Point(208, 102);
            this.TBNombre.Multiline = true;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(179, 25);
            this.TBNombre.TabIndex = 58;
            // 
            // LNombreUser
            // 
            this.LNombreUser.AutoSize = true;
            this.LNombreUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUser.ForeColor = System.Drawing.Color.Black;
            this.LNombreUser.Location = new System.Drawing.Point(122, 104);
            this.LNombreUser.Name = "LNombreUser";
            this.LNombreUser.Size = new System.Drawing.Size(56, 18);
            this.LNombreUser.TabIndex = 56;
            this.LNombreUser.Text = "Nombre";
            // 
            // LFondoUser
            // 
            this.LFondoUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoUser.Location = new System.Drawing.Point(-7, -22);
            this.LFondoUser.Name = "LFondoUser";
            this.LFondoUser.Size = new System.Drawing.Size(515, 399);
            this.LFondoUser.TabIndex = 55;
            // 
            // FormCategoriasEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIDCategory);
            this.Controls.Add(this.BEditarCancelar);
            this.Controls.Add(this.BEditarGuardar);
            this.Controls.Add(this.LEditarUsuario);
            this.Controls.Add(this.LEmailUser);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LNombreUser);
            this.Controls.Add(this.LFondoUser);
            this.Name = "FormCategoriasEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoriasEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LIDCategory;
        private System.Windows.Forms.Button BEditarCancelar;
        private System.Windows.Forms.Button BEditarGuardar;
        private System.Windows.Forms.Label LEditarUsuario;
        private System.Windows.Forms.Label LEmailUser;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LNombreUser;
        private System.Windows.Forms.Label LFondoUser;
    }
}