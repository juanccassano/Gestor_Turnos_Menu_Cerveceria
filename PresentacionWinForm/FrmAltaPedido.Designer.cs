namespace PresentacionWinForm
{
	partial class FrmAltaPedido
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
			this.dgvBebida = new System.Windows.Forms.DataGridView();
			this.lblBebida = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.lblCerveza = new System.Windows.Forms.Label();
			this.dgvCerveza = new System.Windows.Forms.DataGridView();
			this.lblPlato = new System.Windows.Forms.Label();
			this.dgvPlato = new System.Windows.Forms.DataGridView();
			this.btnCerrarPedido = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBebida)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCerveza)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBebida
			// 
			this.dgvBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBebida.Location = new System.Drawing.Point(12, 25);
			this.dgvBebida.MultiSelect = false;
			this.dgvBebida.Name = "dgvBebida";
			this.dgvBebida.ReadOnly = true;
			this.dgvBebida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBebida.Size = new System.Drawing.Size(532, 81);
			this.dgvBebida.TabIndex = 0;
			// 
			// lblBebida
			// 
			this.lblBebida.AutoSize = true;
			this.lblBebida.Location = new System.Drawing.Point(12, 9);
			this.lblBebida.Name = "lblBebida";
			this.lblBebida.Size = new System.Drawing.Size(45, 13);
			this.lblBebida.TabIndex = 1;
			this.lblBebida.Text = "Bebidas";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(12, 318);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(37, 13);
			this.lblTotal.TabIndex = 2;
			this.lblTotal.Text = "Total: ";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(550, 139);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(550, 168);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 5;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// lblCerveza
			// 
			this.lblCerveza.AutoSize = true;
			this.lblCerveza.Location = new System.Drawing.Point(12, 109);
			this.lblCerveza.Name = "lblCerveza";
			this.lblCerveza.Size = new System.Drawing.Size(51, 13);
			this.lblCerveza.TabIndex = 6;
			this.lblCerveza.Text = "Cervezas";
			// 
			// dgvCerveza
			// 
			this.dgvCerveza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCerveza.Location = new System.Drawing.Point(12, 125);
			this.dgvCerveza.MultiSelect = false;
			this.dgvCerveza.Name = "dgvCerveza";
			this.dgvCerveza.ReadOnly = true;
			this.dgvCerveza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCerveza.Size = new System.Drawing.Size(532, 81);
			this.dgvCerveza.TabIndex = 7;
			// 
			// lblPlato
			// 
			this.lblPlato.AutoSize = true;
			this.lblPlato.Location = new System.Drawing.Point(12, 209);
			this.lblPlato.Name = "lblPlato";
			this.lblPlato.Size = new System.Drawing.Size(36, 13);
			this.lblPlato.TabIndex = 8;
			this.lblPlato.Text = "Platos";
			// 
			// dgvPlato
			// 
			this.dgvPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlato.Location = new System.Drawing.Point(12, 225);
			this.dgvPlato.MultiSelect = false;
			this.dgvPlato.Name = "dgvPlato";
			this.dgvPlato.ReadOnly = true;
			this.dgvPlato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPlato.Size = new System.Drawing.Size(532, 81);
			this.dgvPlato.TabIndex = 9;
			// 
			// btnCerrarPedido
			// 
			this.btnCerrarPedido.Location = new System.Drawing.Point(550, 248);
			this.btnCerrarPedido.Name = "btnCerrarPedido";
			this.btnCerrarPedido.Size = new System.Drawing.Size(75, 36);
			this.btnCerrarPedido.TabIndex = 10;
			this.btnCerrarPedido.Text = "Cerrar pedido";
			this.btnCerrarPedido.UseVisualStyleBackColor = true;
			this.btnCerrarPedido.Click += new System.EventHandler(this.btnCerrarPedido_Click);
			// 
			// FrmAltaPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 346);
			this.Controls.Add(this.btnCerrarPedido);
			this.Controls.Add(this.dgvPlato);
			this.Controls.Add(this.lblPlato);
			this.Controls.Add(this.dgvCerveza);
			this.Controls.Add(this.lblCerveza);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblBebida);
			this.Controls.Add(this.dgvBebida);
			this.Name = "FrmAltaPedido";
			this.Text = "FrmAltaPedido";
			this.Load += new System.EventHandler(this.FrmAltaPedido_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBebida)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCerveza)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBebida;
		private System.Windows.Forms.Label lblBebida;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Label lblCerveza;
		private System.Windows.Forms.DataGridView dgvCerveza;
		private System.Windows.Forms.Label lblPlato;
		private System.Windows.Forms.DataGridView dgvPlato;
		private System.Windows.Forms.Button btnCerrarPedido;
	}
}