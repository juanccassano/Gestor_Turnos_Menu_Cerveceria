namespace PresentacionWinForm
{
	partial class FrmAltaCliente
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
			this.lblDNI = new System.Windows.Forms.Label();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblCalle = new System.Windows.Forms.Label();
			this.lblNumeracion = new System.Windows.Forms.Label();
			this.lblLocalidad = new System.Windows.Forms.Label();
			this.lblFechaNac = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.txtNumeracion = new System.Windows.Forms.TextBox();
			this.txtLocalidad = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(47, 9);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(24, 13);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID: ";
			// 
			// lblDNI
			// 
			this.lblDNI.AutoSize = true;
			this.lblDNI.Location = new System.Drawing.Point(39, 29);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.Size = new System.Drawing.Size(32, 13);
			this.lblDNI.TabIndex = 1;
			this.lblDNI.Text = "DNI: ";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(21, 56);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(50, 13);
			this.lblApellido.TabIndex = 2;
			this.lblApellido.Text = "Apellido: ";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(21, 81);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(50, 13);
			this.lblNombre.TabIndex = 3;
			this.lblNombre.Text = "Nombre: ";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(16, 107);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(55, 13);
			this.lblTelefono.TabIndex = 4;
			this.lblTelefono.Text = "Telefono: ";
			// 
			// lblCalle
			// 
			this.lblCalle.AutoSize = true;
			this.lblCalle.Location = new System.Drawing.Point(35, 133);
			this.lblCalle.Name = "lblCalle";
			this.lblCalle.Size = new System.Drawing.Size(36, 13);
			this.lblCalle.TabIndex = 5;
			this.lblCalle.Text = "Calle: ";
			// 
			// lblNumeracion
			// 
			this.lblNumeracion.AutoSize = true;
			this.lblNumeracion.Location = new System.Drawing.Point(5, 159);
			this.lblNumeracion.Name = "lblNumeracion";
			this.lblNumeracion.Size = new System.Drawing.Size(70, 13);
			this.lblNumeracion.TabIndex = 6;
			this.lblNumeracion.Text = "Numeracion: ";
			// 
			// lblLocalidad
			// 
			this.lblLocalidad.AutoSize = true;
			this.lblLocalidad.Location = new System.Drawing.Point(12, 185);
			this.lblLocalidad.Name = "lblLocalidad";
			this.lblLocalidad.Size = new System.Drawing.Size(59, 13);
			this.lblLocalidad.TabIndex = 7;
			this.lblLocalidad.Text = "Localidad: ";
			// 
			// lblFechaNac
			// 
			this.lblFechaNac.AutoSize = true;
			this.lblFechaNac.Location = new System.Drawing.Point(15, 214);
			this.lblFechaNac.Name = "lblFechaNac";
			this.lblFechaNac.Size = new System.Drawing.Size(109, 13);
			this.lblFechaNac.TabIndex = 8;
			this.lblFechaNac.Text = "Fecha de nacimiento:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(235, 267);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(0, 13);
			this.label10.TabIndex = 9;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(259, 302);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(0, 13);
			this.label11.TabIndex = 10;
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(75, 29);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(255, 20);
			this.txtDNI.TabIndex = 11;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(75, 53);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(255, 20);
			this.txtApellido.TabIndex = 12;
			// 
			// dtpFechaNac
			// 
			this.dtpFechaNac.Location = new System.Drawing.Point(130, 208);
			this.dtpFechaNac.Name = "dtpFechaNac";
			this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
			this.dtpFechaNac.TabIndex = 13;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(75, 78);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(255, 20);
			this.txtNombre.TabIndex = 14;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(75, 104);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(255, 20);
			this.txtTelefono.TabIndex = 15;
			// 
			// txtCalle
			// 
			this.txtCalle.Location = new System.Drawing.Point(75, 130);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(255, 20);
			this.txtCalle.TabIndex = 16;
			// 
			// txtNumeracion
			// 
			this.txtNumeracion.Location = new System.Drawing.Point(75, 156);
			this.txtNumeracion.Name = "txtNumeracion";
			this.txtNumeracion.Size = new System.Drawing.Size(255, 20);
			this.txtNumeracion.TabIndex = 17;
			// 
			// txtLocalidad
			// 
			this.txtLocalidad.Location = new System.Drawing.Point(75, 182);
			this.txtLocalidad.Name = "txtLocalidad";
			this.txtLocalidad.Size = new System.Drawing.Size(255, 20);
			this.txtLocalidad.TabIndex = 18;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(96, 257);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 19;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(184, 257);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 20;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmAltaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 298);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtLocalidad);
			this.Controls.Add(this.txtNumeracion);
			this.Controls.Add(this.txtCalle);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.dtpFechaNac);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblFechaNac);
			this.Controls.Add(this.lblLocalidad);
			this.Controls.Add(this.lblNumeracion);
			this.Controls.Add(this.lblCalle);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.lblDNI);
			this.Controls.Add(this.lblID);
			this.Name = "FrmAltaCliente";
			this.Text = "FrmAltaCliente";
			this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblDNI;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblCalle;
		private System.Windows.Forms.Label lblNumeracion;
		private System.Windows.Forms.Label lblLocalidad;
		private System.Windows.Forms.Label lblFechaNac;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.DateTimePicker dtpFechaNac;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.TextBox txtNumeracion;
		private System.Windows.Forms.TextBox txtLocalidad;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
	}
}