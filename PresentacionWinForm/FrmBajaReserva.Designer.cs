namespace PresentacionWinForm
{
	partial class FrmBajaReserva
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
			this.btnSi = new System.Windows.Forms.Button();
			this.btnNo = new System.Windows.Forms.Button();
			this.lblMensaje = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSi
			// 
			this.btnSi.Location = new System.Drawing.Point(62, 69);
			this.btnSi.Name = "btnSi";
			this.btnSi.Size = new System.Drawing.Size(75, 23);
			this.btnSi.TabIndex = 0;
			this.btnSi.Text = "Si";
			this.btnSi.UseVisualStyleBackColor = true;
			this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
			// 
			// btnNo
			// 
			this.btnNo.Location = new System.Drawing.Point(143, 69);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(75, 23);
			this.btnNo.TabIndex = 1;
			this.btnNo.Text = "No";
			this.btnNo.UseVisualStyleBackColor = true;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// lblMensaje
			// 
			this.lblMensaje.AutoSize = true;
			this.lblMensaje.Location = new System.Drawing.Point(12, 19);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(47, 13);
			this.lblMensaje.TabIndex = 2;
			this.lblMensaje.Text = "Mensaje";
			this.lblMensaje.Click += new System.EventHandler(this.lblMensaje_Click);
			// 
			// FrmBajaReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 100);
			this.Controls.Add(this.lblMensaje);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.btnSi);
			this.Name = "FrmBajaReserva";
			this.Text = "FrmBajaReserva";
			this.Load += new System.EventHandler(this.FrmBajaReserva_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSi;
		private System.Windows.Forms.Button btnNo;
		private System.Windows.Forms.Label lblMensaje;
	}
}