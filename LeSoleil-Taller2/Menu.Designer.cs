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
            this.LLeSoleil = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MN_nombreUsuario = new System.Windows.Forms.Label();
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
            this.MSMenu.Size = new System.Drawing.Size(1285, 89);
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
            this.MenuUsuarios.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.MenuUsuarios.Size = new System.Drawing.Size(84, 85);
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
            this.MenuBackup.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MenuBackup.Size = new System.Drawing.Size(89, 85);
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
            this.MenuVentas.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MenuVentas.Size = new System.Drawing.Size(89, 85);
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
            this.MenuClientes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MenuClientes.Size = new System.Drawing.Size(89, 85);
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
            this.MenuProductos.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MenuProductos.Size = new System.Drawing.Size(89, 85);
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
            this.MenuReportes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MenuReportes.Size = new System.Drawing.Size(89, 85);
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
            this.MenuSalir.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MenuSalir.Size = new System.Drawing.Size(89, 85);
            this.MenuSalir.Text = "salir";
            this.MenuSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // LLeSoleil
            // 
            this.LLeSoleil.AutoSize = true;
            this.LLeSoleil.BackColor = System.Drawing.Color.DarkSalmon;
            this.LLeSoleil.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLeSoleil.Location = new System.Drawing.Point(966, 16);
            this.LLeSoleil.Name = "LLeSoleil";
            this.LLeSoleil.Size = new System.Drawing.Size(124, 37);
            this.LLeSoleil.TabIndex = 3;
            this.LLeSoleil.Text = "le soleil";
            // 
            // menuStrip3
            // 
            this.menuStrip3.AutoSize = false;
            this.menuStrip3.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip3.Size = new System.Drawing.Size(1285, 11);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 100);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1285, 601);
            this.PContenedor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(975, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // MN_nombreUsuario
            // 
            this.MN_nombreUsuario.AutoSize = true;
            this.MN_nombreUsuario.BackColor = System.Drawing.Color.DarkSalmon;
            this.MN_nombreUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.MN_nombreUsuario.Location = new System.Drawing.Point(1027, 62);
            this.MN_nombreUsuario.Name = "MN_nombreUsuario";
            this.MN_nombreUsuario.Size = new System.Drawing.Size(86, 18);
            this.MN_nombreUsuario.TabIndex = 6;
            this.MN_nombreUsuario.Text = "UsuarioActual";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 701);
            this.Controls.Add(this.MN_nombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.LLeSoleil);
            this.Controls.Add(this.MSMenu);
            this.Controls.Add(this.menuStrip3);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.MSMenu;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MSMenu.ResumeLayout(false);
            this.MSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSMenu;
        private System.Windows.Forms.Label LLeSoleil;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuBackup;
        private System.Windows.Forms.ToolStripMenuItem MenuVentas;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuProductos;
        private System.Windows.Forms.ToolStripMenuItem MenuReportes;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MN_nombreUsuario;
    }
}