namespace PresentacionWinForm
{
	partial class FrmAgregarBebida
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
			this.cbxBebida = new System.Windows.Forms.ComboBox();
			this.lblBebida = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblContieneAlcohol = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.lblPrecioParcial = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbxBebida
			// 
			this.cbxBebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxBebida.FormattingEnabled = true;
			this.cbxBebida.Location = new System.Drawing.Point(61, 12);
			this.cbxBebida.Name = "cbxBebida";
			this.cbxBebida.Size = new System.Drawing.Size(121, 21);
			this.cbxBebida.TabIndex = 0;
			this.cbxBebida.SelectedIndexChanged += new System.EventHandler(this.cbxBebida_SelectedIndexChanged);
			this.cbxBebida.SelectedValueChanged += new System.EventHandler(this.cbxBebida_SelectedValueChanged);
			// 
			// lblBebida
			// 
			this.lblBebida.AutoSize = true;
			this.lblBebida.Location = new System.Drawing.Point(12, 20);
			this.lblBebida.Name = "lblBebida";
			this.lblBebida.Size = new System.Drawing.Size(43, 13);
			this.lblBebida.TabIndex = 1;
			this.lblBebida.Text = "Bebida:";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(12, 165);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(107, 165);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Location = new System.Drawing.Point(12, 45);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(31, 13);
			this.lblTipo.TabIndex = 4;
			this.lblTipo.Text = "Tipo:";
			// 
			// lblContieneAlcohol
			// 
			this.lblContieneAlcohol.AutoSize = true;
			this.lblContieneAlcohol.Location = new System.Drawing.Point(12, 67);
			this.lblContieneAlcohol.Name = "lblContieneAlcohol";
			this.lblContieneAlcohol.Size = new System.Drawing.Size(89, 13);
			this.lblContieneAlcohol.TabIndex = 5;
			this.lblContieneAlcohol.Text = "Contiene alcohol:";
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Location = new System.Drawing.Point(12, 89);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(79, 13);
			this.lblPrecio.TabIndex = 7;
			this.lblPrecio.Text = "Precio Unitario:";
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Location = new System.Drawing.Point(12, 111);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(52, 13);
			this.lblCantidad.TabIndex = 8;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(70, 108);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(121, 20);
			this.txtCantidad.TabIndex = 9;
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
			// 
			// lblPrecioParcial
			// 
			this.lblPrecioParcial.AutoSize = true;
			this.lblPrecioParcial.Location = new System.Drawing.Point(12, 133);
			this.lblPrecioParcial.Name = "lblPrecioParcial";
			this.lblPrecioParcial.Size = new System.Drawing.Size(78, 13);
			this.lblPrecioParcial.TabIndex = 10;
			this.lblPrecioParcial.Text = "Precio Parcial: ";
			// 
			// FrmAgregarBebida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(197, 200);
			this.Controls.Add(this.lblPrecioParcial);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblContieneAlcohol);
			this.Controls.Add(this.lblTipo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblBebida);
			this.Controls.Add(this.cbxBebida);
			this.Name = "FrmAgregarBebida";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAgregarBebida";
			this.Load += new System.EventHandler(this.FrmAgregarBebida_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxBebida;
		private System.Windows.Forms.Label lblBebida;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblContieneAlcohol;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label lblPrecioParcial;
	}
}