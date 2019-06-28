namespace PresentacionWinForm
{
	partial class FrmAgregarPlato
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
			this.lblAptoCeliacos = new System.Windows.Forms.Label();
			this.lblOpcionVegetariana = new System.Windows.Forms.Label();
			this.lblPrecioUnitario = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.cbxNombre = new System.Windows.Forms.ComboBox();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(12, 20);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(47, 13);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblAptoCeliacos
			// 
			this.lblAptoCeliacos.AutoSize = true;
			this.lblAptoCeliacos.Location = new System.Drawing.Point(12, 43);
			this.lblAptoCeliacos.Name = "lblAptoCeliacos";
			this.lblAptoCeliacos.Size = new System.Drawing.Size(75, 13);
			this.lblAptoCeliacos.TabIndex = 1;
			this.lblAptoCeliacos.Text = "Apto Celiacos:";
			// 
			// lblOpcionVegetariana
			// 
			this.lblOpcionVegetariana.AutoSize = true;
			this.lblOpcionVegetariana.Location = new System.Drawing.Point(12, 65);
			this.lblOpcionVegetariana.Name = "lblOpcionVegetariana";
			this.lblOpcionVegetariana.Size = new System.Drawing.Size(104, 13);
			this.lblOpcionVegetariana.TabIndex = 2;
			this.lblOpcionVegetariana.Text = "Opcion Vegetariana:";
			// 
			// lblPrecioUnitario
			// 
			this.lblPrecioUnitario.AutoSize = true;
			this.lblPrecioUnitario.Location = new System.Drawing.Point(12, 89);
			this.lblPrecioUnitario.Name = "lblPrecioUnitario";
			this.lblPrecioUnitario.Size = new System.Drawing.Size(82, 13);
			this.lblPrecioUnitario.TabIndex = 3;
			this.lblPrecioUnitario.Text = "Precio Unitario: ";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(15, 138);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(96, 138);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// cbxNombre
			// 
			this.cbxNombre.FormattingEnabled = true;
			this.cbxNombre.Location = new System.Drawing.Point(65, 17);
			this.cbxNombre.Name = "cbxNombre";
			this.cbxNombre.Size = new System.Drawing.Size(121, 21);
			this.cbxNombre.TabIndex = 6;
			this.cbxNombre.SelectedValueChanged += new System.EventHandler(this.cbxNombre_SelectedValueChanged);
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Location = new System.Drawing.Point(12, 111);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(52, 13);
			this.lblCantidad.TabIndex = 9;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(65, 108);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(121, 20);
			this.txtCantidad.TabIndex = 10;
			// 
			// FrmAgregarPlato
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(193, 173);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.cbxNombre);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblPrecioUnitario);
			this.Controls.Add(this.lblOpcionVegetariana);
			this.Controls.Add(this.lblAptoCeliacos);
			this.Controls.Add(this.lblNombre);
			this.Name = "FrmAgregarPlato";
			this.Text = "FrmAgregarPlato";
			this.Load += new System.EventHandler(this.FrmAgregarPlato_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblAptoCeliacos;
		private System.Windows.Forms.Label lblOpcionVegetariana;
		private System.Windows.Forms.Label lblPrecioUnitario;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.ComboBox cbxNombre;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtCantidad;
	}
}