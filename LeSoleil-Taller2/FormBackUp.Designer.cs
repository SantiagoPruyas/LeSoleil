namespace LeSoleil_Taller2
{
    partial class FormBackUp
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
            this.LFondoBackup = new System.Windows.Forms.Label();
            this.LBackup = new System.Windows.Forms.Label();
            this.BBackUp = new System.Windows.Forms.Button();
            this.DGVCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // LFondoBackup
            // 
            this.LFondoBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoBackup.Location = new System.Drawing.Point(0, -3);
            this.LFondoBackup.Name = "LFondoBackup";
            this.LFondoBackup.Size = new System.Drawing.Size(806, 687);
            this.LFondoBackup.TabIndex = 0;
            // 
            // LBackup
            // 
            this.LBackup.AutoSize = true;
            this.LBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBackup.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBackup.ForeColor = System.Drawing.Color.Coral;
            this.LBackup.Location = new System.Drawing.Point(322, 38);
            this.LBackup.Name = "LBackup";
            this.LBackup.Size = new System.Drawing.Size(102, 29);
            this.LBackup.TabIndex = 3;
            this.LBackup.Text = "Back Up";
            // 
            // BBackUp
            // 
            this.BBackUp.BackColor = System.Drawing.Color.Coral;
            this.BBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBackUp.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BBackUp.Location = new System.Drawing.Point(298, 97);
            this.BBackUp.Name = "BBackUp";
            this.BBackUp.Size = new System.Drawing.Size(147, 61);
            this.BBackUp.TabIndex = 9;
            this.BBackUp.Text = "Generar Back Up";
            this.BBackUp.UseVisualStyleBackColor = false;
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
            this.DGVCategorias.Location = new System.Drawing.Point(12, 183);
            this.DGVCategorias.Name = "DGVCategorias";
            this.DGVCategorias.ReadOnly = true;
            this.DGVCategorias.Size = new System.Drawing.Size(776, 479);
            this.DGVCategorias.TabIndex = 62;
            // 
            // FormBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.DGVCategorias);
            this.Controls.Add(this.BBackUp);
            this.Controls.Add(this.LBackup);
            this.Controls.Add(this.LFondoBackup);
            this.Name = "FormBackUp";
            this.Text = "BackUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFondoBackup;
        private System.Windows.Forms.Label LBackup;
        private System.Windows.Forms.Button BBackUp;
        private System.Windows.Forms.DataGridView DGVCategorias;
    }
}