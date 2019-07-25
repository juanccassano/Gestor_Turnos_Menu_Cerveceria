namespace PresentacionWinForm
{
    partial class FrmMenu
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
			this.lblSalon = new System.Windows.Forms.Label();
			this.btnSalon = new System.Windows.Forms.Button();
			this.mstMenu = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bebidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cervezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.platosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.combosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaDeEsperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.promocinoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mstMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSalon
			// 
			this.lblSalon.AutoSize = true;
			this.lblSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSalon.Location = new System.Drawing.Point(156, 45);
			this.lblSalon.Name = "lblSalon";
			this.lblSalon.Size = new System.Drawing.Size(34, 13);
			this.lblSalon.TabIndex = 3;
			this.lblSalon.Text = "Salón";
			// 
			// btnSalon
			// 
			this.btnSalon.Image = global::PresentacionWinForm.Properties.Resources.Cerveza;
			this.btnSalon.Location = new System.Drawing.Point(12, 61);
			this.btnSalon.Name = "btnSalon";
			this.btnSalon.Size = new System.Drawing.Size(326, 320);
			this.btnSalon.TabIndex = 1;
			this.btnSalon.UseVisualStyleBackColor = true;
			this.btnSalon.Click += new System.EventHandler(this.btnSalon_Click);
			// 
			// mstMenu
			// 
			this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.listaDeEsperaToolStripMenuItem,
            this.promocinoesToolStripMenuItem});
			this.mstMenu.Location = new System.Drawing.Point(0, 0);
			this.mstMenu.Name = "mstMenu";
			this.mstMenu.Size = new System.Drawing.Size(363, 24);
			this.mstMenu.TabIndex = 4;
			this.mstMenu.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.articulosToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.salirToolStripMenuItem.Text = "Personas";
			// 
			// personaToolStripMenuItem
			// 
			this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
			this.personaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.personaToolStripMenuItem.Text = "Empleados";
			this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
			// 
			// proveedoresToolStripMenuItem
			// 
			this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
			this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.proveedoresToolStripMenuItem.Text = "Proveedores";
			this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
			// 
			// articulosToolStripMenuItem
			// 
			this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bebidaToolStripMenuItem,
            this.cervezaToolStripMenuItem,
            this.platosToolStripMenuItem,
            this.combosToolStripMenuItem});
			this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
			this.articulosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.articulosToolStripMenuItem.Text = "Articulos";
			// 
			// bebidaToolStripMenuItem
			// 
			this.bebidaToolStripMenuItem.Name = "bebidaToolStripMenuItem";
			this.bebidaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.bebidaToolStripMenuItem.Text = "Bebida";
			this.bebidaToolStripMenuItem.Click += new System.EventHandler(this.bebidaToolStripMenuItem_Click);
			// 
			// cervezaToolStripMenuItem
			// 
			this.cervezaToolStripMenuItem.Name = "cervezaToolStripMenuItem";
			this.cervezaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.cervezaToolStripMenuItem.Text = "Cerveza";
			this.cervezaToolStripMenuItem.Click += new System.EventHandler(this.cervezaToolStripMenuItem_Click);
			// 
			// platosToolStripMenuItem
			// 
			this.platosToolStripMenuItem.Name = "platosToolStripMenuItem";
			this.platosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.platosToolStripMenuItem.Text = "Platos";
			this.platosToolStripMenuItem.Click += new System.EventHandler(this.platosToolStripMenuItem_Click);
			// 
			// combosToolStripMenuItem
			// 
			this.combosToolStripMenuItem.Name = "combosToolStripMenuItem";
			this.combosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.combosToolStripMenuItem.Text = "Combos";
			// 
			// reservasToolStripMenuItem
			// 
			this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
			this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.reservasToolStripMenuItem.Text = "Reservas";
			this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
			// 
			// listaDeEsperaToolStripMenuItem
			// 
			this.listaDeEsperaToolStripMenuItem.Name = "listaDeEsperaToolStripMenuItem";
			this.listaDeEsperaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.listaDeEsperaToolStripMenuItem.Text = "Lista de espera";
			// 
			// promocinoesToolStripMenuItem
			// 
			this.promocinoesToolStripMenuItem.Name = "promocinoesToolStripMenuItem";
			this.promocinoesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.promocinoesToolStripMenuItem.Text = "Promociones";
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 408);
			this.Controls.Add(this.lblSalon);
			this.Controls.Add(this.btnSalon);
			this.Controls.Add(this.mstMenu);
			this.MainMenuStrip = this.mstMenu;
			this.Name = "FrmMenu";
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.FrmMenu_Load);
			this.mstMenu.ResumeLayout(false);
			this.mstMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalon;
        private System.Windows.Forms.Label lblSalon;
		private System.Windows.Forms.MenuStrip mstMenu;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bebidaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cervezaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem platosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem combosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listaDeEsperaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem promocinoesToolStripMenuItem;
	}
}