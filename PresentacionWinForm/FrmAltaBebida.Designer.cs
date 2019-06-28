namespace PresentacionWinForm
{
	partial class FrmAltaBebida
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
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblAlcoholica = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblPrecioUnitario = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
			this.ckbAlcoholica = new System.Windows.Forms.CheckBox();
			this.lblId = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(12, 44);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(50, 13);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre: ";
			// 
			// lblAlcoholica
			// 
			this.lblAlcoholica.AutoSize = true;
			this.lblAlcoholica.Location = new System.Drawing.Point(12, 121);
			this.lblAlcoholica.Name = "lblAlcoholica";
			this.lblAlcoholica.Size = new System.Drawing.Size(56, 13);
			this.lblAlcoholica.TabIndex = 1;
			this.lblAlcoholica.Text = "Alcoholica";
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(12, 70);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(43, 13);
			this.lblMarca.TabIndex = 2;
			this.lblMarca.Text = "Marca: ";
			// 
			// lblPrecioUnitario
			// 
			this.lblPrecioUnitario.AutoSize = true;
			this.lblPrecioUnitario.Location = new System.Drawing.Point(12, 96);
			this.lblPrecioUnitario.Name = "lblPrecioUnitario";
			this.lblPrecioUnitario.Size = new System.Drawing.Size(80, 13);
			this.lblPrecioUnitario.TabIndex = 3;
			this.lblPrecioUnitario.Text = "Precio unitario: ";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(68, 37);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(130, 20);
			this.txtNombre.TabIndex = 4;
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(68, 63);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(130, 20);
			this.txtMarca.TabIndex = 5;
			// 
			// txtPrecioUnitario
			// 
			this.txtPrecioUnitario.Location = new System.Drawing.Point(98, 89);
			this.txtPrecioUnitario.Name = "txtPrecioUnitario";
			this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 20);
			this.txtPrecioUnitario.TabIndex = 6;
			// 
			// ckbAlcoholica
			// 
			this.ckbAlcoholica.AutoSize = true;
			this.ckbAlcoholica.Location = new System.Drawing.Point(98, 121);
			this.ckbAlcoholica.Name = "ckbAlcoholica";
			this.ckbAlcoholica.Size = new System.Drawing.Size(15, 14);
			this.ckbAlcoholica.TabIndex = 7;
			this.ckbAlcoholica.UseVisualStyleBackColor = true;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(12, 18);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(24, 13);
			this.lblId.TabIndex = 8;
			this.lblId.Text = "ID: ";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(12, 153);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 9;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(123, 153);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
			// 
			// FrmAltaBebida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(215, 190);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.ckbAlcoholica);
			this.Controls.Add(this.txtPrecioUnitario);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblPrecioUnitario);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.lblAlcoholica);
			this.Controls.Add(this.lblNombre);
			this.Name = "FrmAltaBebida";
			this.Text = "Bebida";
			this.Load += new System.EventHandler(this.FrmAltaBebida_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblAlcoholica;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Label lblPrecioUnitario;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.TextBox txtPrecioUnitario;
		private System.Windows.Forms.CheckBox ckbAlcoholica;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
	}
}