﻿namespace LeSoleil_Taller2
{
    partial class FormProductosEditar
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
            this.LIDProducto = new System.Windows.Forms.Label();
            this.BEditarCancelar = new System.Windows.Forms.Button();
            this.BEditarGuardar = new System.Windows.Forms.Button();
            this.LEditarProducto = new System.Windows.Forms.Label();
            this.TBCodigoProducto = new System.Windows.Forms.TextBox();
            this.LCodigoProducto = new System.Windows.Forms.Label();
            this.BSeleccionarImagen = new System.Windows.Forms.Button();
            this.LImagenProducto = new System.Windows.Forms.Label();
            this.LCategoriaProducto = new System.Windows.Forms.Label();
            this.CBCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.LStockMin = new System.Windows.Forms.Label();
            this.TBStockMin = new System.Windows.Forms.TextBox();
            this.LPrecioVenta = new System.Windows.Forms.Label();
            this.TBPrecioVenta = new System.Windows.Forms.TextBox();
            this.LDescripcionProducto = new System.Windows.Forms.Label();
            this.TBDescripcionProducto = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.TBStockProducto = new System.Windows.Forms.TextBox();
            this.LPrecioProducto = new System.Windows.Forms.Label();
            this.TBPrecioCompra = new System.Windows.Forms.TextBox();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.TBNombreProducto = new System.Windows.Forms.TextBox();
            this.BSeleccionar = new System.Windows.Forms.Button();
            this.LFondoProd = new System.Windows.Forms.Label();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.TBImagenProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(417, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 79;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LIDProducto
            // 
            this.LIDProducto.AutoSize = true;
            this.LIDProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LIDProducto.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIDProducto.ForeColor = System.Drawing.Color.Coral;
            this.LIDProducto.Location = new System.Drawing.Point(467, 8);
            this.LIDProducto.Name = "LIDProducto";
            this.LIDProducto.Size = new System.Drawing.Size(22, 29);
            this.LIDProducto.TabIndex = 78;
            this.LIDProducto.Text = "-";
            this.LIDProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BEditarCancelar
            // 
            this.BEditarCancelar.BackColor = System.Drawing.Color.Brown;
            this.BEditarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditarCancelar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BEditarCancelar.Location = new System.Drawing.Point(379, 654);
            this.BEditarCancelar.Name = "BEditarCancelar";
            this.BEditarCancelar.Size = new System.Drawing.Size(95, 40);
            this.BEditarCancelar.TabIndex = 75;
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
            this.BEditarGuardar.Location = new System.Drawing.Point(24, 654);
            this.BEditarGuardar.Name = "BEditarGuardar";
            this.BEditarGuardar.Size = new System.Drawing.Size(152, 40);
            this.BEditarGuardar.TabIndex = 74;
            this.BEditarGuardar.Text = "Guardar Cambios";
            this.BEditarGuardar.UseVisualStyleBackColor = false;
            this.BEditarGuardar.Click += new System.EventHandler(this.BEditarGuardar_Click);
            // 
            // LEditarProducto
            // 
            this.LEditarProducto.AutoSize = true;
            this.LEditarProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEditarProducto.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEditarProducto.ForeColor = System.Drawing.Color.Coral;
            this.LEditarProducto.Location = new System.Drawing.Point(166, 32);
            this.LEditarProducto.Name = "LEditarProducto";
            this.LEditarProducto.Size = new System.Drawing.Size(190, 29);
            this.LEditarProducto.TabIndex = 73;
            this.LEditarProducto.Text = "Editar Producto";
            this.LEditarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TBCodigoProducto
            // 
            this.TBCodigoProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBCodigoProducto.Location = new System.Drawing.Point(204, 97);
            this.TBCodigoProducto.Multiline = true;
            this.TBCodigoProducto.Name = "TBCodigoProducto";
            this.TBCodigoProducto.Size = new System.Drawing.Size(134, 25);
            this.TBCodigoProducto.TabIndex = 57;
            this.TBCodigoProducto.Leave += new System.EventHandler(this.TBCodigoProducto_Leave);
            // 
            // LCodigoProducto
            // 
            this.LCodigoProducto.AutoSize = true;
            this.LCodigoProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCodigoProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.LCodigoProducto.Location = new System.Drawing.Point(127, 97);
            this.LCodigoProducto.Name = "LCodigoProducto";
            this.LCodigoProducto.Size = new System.Drawing.Size(49, 18);
            this.LCodigoProducto.TabIndex = 55;
            this.LCodigoProducto.Text = "Codigo";
            // 
            // BSeleccionarImagen
            // 
            this.BSeleccionarImagen.BackColor = System.Drawing.Color.Coral;
            this.BSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSeleccionarImagen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSeleccionarImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BSeleccionarImagen.Location = new System.Drawing.Point(674, 273);
            this.BSeleccionarImagen.Name = "BSeleccionarImagen";
            this.BSeleccionarImagen.Size = new System.Drawing.Size(167, 38);
            this.BSeleccionarImagen.TabIndex = 96;
            this.BSeleccionarImagen.Text = "Seleccionar Imagen";
            this.BSeleccionarImagen.UseVisualStyleBackColor = false;
            // 
            // LImagenProducto
            // 
            this.LImagenProducto.AutoSize = true;
            this.LImagenProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LImagenProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LImagenProducto.ForeColor = System.Drawing.Color.Black;
            this.LImagenProducto.Location = new System.Drawing.Point(124, 389);
            this.LImagenProducto.Name = "LImagenProducto";
            this.LImagenProducto.Size = new System.Drawing.Size(52, 18);
            this.LImagenProducto.TabIndex = 95;
            this.LImagenProducto.Text = "Imagen";
            // 
            // LCategoriaProducto
            // 
            this.LCategoriaProducto.AutoSize = true;
            this.LCategoriaProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCategoriaProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoriaProducto.ForeColor = System.Drawing.Color.Black;
            this.LCategoriaProducto.Location = new System.Drawing.Point(110, 351);
            this.LCategoriaProducto.Name = "LCategoriaProducto";
            this.LCategoriaProducto.Size = new System.Drawing.Size(66, 18);
            this.LCategoriaProducto.TabIndex = 93;
            this.LCategoriaProducto.Text = "Categoria";
            // 
            // CBCategoriaProducto
            // 
            this.CBCategoriaProducto.FormattingEnabled = true;
            this.CBCategoriaProducto.Location = new System.Drawing.Point(204, 351);
            this.CBCategoriaProducto.Name = "CBCategoriaProducto";
            this.CBCategoriaProducto.Size = new System.Drawing.Size(134, 21);
            this.CBCategoriaProducto.TabIndex = 92;
            this.CBCategoriaProducto.Leave += new System.EventHandler(this.CBCategoriaProducto_Leave);
            // 
            // LStockMin
            // 
            this.LStockMin.AutoSize = true;
            this.LStockMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LStockMin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStockMin.ForeColor = System.Drawing.Color.Black;
            this.LStockMin.Location = new System.Drawing.Point(87, 311);
            this.LStockMin.Name = "LStockMin";
            this.LStockMin.Size = new System.Drawing.Size(89, 18);
            this.LStockMin.TabIndex = 91;
            this.LStockMin.Text = "Stock Minimo";
            // 
            // TBStockMin
            // 
            this.TBStockMin.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockMin.ForeColor = System.Drawing.Color.Coral;
            this.TBStockMin.Location = new System.Drawing.Point(204, 311);
            this.TBStockMin.Multiline = true;
            this.TBStockMin.Name = "TBStockMin";
            this.TBStockMin.Size = new System.Drawing.Size(134, 23);
            this.TBStockMin.TabIndex = 90;
            this.TBStockMin.Leave += new System.EventHandler(this.TBStockMin_Leave);
            // 
            // LPrecioVenta
            // 
            this.LPrecioVenta.AutoSize = true;
            this.LPrecioVenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPrecioVenta.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.LPrecioVenta.Location = new System.Drawing.Point(91, 230);
            this.LPrecioVenta.Name = "LPrecioVenta";
            this.LPrecioVenta.Size = new System.Drawing.Size(85, 18);
            this.LPrecioVenta.TabIndex = 89;
            this.LPrecioVenta.Text = "Precio Venta";
            // 
            // TBPrecioVenta
            // 
            this.TBPrecioVenta.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioVenta.ForeColor = System.Drawing.Color.Coral;
            this.TBPrecioVenta.Location = new System.Drawing.Point(204, 230);
            this.TBPrecioVenta.Multiline = true;
            this.TBPrecioVenta.Name = "TBPrecioVenta";
            this.TBPrecioVenta.Size = new System.Drawing.Size(134, 23);
            this.TBPrecioVenta.TabIndex = 88;
            this.TBPrecioVenta.Leave += new System.EventHandler(this.TBPrecioVenta_Leave);
            // 
            // LDescripcionProducto
            // 
            this.LDescripcionProducto.AutoSize = true;
            this.LDescripcionProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDescripcionProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcionProducto.ForeColor = System.Drawing.Color.Black;
            this.LDescripcionProducto.Location = new System.Drawing.Point(96, 557);
            this.LDescripcionProducto.Name = "LDescripcionProducto";
            this.LDescripcionProducto.Size = new System.Drawing.Size(80, 18);
            this.LDescripcionProducto.TabIndex = 87;
            this.LDescripcionProducto.Text = "Descripcion";
            // 
            // TBDescripcionProducto
            // 
            this.TBDescripcionProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcionProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBDescripcionProducto.Location = new System.Drawing.Point(204, 557);
            this.TBDescripcionProducto.Multiline = true;
            this.TBDescripcionProducto.Name = "TBDescripcionProducto";
            this.TBDescripcionProducto.Size = new System.Drawing.Size(257, 73);
            this.TBDescripcionProducto.TabIndex = 86;
            this.TBDescripcionProducto.Text = "Ej: Tipo de tela";
            this.TBDescripcionProducto.Leave += new System.EventHandler(this.TBDescripcionProducto_Leave);
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LStock.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.ForeColor = System.Drawing.Color.Black;
            this.LStock.Location = new System.Drawing.Point(135, 271);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(41, 18);
            this.LStock.TabIndex = 85;
            this.LStock.Text = "Stock";
            // 
            // TBStockProducto
            // 
            this.TBStockProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBStockProducto.Location = new System.Drawing.Point(204, 271);
            this.TBStockProducto.Multiline = true;
            this.TBStockProducto.Name = "TBStockProducto";
            this.TBStockProducto.Size = new System.Drawing.Size(134, 23);
            this.TBStockProducto.TabIndex = 84;
            this.TBStockProducto.Leave += new System.EventHandler(this.TBStockProducto_Leave);
            // 
            // LPrecioProducto
            // 
            this.LPrecioProducto.AutoSize = true;
            this.LPrecioProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPrecioProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioProducto.ForeColor = System.Drawing.Color.Black;
            this.LPrecioProducto.Location = new System.Drawing.Point(78, 187);
            this.LPrecioProducto.Name = "LPrecioProducto";
            this.LPrecioProducto.Size = new System.Drawing.Size(98, 18);
            this.LPrecioProducto.TabIndex = 83;
            this.LPrecioProducto.Text = "Precio Compra";
            // 
            // TBPrecioCompra
            // 
            this.TBPrecioCompra.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioCompra.ForeColor = System.Drawing.Color.Coral;
            this.TBPrecioCompra.Location = new System.Drawing.Point(204, 187);
            this.TBPrecioCompra.Multiline = true;
            this.TBPrecioCompra.Name = "TBPrecioCompra";
            this.TBPrecioCompra.Size = new System.Drawing.Size(134, 23);
            this.TBPrecioCompra.TabIndex = 82;
            this.TBPrecioCompra.Leave += new System.EventHandler(this.TBPrecioCompra_Leave);
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.LNombreProducto.Location = new System.Drawing.Point(37, 142);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(139, 18);
            this.LNombreProducto.TabIndex = 81;
            this.LNombreProducto.Text = "Nombre del Producto";
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBNombreProducto.Location = new System.Drawing.Point(204, 142);
            this.TBNombreProducto.Multiline = true;
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.Size = new System.Drawing.Size(134, 25);
            this.TBNombreProducto.TabIndex = 80;
            this.TBNombreProducto.Leave += new System.EventHandler(this.TBNombreProducto_Leave);
            // 
            // BSeleccionar
            // 
            this.BSeleccionar.BackColor = System.Drawing.Color.Coral;
            this.BSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSeleccionar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BSeleccionar.Location = new System.Drawing.Point(348, 384);
            this.BSeleccionar.Name = "BSeleccionar";
            this.BSeleccionar.Size = new System.Drawing.Size(117, 32);
            this.BSeleccionar.TabIndex = 97;
            this.BSeleccionar.Text = "Seleccionar";
            this.BSeleccionar.UseVisualStyleBackColor = false;
            this.BSeleccionar.Click += new System.EventHandler(this.BSeleccionar_Click);
            // 
            // LFondoProd
            // 
            this.LFondoProd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoProd.Location = new System.Drawing.Point(-4, -4);
            this.LFondoProd.Name = "LFondoProd";
            this.LFondoProd.Size = new System.Drawing.Size(505, 720);
            this.LFondoProd.TabIndex = 98;
            // 
            // PBImagen
            // 
            this.PBImagen.Location = new System.Drawing.Point(204, 429);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(134, 111);
            this.PBImagen.TabIndex = 99;
            this.PBImagen.TabStop = false;
            // 
            // TBImagenProducto
            // 
            this.TBImagenProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBImagenProducto.ForeColor = System.Drawing.Color.Coral;
            this.TBImagenProducto.Location = new System.Drawing.Point(204, 390);
            this.TBImagenProducto.Multiline = true;
            this.TBImagenProducto.Name = "TBImagenProducto";
            this.TBImagenProducto.Size = new System.Drawing.Size(134, 23);
            this.TBImagenProducto.TabIndex = 100;
            this.TBImagenProducto.Leave += new System.EventHandler(this.TBImagenProducto_Leave);
            // 
            // FormProductosEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 718);
            this.Controls.Add(this.TBImagenProducto);
            this.Controls.Add(this.PBImagen);
            this.Controls.Add(this.BSeleccionar);
            this.Controls.Add(this.BSeleccionarImagen);
            this.Controls.Add(this.LImagenProducto);
            this.Controls.Add(this.LCategoriaProducto);
            this.Controls.Add(this.CBCategoriaProducto);
            this.Controls.Add(this.LStockMin);
            this.Controls.Add(this.TBStockMin);
            this.Controls.Add(this.LPrecioVenta);
            this.Controls.Add(this.TBPrecioVenta);
            this.Controls.Add(this.LDescripcionProducto);
            this.Controls.Add(this.TBDescripcionProducto);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.TBStockProducto);
            this.Controls.Add(this.LPrecioProducto);
            this.Controls.Add(this.TBPrecioCompra);
            this.Controls.Add(this.LNombreProducto);
            this.Controls.Add(this.TBNombreProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIDProducto);
            this.Controls.Add(this.BEditarCancelar);
            this.Controls.Add(this.BEditarGuardar);
            this.Controls.Add(this.LEditarProducto);
            this.Controls.Add(this.TBCodigoProducto);
            this.Controls.Add(this.LCodigoProducto);
            this.Controls.Add(this.LFondoProd);
            this.Name = "FormProductosEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.FormProductosEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LIDProducto;
        private System.Windows.Forms.Button BEditarCancelar;
        private System.Windows.Forms.Button BEditarGuardar;
        private System.Windows.Forms.Label LEditarProducto;
        private System.Windows.Forms.TextBox TBCodigoProducto;
        private System.Windows.Forms.Label LCodigoProducto;
        private System.Windows.Forms.Button BSeleccionarImagen;
        private System.Windows.Forms.Label LImagenProducto;
        private System.Windows.Forms.Label LCategoriaProducto;
        private System.Windows.Forms.ComboBox CBCategoriaProducto;
        private System.Windows.Forms.Label LStockMin;
        private System.Windows.Forms.TextBox TBStockMin;
        private System.Windows.Forms.Label LPrecioVenta;
        private System.Windows.Forms.TextBox TBPrecioVenta;
        private System.Windows.Forms.Label LDescripcionProducto;
        private System.Windows.Forms.TextBox TBDescripcionProducto;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.TextBox TBStockProducto;
        private System.Windows.Forms.Label LPrecioProducto;
        private System.Windows.Forms.TextBox TBPrecioCompra;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.TextBox TBNombreProducto;
        private System.Windows.Forms.Button BSeleccionar;
        private System.Windows.Forms.Label LFondoProd;
        private System.Windows.Forms.PictureBox PBImagen;
        private System.Windows.Forms.TextBox TBImagenProducto;
    }
}