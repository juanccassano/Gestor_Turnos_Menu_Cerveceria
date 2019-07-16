namespace PresentacionWinForm
{
	partial class FrmAgregarCerveza
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
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblGraduacionAlcoholica = new System.Windows.Forms.Label();
			this.lblPrecioUnitario = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.cbxCerveza = new System.Windows.Forms.ComboBox();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(12, 9);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(47, 13);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Location = new System.Drawing.Point(12, 31);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(34, 13);
			this.lblTipo.TabIndex = 1;
			this.lblTipo.Text = "Tipo: ";
			// 
			// lblGraduacionAlcoholica
			// 
			this.lblGraduacionAlcoholica.AutoSize = true;
			this.lblGraduacionAlcoholica.Location = new System.Drawing.Point(12, 53);
			this.lblGraduacionAlcoholica.Name = "lblGraduacionAlcoholica";
			this.lblGraduacionAlcoholica.Size = new System.Drawing.Size(117, 13);
			this.lblGraduacionAlcoholica.TabIndex = 2;
			this.lblGraduacionAlcoholica.Text = "Graduacion Alcoholica:";
			// 
			// lblPrecioUnitario
			// 
			this.lblPrecioUnitario.AutoSize = true;
			this.lblPrecioUnitario.Location = new System.Drawing.Point(12, 77);
			this.lblPrecioUnitario.Name = "lblPrecioUnitario";
			this.lblPrecioUnitario.Size = new System.Drawing.Size(82, 13);
			this.lblPrecioUnitario.TabIndex = 3;
			this.lblPrecioUnitario.Text = "Precio Unitario: ";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(15, 129);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(96, 129);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// cbxCerveza
			// 
			this.cbxCerveza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCerveza.FormattingEnabled = true;
			this.cbxCerveza.Location = new System.Drawing.Point(65, 6);
			this.cbxCerveza.Name = "cbxCerveza";
			this.cbxCerveza.Size = new System.Drawing.Size(121, 21);
			this.cbxCerveza.TabIndex = 6;
			this.cbxCerveza.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Location = new System.Drawing.Point(12, 99);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(49, 13);
			this.lblCantidad.TabIndex = 7;
			this.lblCantidad.Text = "Cantidad";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(65, 93);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(121, 20);
			this.txtCantidad.TabIndex = 8;
			this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
			// 
			// FrmAgregarCerveza
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(191, 164);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.cbxCerveza);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblPrecioUnitario);
			this.Controls.Add(this.lblGraduacionAlcoholica);
			this.Controls.Add(this.lblTipo);
			this.Controls.Add(this.lblNombre);
			this.Name = "FrmAgregarCerveza";
			this.Text = "FrmAgregarCerveza";
			this.Load += new System.EventHandler(this.FrmAgregarCerveza_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblGraduacionAlcoholica;
		private System.Windows.Forms.Label lblPrecioUnitario;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.ComboBox cbxCerveza;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtCantidad;
	}
}