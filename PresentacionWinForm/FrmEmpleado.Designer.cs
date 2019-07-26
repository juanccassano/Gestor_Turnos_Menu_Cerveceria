namespace PresentacionWinForm
{
	partial class FrmEmpleado
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
			this.lblLocalidad = new System.Windows.Forms.Label();
			this.lblFechaNac = new System.Windows.Forms.Label();
			this.lblTarea = new System.Windows.Forms.Label();
			this.lblNumeracion = new System.Windows.Forms.Label();
			this.lblFechaIng = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTarea = new System.Windows.Forms.TextBox();
			this.txtLocalidad = new System.Windows.Forms.TextBox();
			this.txtNumeracion = new System.Windows.Forms.TextBox();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaIng = new System.Windows.Forms.DateTimePicker();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblClave = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(12, 9);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(21, 13);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID:";
			// 
			// lblDNI
			// 
			this.lblDNI.AutoSize = true;
			this.lblDNI.Location = new System.Drawing.Point(12, 33);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.Size = new System.Drawing.Size(65, 13);
			this.lblDNI.TabIndex = 1;
			this.lblDNI.Text = "Documento:";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(12, 57);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(47, 13);
			this.lblApellido.TabIndex = 2;
			this.lblApellido.Text = "Apellido:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(12, 81);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(47, 13);
			this.lblNombre.TabIndex = 3;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(12, 105);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(52, 13);
			this.lblTelefono.TabIndex = 4;
			this.lblTelefono.Text = "Telefono:";
			// 
			// lblCalle
			// 
			this.lblCalle.AutoSize = true;
			this.lblCalle.Location = new System.Drawing.Point(12, 129);
			this.lblCalle.Name = "lblCalle";
			this.lblCalle.Size = new System.Drawing.Size(33, 13);
			this.lblCalle.TabIndex = 5;
			this.lblCalle.Text = "Calle:";
			// 
			// lblLocalidad
			// 
			this.lblLocalidad.AutoSize = true;
			this.lblLocalidad.Location = new System.Drawing.Point(12, 177);
			this.lblLocalidad.Name = "lblLocalidad";
			this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
			this.lblLocalidad.TabIndex = 6;
			this.lblLocalidad.Text = "Localidad:";
			// 
			// lblFechaNac
			// 
			this.lblFechaNac.AutoSize = true;
			this.lblFechaNac.Location = new System.Drawing.Point(12, 201);
			this.lblFechaNac.Name = "lblFechaNac";
			this.lblFechaNac.Size = new System.Drawing.Size(96, 13);
			this.lblFechaNac.TabIndex = 7;
			this.lblFechaNac.Text = "Fecha Nacimiento:";
			// 
			// lblTarea
			// 
			this.lblTarea.AutoSize = true;
			this.lblTarea.Location = new System.Drawing.Point(12, 225);
			this.lblTarea.Name = "lblTarea";
			this.lblTarea.Size = new System.Drawing.Size(41, 13);
			this.lblTarea.TabIndex = 8;
			this.lblTarea.Text = "Tarea: ";
			// 
			// lblNumeracion
			// 
			this.lblNumeracion.AutoSize = true;
			this.lblNumeracion.Location = new System.Drawing.Point(12, 153);
			this.lblNumeracion.Name = "lblNumeracion";
			this.lblNumeracion.Size = new System.Drawing.Size(67, 13);
			this.lblNumeracion.TabIndex = 9;
			this.lblNumeracion.Text = "Numeracion:";
			// 
			// lblFechaIng
			// 
			this.lblFechaIng.AutoSize = true;
			this.lblFechaIng.Location = new System.Drawing.Point(12, 249);
			this.lblFechaIng.Name = "lblFechaIng";
			this.lblFechaIng.Size = new System.Drawing.Size(81, 13);
			this.lblFechaIng.TabIndex = 10;
			this.lblFechaIng.Text = "Fecha Ingreso: ";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(91, 335);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 11;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(172, 335);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 12;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(114, 26);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(200, 20);
			this.txtDNI.TabIndex = 13;
			this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(114, 48);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(200, 20);
			this.txtApellido.TabIndex = 14;
			this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(114, 74);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(200, 20);
			this.txtNombre.TabIndex = 15;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// txtTarea
			// 
			this.txtTarea.Location = new System.Drawing.Point(114, 218);
			this.txtTarea.Name = "txtTarea";
			this.txtTarea.Size = new System.Drawing.Size(200, 20);
			this.txtTarea.TabIndex = 16;
			this.txtTarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarea_KeyPress);
			// 
			// txtLocalidad
			// 
			this.txtLocalidad.Location = new System.Drawing.Point(114, 170);
			this.txtLocalidad.Name = "txtLocalidad";
			this.txtLocalidad.Size = new System.Drawing.Size(200, 20);
			this.txtLocalidad.TabIndex = 17;
			this.txtLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalidad_KeyPress);
			// 
			// txtNumeracion
			// 
			this.txtNumeracion.Location = new System.Drawing.Point(114, 146);
			this.txtNumeracion.Name = "txtNumeracion";
			this.txtNumeracion.Size = new System.Drawing.Size(200, 20);
			this.txtNumeracion.TabIndex = 18;
			this.txtNumeracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeracion_KeyPress);
			// 
			// txtCalle
			// 
			this.txtCalle.Location = new System.Drawing.Point(114, 122);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(200, 20);
			this.txtCalle.TabIndex = 19;
			this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(114, 98);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(200, 20);
			this.txtTelefono.TabIndex = 20;
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
			// 
			// dtpFechaNac
			// 
			this.dtpFechaNac.Location = new System.Drawing.Point(114, 195);
			this.dtpFechaNac.Name = "dtpFechaNac";
			this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
			this.dtpFechaNac.TabIndex = 21;
			// 
			// dtpFechaIng
			// 
			this.dtpFechaIng.Location = new System.Drawing.Point(114, 242);
			this.dtpFechaIng.Name = "dtpFechaIng";
			this.dtpFechaIng.Size = new System.Drawing.Size(200, 20);
			this.dtpFechaIng.TabIndex = 22;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(12, 274);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(49, 13);
			this.lblUsuario.TabIndex = 23;
			this.lblUsuario.Text = "Usuario: ";
			// 
			// lblClave
			// 
			this.lblClave.AutoSize = true;
			this.lblClave.Location = new System.Drawing.Point(12, 300);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(40, 13);
			this.lblClave.TabIndex = 24;
			this.lblClave.Text = "Clave: ";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(114, 271);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(200, 20);
			this.txtUsuario.TabIndex = 25;
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(114, 297);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(200, 20);
			this.txtClave.TabIndex = 26;
			// 
			// FrmEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 370);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblClave);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.dtpFechaIng);
			this.Controls.Add(this.dtpFechaNac);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtCalle);
			this.Controls.Add(this.txtNumeracion);
			this.Controls.Add(this.txtLocalidad);
			this.Controls.Add(this.txtTarea);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblFechaIng);
			this.Controls.Add(this.lblNumeracion);
			this.Controls.Add(this.lblTarea);
			this.Controls.Add(this.lblFechaNac);
			this.Controls.Add(this.lblLocalidad);
			this.Controls.Add(this.lblCalle);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.lblDNI);
			this.Controls.Add(this.lblID);
			this.Name = "FrmEmpleado";
			this.Text = "FrmEmpleado";
			this.Load += new System.EventHandler(this.FrmEmpleado_Load);
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
		private System.Windows.Forms.Label lblLocalidad;
		private System.Windows.Forms.Label lblFechaNac;
		private System.Windows.Forms.Label lblTarea;
		private System.Windows.Forms.Label lblNumeracion;
		private System.Windows.Forms.Label lblFechaIng;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtTarea;
		private System.Windows.Forms.TextBox txtLocalidad;
		private System.Windows.Forms.TextBox txtNumeracion;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.DateTimePicker dtpFechaNac;
		private System.Windows.Forms.DateTimePicker dtpFechaIng;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblClave;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtClave;
	}
}