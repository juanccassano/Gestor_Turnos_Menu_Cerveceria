namespace PresentacionWinForm
{
	partial class FrmVerReserva
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
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblReserva = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(12, 31);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(39, 13);
			this.lblCliente.TabIndex = 0;
			this.lblCliente.Text = "Cliente";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(12, 55);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(37, 13);
			this.lblFecha.TabIndex = 1;
			this.lblFecha.Text = "Fecha";
			// 
			// lblReserva
			// 
			this.lblReserva.AutoSize = true;
			this.lblReserva.Location = new System.Drawing.Point(12, 9);
			this.lblReserva.Name = "lblReserva";
			this.lblReserva.Size = new System.Drawing.Size(79, 13);
			this.lblReserva.TabIndex = 2;
			this.lblReserva.Text = "Reserva actual";
			// 
			// FrmVerReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(251, 90);
			this.Controls.Add(this.lblReserva);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblCliente);
			this.Name = "FrmVerReserva";
			this.Text = "FrmVerReserva";
			this.Load += new System.EventHandler(this.FrmVerReserva_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lblReserva;
	}
}