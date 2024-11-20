namespace LeSoleil_Taller2
{
    partial class FormReporteGerente2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BProductosVendidos = new System.Windows.Forms.Button();
            this.LHasta = new System.Windows.Forms.Label();
            this.fechafin = new System.Windows.Forms.DateTimePicker();
            this.fechainicio = new System.Windows.Forms.DateTimePicker();
            this.LDesde = new System.Windows.Forms.Label();
            this.LProductos = new System.Windows.Forms.Label();
            this.LFondoProductos = new System.Windows.Forms.Label();
            this.LFondoUser = new System.Windows.Forms.Label();
            this.DGVProductosVendidos = new System.Windows.Forms.DataGridView();
            this.CProductosVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductosVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // BProductosVendidos
            // 
            this.BProductosVendidos.BackColor = System.Drawing.Color.LightSalmon;
            this.BProductosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProductosVendidos.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BProductosVendidos.ForeColor = System.Drawing.Color.Black;
            this.BProductosVendidos.Image = global::LeSoleil_Taller2.Properties.Resources.lupapng;
            this.BProductosVendidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BProductosVendidos.Location = new System.Drawing.Point(415, 92);
            this.BProductosVendidos.Name = "BProductosVendidos";
            this.BProductosVendidos.Size = new System.Drawing.Size(181, 33);
            this.BProductosVendidos.TabIndex = 65;
            this.BProductosVendidos.Text = "    Productos Más Vendidos";
            this.BProductosVendidos.UseVisualStyleBackColor = false;
            this.BProductosVendidos.Click += new System.EventHandler(this.BProductosVendidos_Click);
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LHasta.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.ForeColor = System.Drawing.Color.Black;
            this.LHasta.Location = new System.Drawing.Point(228, 100);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(47, 18);
            this.LHasta.TabIndex = 64;
            this.LHasta.Text = "Hasta:";
            // 
            // fechafin
            // 
            this.fechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechafin.Location = new System.Drawing.Point(281, 100);
            this.fechafin.Name = "fechafin";
            this.fechafin.Size = new System.Drawing.Size(106, 20);
            this.fechafin.TabIndex = 63;
            // 
            // fechainicio
            // 
            this.fechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechainicio.Location = new System.Drawing.Point(97, 100);
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.Size = new System.Drawing.Size(106, 20);
            this.fechainicio.TabIndex = 62;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDesde.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.ForeColor = System.Drawing.Color.Black;
            this.LDesde.Location = new System.Drawing.Point(47, 100);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(53, 18);
            this.LDesde.TabIndex = 61;
            this.LDesde.Text = "Desde: ";
            // 
            // LProductos
            // 
            this.LProductos.AutoSize = true;
            this.LProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LProductos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductos.ForeColor = System.Drawing.Color.Coral;
            this.LProductos.Location = new System.Drawing.Point(45, 45);
            this.LProductos.Name = "LProductos";
            this.LProductos.Size = new System.Drawing.Size(275, 29);
            this.LProductos.TabIndex = 60;
            this.LProductos.Text = "REPORTE DEL GERENTE";
            this.LProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LFondoProductos
            // 
            this.LFondoProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LFondoProductos.Location = new System.Drawing.Point(22, 24);
            this.LFondoProductos.Name = "LFondoProductos";
            this.LFondoProductos.Size = new System.Drawing.Size(1215, 122);
            this.LFondoProductos.TabIndex = 59;
            // 
            // LFondoUser
            // 
            this.LFondoUser.BackColor = System.Drawing.Color.DarkGray;
            this.LFondoUser.Location = new System.Drawing.Point(-7, -9);
            this.LFondoUser.Name = "LFondoUser";
            this.LFondoUser.Size = new System.Drawing.Size(1326, 718);
            this.LFondoUser.TabIndex = 66;
            // 
            // DGVProductosVendidos
            // 
            this.DGVProductosVendidos.BackgroundColor = System.Drawing.Color.Tan;
            this.DGVProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductosVendidos.Location = new System.Drawing.Point(22, 180);
            this.DGVProductosVendidos.Name = "DGVProductosVendidos";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVProductosVendidos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProductosVendidos.Size = new System.Drawing.Size(389, 350);
            this.DGVProductosVendidos.TabIndex = 67;
            // 
            // CProductosVendidos
            // 
            chartArea1.Name = "ChartArea1";
            this.CProductosVendidos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CProductosVendidos.Legends.Add(legend1);
            this.CProductosVendidos.Location = new System.Drawing.Point(461, 180);
            this.CProductosVendidos.Name = "CProductosVendidos";
            this.CProductosVendidos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CProductosVendidos.Series.Add(series1);
            this.CProductosVendidos.Size = new System.Drawing.Size(776, 350);
            this.CProductosVendidos.TabIndex = 68;
            this.CProductosVendidos.Text = "Productos Vendidos";
            // 
            // FormReporteGerente2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.CProductosVendidos);
            this.Controls.Add(this.DGVProductosVendidos);
            this.Controls.Add(this.BProductosVendidos);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.fechafin);
            this.Controls.Add(this.fechainicio);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.LProductos);
            this.Controls.Add(this.LFondoProductos);
            this.Controls.Add(this.LFondoUser);
            this.Name = "FormReporteGerente2";
            this.Text = "Reporte Gerente";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductosVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CProductosVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BProductosVendidos;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.DateTimePicker fechafin;
        private System.Windows.Forms.DateTimePicker fechainicio;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LProductos;
        private System.Windows.Forms.Label LFondoProductos;
        private System.Windows.Forms.Label LFondoUser;
        private System.Windows.Forms.DataGridView DGVProductosVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart CProductosVendidos;
    }
}