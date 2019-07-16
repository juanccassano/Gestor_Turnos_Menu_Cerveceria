namespace PresentacionWinForm
{
	partial class FrmAltaProveedor
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
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblID = new System.Windows.Forms.Label();
			this.lblDNI = new System.Windows.Forms.Label();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblCalle = new System.Windows.Forms.Label();
			this.lblNumeracion = new System.Windows.Forms.Label();
			this.lblLocalidad = new System.Windows.Forms.Label();
			this.lblFechaNac = new System.Windows.Forms.Label();
			this.lblRubro = new System.Windows.Forms.Label();
			this.lblCUIT = new System.Windows.Forms.Label();
			this.gbxTipo = new System.Windows.Forms.GroupBox();
			this.rdbResponsableInsc = new System.Windows.Forms.RadioButton();
			this.rdbMonotributista = new System.Windows.Forms.RadioButton();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCUIT = new System.Windows.Forms.TextBox();
			this.txtLocalidad = new System.Windows.Forms.TextBox();
			this.txtRubro = new System.Windows.Forms.TextBox();
			this.txtNumeracion = new System.Windows.Forms.TextBox();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
			this.gbxTipo.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(100, 330);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(181, 330);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(12, 26);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(24, 13);
			this.lblID.TabIndex = 3;
			this.lblID.Text = "ID: ";
			// 
			// lblDNI
			// 
			this.lblDNI.AutoSize = true;
			this.lblDNI.Location = new System.Drawing.Point(12, 48);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.Size = new System.Drawing.Size(32, 13);
			this.lblDNI.TabIndex = 4;
			this.lblDNI.Text = "DNI: ";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(12, 70);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(47, 13);
			this.lblApellido.TabIndex = 5;
			this.lblApellido.Text = "Apellido:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(12, 92);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(50, 13);
			this.lblNombre.TabIndex = 6;
			this.lblNombre.Text = "Nombre: ";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(12, 114);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(55, 13);
			this.lblTelefono.TabIndex = 7;
			this.lblTelefono.Text = "Telefono: ";
			// 
			// lblCalle
			// 
			this.lblCalle.AutoSize = true;
			this.lblCalle.Location = new System.Drawing.Point(12, 136);
			this.lblCalle.Name = "lblCalle";
			this.lblCalle.Size = new System.Drawing.Size(36, 13);
			this.lblCalle.TabIndex = 8;
			this.lblCalle.Text = "Calle: ";
			// 
			// lblNumeracion
			// 
			this.lblNumeracion.AutoSize = true;
			this.lblNumeracion.Location = new System.Drawing.Point(12, 158);
			this.lblNumeracion.Name = "lblNumeracion";
			this.lblNumeracion.Size = new System.Drawing.Size(70, 13);
			this.lblNumeracion.TabIndex = 9;
			this.lblNumeracion.Text = "Numeracion: ";
			// 
			// lblLocalidad
			// 
			this.lblLocalidad.AutoSize = true;
			this.lblLocalidad.Location = new System.Drawing.Point(12, 180);
			this.lblLocalidad.Name = "lblLocalidad";
			this.lblLocalidad.Size = new System.Drawing.Size(59, 13);
			this.lblLocalidad.TabIndex = 10;
			this.lblLocalidad.Text = "Localidad: ";
			// 
			// lblFechaNac
			// 
			this.lblFechaNac.AutoSize = true;
			this.lblFechaNac.Location = new System.Drawing.Point(12, 205);
			this.lblFechaNac.Name = "lblFechaNac";
			this.lblFechaNac.Size = new System.Drawing.Size(112, 13);
			this.lblFechaNac.TabIndex = 11;
			this.lblFechaNac.Text = "Fecha de nacimiento: ";
			// 
			// lblRubro
			// 
			this.lblRubro.AutoSize = true;
			this.lblRubro.Location = new System.Drawing.Point(12, 224);
			this.lblRubro.Name = "lblRubro";
			this.lblRubro.Size = new System.Drawing.Size(42, 13);
			this.lblRubro.TabIndex = 12;
			this.lblRubro.Text = "Rubro: ";
			// 
			// lblCUIT
			// 
			this.lblCUIT.AutoSize = true;
			this.lblCUIT.Location = new System.Drawing.Point(12, 302);
			this.lblCUIT.Name = "lblCUIT";
			this.lblCUIT.Size = new System.Drawing.Size(38, 13);
			this.lblCUIT.TabIndex = 15;
			this.lblCUIT.Text = "CUIT: ";
			// 
			// gbxTipo
			// 
			this.gbxTipo.Controls.Add(this.rdbResponsableInsc);
			this.gbxTipo.Controls.Add(this.rdbMonotributista);
			this.gbxTipo.Location = new System.Drawing.Point(15, 247);
			this.gbxTipo.Name = "gbxTipo";
			this.gbxTipo.Size = new System.Drawing.Size(309, 47);
			this.gbxTipo.TabIndex = 16;
			this.gbxTipo.TabStop = false;
			this.gbxTipo.Text = "Tipo:";
			// 
			// rdbResponsableInsc
			// 
			this.rdbResponsableInsc.AutoSize = true;
			this.rdbResponsableInsc.Location = new System.Drawing.Point(138, 19);
			this.rdbResponsableInsc.Name = "rdbResponsableInsc";
			this.rdbResponsableInsc.Size = new System.Drawing.Size(130, 17);
			this.rdbResponsableInsc.TabIndex = 1;
			this.rdbResponsableInsc.TabStop = true;
			this.rdbResponsableInsc.Text = "Responsable Inscripto";
			this.rdbResponsableInsc.UseVisualStyleBackColor = true;
			// 
			// rdbMonotributista
			// 
			this.rdbMonotributista.AutoSize = true;
			this.rdbMonotributista.Location = new System.Drawing.Point(41, 19);
			this.rdbMonotributista.Name = "rdbMonotributista";
			this.rdbMonotributista.Size = new System.Drawing.Size(91, 17);
			this.rdbMonotributista.TabIndex = 0;
			this.rdbMonotributista.TabStop = true;
			this.rdbMonotributista.Text = "Monotributista";
			this.rdbMonotributista.UseVisualStyleBackColor = true;
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(77, 45);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(241, 20);
			this.txtDNI.TabIndex = 17;
			this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(77, 67);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(241, 20);
			this.txtApellido.TabIndex = 18;
			this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(77, 89);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(241, 20);
			this.txtNombre.TabIndex = 19;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// txtCUIT
			// 
			this.txtCUIT.Location = new System.Drawing.Point(77, 299);
			this.txtCUIT.Name = "txtCUIT";
			this.txtCUIT.Size = new System.Drawing.Size(241, 20);
			this.txtCUIT.TabIndex = 20;
			this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
			// 
			// txtLocalidad
			// 
			this.txtLocalidad.Location = new System.Drawing.Point(77, 177);
			this.txtLocalidad.Name = "txtLocalidad";
			this.txtLocalidad.Size = new System.Drawing.Size(241, 20);
			this.txtLocalidad.TabIndex = 21;
			this.txtLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalidad_KeyPress);
			// 
			// txtRubro
			// 
			this.txtRubro.Location = new System.Drawing.Point(77, 221);
			this.txtRubro.Name = "txtRubro";
			this.txtRubro.Size = new System.Drawing.Size(241, 20);
			this.txtRubro.TabIndex = 22;
			this.txtRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRubro_KeyPress);
			// 
			// txtNumeracion
			// 
			this.txtNumeracion.Location = new System.Drawing.Point(77, 155);
			this.txtNumeracion.Name = "txtNumeracion";
			this.txtNumeracion.Size = new System.Drawing.Size(241, 20);
			this.txtNumeracion.TabIndex = 23;
			this.txtNumeracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeracion_KeyPress);
			// 
			// txtCalle
			// 
			this.txtCalle.Location = new System.Drawing.Point(77, 133);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(241, 20);
			this.txtCalle.TabIndex = 24;
			this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(77, 111);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(241, 20);
			this.txtTelefono.TabIndex = 25;
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
			// 
			// dtpFechaNac
			// 
			this.dtpFechaNac.Location = new System.Drawing.Point(118, 199);
			this.dtpFechaNac.Name = "dtpFechaNac";
			this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
			this.dtpFechaNac.TabIndex = 26;
			// 
			// FrmAltaProveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 363);
			this.Controls.Add(this.dtpFechaNac);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtCalle);
			this.Controls.Add(this.txtNumeracion);
			this.Controls.Add(this.txtRubro);
			this.Controls.Add(this.txtLocalidad);
			this.Controls.Add(this.txtCUIT);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.gbxTipo);
			this.Controls.Add(this.lblCUIT);
			this.Controls.Add(this.lblRubro);
			this.Controls.Add(this.lblFechaNac);
			this.Controls.Add(this.lblLocalidad);
			this.Controls.Add(this.lblNumeracion);
			this.Controls.Add(this.lblCalle);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.lblDNI);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Name = "FrmAltaProveedor";
			this.Text = "FrmAltaProveedor";
			this.Load += new System.EventHandler(this.FrmAltaProveedor_Load);
			this.gbxTipo.ResumeLayout(false);
			this.gbxTipo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblDNI;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblCalle;
		private System.Windows.Forms.Label lblNumeracion;
		private System.Windows.Forms.Label lblLocalidad;
		private System.Windows.Forms.Label lblFechaNac;
		private System.Windows.Forms.Label lblRubro;
		private System.Windows.Forms.Label lblCUIT;
		private System.Windows.Forms.GroupBox gbxTipo;
		private System.Windows.Forms.RadioButton rdbResponsableInsc;
		private System.Windows.Forms.RadioButton rdbMonotributista;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCUIT;
		private System.Windows.Forms.TextBox txtLocalidad;
		private System.Windows.Forms.TextBox txtRubro;
		private System.Windows.Forms.TextBox txtNumeracion;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.DateTimePicker dtpFechaNac;
	}
}