﻿namespace LeSoleil_Taller2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LFondoBackup = new System.Windows.Forms.Label();
            this.LBackup = new System.Windows.Forms.Label();
            this.BBackUp = new System.Windows.Forms.Button();
            this.DGVBackUps = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBackUps)).BeginInit();
            this.SuspendLayout();
            // 
            // LFondoBackup
            // 
            this.LFondoBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFondoBackup.Location = new System.Drawing.Point(0, -3);
            this.LFondoBackup.Name = "LFondoBackup";
            this.LFondoBackup.Size = new System.Drawing.Size(1299, 587);
            this.LFondoBackup.TabIndex = 0;
            // 
            // LBackup
            // 
            this.LBackup.AutoSize = true;
            this.LBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBackup.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBackup.ForeColor = System.Drawing.Color.Coral;
            this.LBackup.Location = new System.Drawing.Point(573, 43);
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
            this.BBackUp.Location = new System.Drawing.Point(553, 89);
            this.BBackUp.Name = "BBackUp";
            this.BBackUp.Size = new System.Drawing.Size(147, 61);
            this.BBackUp.TabIndex = 9;
            this.BBackUp.Text = "Generar Back Up";
            this.BBackUp.UseVisualStyleBackColor = false;
            this.BBackUp.Click += new System.EventHandler(this.BBackUp_Click);
            // 
            // DGVBackUps
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBackUps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVBackUps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBackUps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Usuario,
            this.Estado,
            this.Fecha,
            this.Ubicacion});
            this.DGVBackUps.Location = new System.Drawing.Point(180, 181);
            this.DGVBackUps.Name = "DGVBackUps";
            this.DGVBackUps.ReadOnly = true;
            this.DGVBackUps.Size = new System.Drawing.Size(855, 383);
            this.DGVBackUps.TabIndex = 62;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Id.DefaultCellStyle = dataGridViewCellStyle8;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Usuario.DefaultCellStyle = dataGridViewCellStyle9;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle10;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle11;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Ubicacion
            // 
            this.Ubicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.Ubicacion.DefaultCellStyle = dataGridViewCellStyle12;
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            // 
            // FormBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.DGVBackUps);
            this.Controls.Add(this.BBackUp);
            this.Controls.Add(this.LBackup);
            this.Controls.Add(this.LFondoBackup);
            this.Name = "FormBackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackUpForm";
            this.Load += new System.EventHandler(this.FormBackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBackUps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFondoBackup;
        private System.Windows.Forms.Label LBackup;
        private System.Windows.Forms.Button BBackUp;
        private System.Windows.Forms.DataGridView DGVBackUps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
    }
}