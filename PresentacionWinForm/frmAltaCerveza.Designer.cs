namespace PresentacionWinForm
{
	partial class frmAltaCerveza
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
			this.lblID = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblGraduacionAlcoholica = new System.Windows.Forms.Label();
			this.lblPrecioUnitario = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTipo = new System.Windows.Forms.TextBox();
			this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
			this.txtGraduacionAlcoholica = new System.Windows.Forms.TextBox();
			this.lblAceptar = new System.Windows.Forms.Button();
			this.lblCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(3, 9);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(24, 13);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID: ";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(3, 31);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(50, 13);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre: ";
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Location = new System.Drawing.Point(3, 50);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(34, 13);
			this.lblTipo.TabIndex = 2;
			this.lblTipo.Text = "Tipo: ";
			// 
			// lblGraduacionAlcoholica
			// 
			this.lblGraduacionAlcoholica.AutoSize = true;
			this.lblGraduacionAlcoholica.Location = new System.Drawing.Point(3, 79);
			this.lblGraduacionAlcoholica.Name = "lblGraduacionAlcoholica";
			this.lblGraduacionAlcoholica.Size = new System.Drawing.Size(119, 13);
			this.lblGraduacionAlcoholica.TabIndex = 3;
			this.lblGraduacionAlcoholica.Text = "Graduacion alcoholica: ";
			// 
			// lblPrecioUnitario
			// 
			this.lblPrecioUnitario.AutoSize = true;
			this.lblPrecioUnitario.Location = new System.Drawing.Point(3, 102);
			this.lblPrecioUnitario.Name = "lblPrecioUnitario";
			this.lblPrecioUnitario.Size = new System.Drawing.Size(80, 13);
			this.lblPrecioUnitario.TabIndex = 4;
			this.lblPrecioUnitario.Text = "Precio unitario: ";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(49, 24);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(181, 20);
			this.txtNombre.TabIndex = 5;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// txtTipo
			// 
			this.txtTipo.Location = new System.Drawing.Point(34, 50);
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.Size = new System.Drawing.Size(196, 20);
			this.txtTipo.TabIndex = 6;
			this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipo_KeyPress);
			// 
			// txtPrecioUnitario
			// 
			this.txtPrecioUnitario.Location = new System.Drawing.Point(79, 102);
			this.txtPrecioUnitario.Name = "txtPrecioUnitario";
			this.txtPrecioUnitario.Size = new System.Drawing.Size(151, 20);
			this.txtPrecioUnitario.TabIndex = 7;
			this.txtPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioUnitario_KeyPress);
			// 
			// txtGraduacionAlcoholica
			// 
			this.txtGraduacionAlcoholica.Location = new System.Drawing.Point(118, 76);
			this.txtGraduacionAlcoholica.Name = "txtGraduacionAlcoholica";
			this.txtGraduacionAlcoholica.Size = new System.Drawing.Size(112, 20);
			this.txtGraduacionAlcoholica.TabIndex = 8;
			this.txtGraduacionAlcoholica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGraduacionAlcoholica_KeyPress);
			// 
			// lblAceptar
			// 
			this.lblAceptar.Location = new System.Drawing.Point(47, 142);
			this.lblAceptar.Name = "lblAceptar";
			this.lblAceptar.Size = new System.Drawing.Size(75, 23);
			this.lblAceptar.TabIndex = 9;
			this.lblAceptar.Text = "Aceptar";
			this.lblAceptar.UseVisualStyleBackColor = true;
			this.lblAceptar.Click += new System.EventHandler(this.lblAceptar_Click);
			// 
			// lblCancelar
			// 
			this.lblCancelar.Location = new System.Drawing.Point(128, 142);
			this.lblCancelar.Name = "lblCancelar";
			this.lblCancelar.Size = new System.Drawing.Size(75, 23);
			this.lblCancelar.TabIndex = 10;
			this.lblCancelar.Text = "Cancelar";
			this.lblCancelar.UseVisualStyleBackColor = true;
			this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
			// 
			// frmAltaCerveza
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(242, 184);
			this.Controls.Add(this.lblCancelar);
			this.Controls.Add(this.lblAceptar);
			this.Controls.Add(this.txtGraduacionAlcoholica);
			this.Controls.Add(this.txtPrecioUnitario);
			this.Controls.Add(this.txtTipo);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblPrecioUnitario);
			this.Controls.Add(this.lblGraduacionAlcoholica);
			this.Controls.Add(this.lblTipo);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblID);
			this.Name = "frmAltaCerveza";
			this.Text = "frmAltaCerveza";
			this.Load += new System.EventHandler(this.frmAltaCerveza_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblGraduacionAlcoholica;
		private System.Windows.Forms.Label lblPrecioUnitario;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.TextBox txtPrecioUnitario;
		private System.Windows.Forms.TextBox txtGraduacionAlcoholica;
		private System.Windows.Forms.Button lblAceptar;
		private System.Windows.Forms.Button lblCancelar;
	}
}