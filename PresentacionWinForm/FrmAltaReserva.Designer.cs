namespace PresentacionWinForm
{
	partial class FrmAltaReserva
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
			this.cbxCliente = new System.Windows.Forms.ComboBox();
			this.lblCliente = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbxCliente
			// 
			this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCliente.FormattingEnabled = true;
			this.cbxCliente.Location = new System.Drawing.Point(60, 12);
			this.cbxCliente.Name = "cbxCliente";
			this.cbxCliente.Size = new System.Drawing.Size(200, 21);
			this.cbxCliente.TabIndex = 0;
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(12, 15);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(42, 13);
			this.lblCliente.TabIndex = 1;
			this.lblCliente.Text = "Cliente:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(61, 39);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Fecha: ";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(61, 82);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(146, 82);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmAltaReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 117);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.cbxCliente);
			this.Name = "FrmAltaReserva";
			this.Text = "FrmAltaReserva";
			this.Load += new System.EventHandler(this.FrmAltaReserva_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxCliente;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
	}
}