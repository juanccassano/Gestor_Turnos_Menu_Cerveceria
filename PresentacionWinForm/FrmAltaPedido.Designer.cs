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
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.lblProductos = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnCerrarPedido = new System.Windows.Forms.Button();
			this.cbxMesero = new System.Windows.Forms.ComboBox();
			this.lblMesero = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProductos
			// 
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Location = new System.Drawing.Point(12, 36);
			this.dgvProductos.MultiSelect = false;
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductos.Size = new System.Drawing.Size(444, 281);
			this.dgvProductos.TabIndex = 0;
			// 
			// lblProductos
			// 
			this.lblProductos.AutoSize = true;
			this.lblProductos.Location = new System.Drawing.Point(12, 9);
			this.lblProductos.Name = "lblProductos";
			this.lblProductos.Size = new System.Drawing.Size(55, 13);
			this.lblProductos.TabIndex = 1;
			this.lblProductos.Text = "Productos";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(12, 326);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(37, 13);
			this.lblTotal.TabIndex = 2;
			this.lblTotal.Text = "Total: ";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(462, 155);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(462, 184);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 5;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// btnCerrarPedido
			// 
			this.btnCerrarPedido.Location = new System.Drawing.Point(462, 281);
			this.btnCerrarPedido.Name = "btnCerrarPedido";
			this.btnCerrarPedido.Size = new System.Drawing.Size(75, 36);
			this.btnCerrarPedido.TabIndex = 10;
			this.btnCerrarPedido.Text = "Cerrar pedido";
			this.btnCerrarPedido.UseVisualStyleBackColor = true;
			this.btnCerrarPedido.Click += new System.EventHandler(this.btnCerrarPedido_Click);
			// 
			// cbxMesero
			// 
			this.cbxMesero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxMesero.FormattingEnabled = true;
			this.cbxMesero.Location = new System.Drawing.Point(207, 323);
			this.cbxMesero.Name = "cbxMesero";
			this.cbxMesero.Size = new System.Drawing.Size(184, 21);
			this.cbxMesero.TabIndex = 11;
			// 
			// lblMesero
			// 
			this.lblMesero.AutoSize = true;
			this.lblMesero.Location = new System.Drawing.Point(131, 326);
			this.lblMesero.Name = "lblMesero";
			this.lblMesero.Size = new System.Drawing.Size(70, 13);
			this.lblMesero.TabIndex = 12;
			this.lblMesero.Text = "Atendido por:";
			// 
			// FrmAltaPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 351);
			this.Controls.Add(this.lblMesero);
			this.Controls.Add(this.cbxMesero);
			this.Controls.Add(this.btnCerrarPedido);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblProductos);
			this.Controls.Add(this.dgvProductos);
			this.Name = "FrmAltaPedido";
			this.Text = "FrmAltaPedido";
			this.Load += new System.EventHandler(this.FrmAltaPedido_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Label lblProductos;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnCerrarPedido;
		private System.Windows.Forms.ComboBox cbxMesero;
		private System.Windows.Forms.Label lblMesero;
	}
}