namespace LeSoleil_Taller2
{
    partial class FormReporteGerente
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
            this.LFondoProductos = new System.Windows.Forms.Label();
            this.LProductos = new System.Windows.Forms.Label();
            this.LDesde = new System.Windows.Forms.Label();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.LHasta = new System.Windows.Forms.Label();
            this.LTipoReporte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LFondoProductos
            // 
            this.LFondoProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LFondoProductos.Location = new System.Drawing.Point(12, 19);
            this.LFondoProductos.Name = "LFondoProductos";
            this.LFondoProductos.Size = new System.Drawing.Size(1251, 122);
            this.LFondoProductos.TabIndex = 30;
            // 
            // LProductos
            // 
            this.LProductos.AutoSize = true;
            this.LProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LProductos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductos.ForeColor = System.Drawing.Color.Coral;
            this.LProductos.Location = new System.Drawing.Point(26, 31);
            this.LProductos.Name = "LProductos";
            this.LProductos.Size = new System.Drawing.Size(275, 29);
            this.LProductos.TabIndex = 44;
            this.LProductos.Text = "REPORTE DEL GERENTE";
            this.LProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDesde.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.ForeColor = System.Drawing.Color.Black;
            this.LDesde.Location = new System.Drawing.Point(28, 84);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(53, 18);
            this.LDesde.TabIndex = 46;
            this.LDesde.Text = "Desde: ";
            // 
            // DTPDesde
            // 
            this.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesde.Location = new System.Drawing.Point(78, 84);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(106, 20);
            this.DTPDesde.TabIndex = 47;
            // 
            // DTPHasta
            // 
            this.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHasta.Location = new System.Drawing.Point(262, 84);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(106, 20);
            this.DTPHasta.TabIndex = 48;
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LHasta.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.ForeColor = System.Drawing.Color.Black;
            this.LHasta.Location = new System.Drawing.Point(209, 84);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(47, 18);
            this.LHasta.TabIndex = 49;
            this.LHasta.Text = "Hasta:";
            // 
            // LTipoReporte
            // 
            this.LTipoReporte.AutoSize = true;
            this.LTipoReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTipoReporte.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoReporte.ForeColor = System.Drawing.Color.Black;
            this.LTipoReporte.Location = new System.Drawing.Point(439, 84);
            this.LTipoReporte.Name = "LTipoReporte";
            this.LTipoReporte.Size = new System.Drawing.Size(106, 18);
            this.LTipoReporte.TabIndex = 50;
            this.LTipoReporte.Text = "Tipo de Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(296, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Administrador: listar usuarios, listar log de los backups ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(296, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Gerente: Total Ventas, Mejor vendedor, productos mas vendidos por unidad, listar " +
    "recaudacion  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(296, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Vendedor: sus propias ventas";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Total Ventas",
            "Productos más Vendidos por Unidad",
            "Mejor Vendedor",
            "Listar Recaudación"});
            this.comboBox1.Location = new System.Drawing.Point(551, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(296, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(493, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Repositor de stock: Listar todos los productos, listar productos con bajo stock ";
            // 
            // FormReporteGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LTipoReporte);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.DTPHasta);
            this.Controls.Add(this.DTPDesde);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.LProductos);
            this.Controls.Add(this.LFondoProductos);
            this.Name = "FormReporteGerente";
            this.Text = "FormReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFondoProductos;
        private System.Windows.Forms.Label LProductos;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LTipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}