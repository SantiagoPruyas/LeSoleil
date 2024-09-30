namespace LeSoleil_Taller2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MSMenu = new System.Windows.Forms.MenuStrip();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.MSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSMenu
            // 
            this.MSMenu.AutoSize = false;
            this.MSMenu.BackColor = System.Drawing.Color.DarkSalmon;
            this.MSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuarios,
            this.MenuBackup,
            this.MenuVentas,
            this.MenuClientes,
            this.MenuProductos,
            this.MenuReportes,
            this.MenuSalir});
            this.MSMenu.Location = new System.Drawing.Point(0, 11);
            this.MSMenu.Name = "MSMenu";
            this.MSMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MSMenu.Size = new System.Drawing.Size(805, 89);
            this.MSMenu.TabIndex = 0;
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.BackColor = System.Drawing.Color.DarkSalmon;
            this.MenuUsuarios.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("MenuUsuarios.Image")));
            this.MenuUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(77, 85);
            this.MenuUsuarios.Text = "usuarios";
            this.MenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuarios_Click);
            // 
            // MenuBackup
            // 
            this.MenuBackup.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBackup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuBackup.Image = ((System.Drawing.Image)(resources.GetObject("MenuBackup.Image")));
            this.MenuBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuBackup.Name = "MenuBackup";
            this.MenuBackup.Size = new System.Drawing.Size(77, 85);
            this.MenuBackup.Text = "back up";
            this.MenuBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuBackup.Click += new System.EventHandler(this.MenuBackup_Click);
            // 
            // MenuVentas
            // 
            this.MenuVentas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuVentas.Image = ((System.Drawing.Image)(resources.GetObject("MenuVentas.Image")));
            this.MenuVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(77, 85);
            this.MenuVentas.Text = "ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuVentas.Click += new System.EventHandler(this.MenuVentas_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuClientes.Image = ((System.Drawing.Image)(resources.GetObject("MenuClientes.Image")));
            this.MenuClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(77, 85);
            this.MenuClientes.Text = "clientes";
            this.MenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuClientes.Click += new System.EventHandler(this.MenuClientes_Click);
            // 
            // MenuProductos
            // 
            this.MenuProductos.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuProductos.Image = ((System.Drawing.Image)(resources.GetObject("MenuProductos.Image")));
            this.MenuProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProductos.Name = "MenuProductos";
            this.MenuProductos.Size = new System.Drawing.Size(77, 85);
            this.MenuProductos.Text = "productos";
            this.MenuProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProductos.Click += new System.EventHandler(this.MenuProductos_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuReportes.Image = ((System.Drawing.Image)(resources.GetObject("MenuReportes.Image")));
            this.MenuReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(77, 85);
            this.MenuReportes.Text = "reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // MenuSalir
            // 
            this.MenuSalir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuSalir.Image = ((System.Drawing.Image)(resources.GetObject("MenuSalir.Image")));
            this.MenuSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(77, 85);
            this.MenuSalir.Text = "salir";
            this.MenuSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "le soleil";
            // 
            // menuStrip3
            // 
            this.menuStrip3.AutoSize = false;
            this.menuStrip3.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip3.Size = new System.Drawing.Size(805, 11);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 100);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(805, 574);
            this.PContenedor.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 674);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MSMenu);
            this.Controls.Add(this.menuStrip3);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.MSMenu;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MSMenu.ResumeLayout(false);
            this.MSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuBackup;
        private System.Windows.Forms.ToolStripMenuItem MenuVentas;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuProductos;
        private System.Windows.Forms.ToolStripMenuItem MenuReportes;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.Panel PContenedor;
    }
}