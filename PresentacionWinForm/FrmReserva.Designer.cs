namespace PresentacionWinForm
{
	partial class FrmReserva
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
			this.dgvReserva = new System.Windows.Forms.DataGridView();
			this.lblMesas = new System.Windows.Forms.Label();
			this.btnReservada = new System.Windows.Forms.Button();
			this.btnDesocupada = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvReserva
			// 
			this.dgvReserva.AllowUserToDeleteRows = false;
			this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReserva.Location = new System.Drawing.Point(12, 35);
			this.dgvReserva.Name = "dgvReserva";
			this.dgvReserva.ReadOnly = true;
			this.dgvReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvReserva.Size = new System.Drawing.Size(398, 277);
			this.dgvReserva.TabIndex = 0;
			// 
			// lblMesas
			// 
			this.lblMesas.AutoSize = true;
			this.lblMesas.Location = new System.Drawing.Point(12, 9);
			this.lblMesas.Name = "lblMesas";
			this.lblMesas.Size = new System.Drawing.Size(41, 13);
			this.lblMesas.TabIndex = 1;
			this.lblMesas.Text = "Mesas:";
			// 
			// btnReservada
			// 
			this.btnReservada.Location = new System.Drawing.Point(416, 142);
			this.btnReservada.Name = "btnReservada";
			this.btnReservada.Size = new System.Drawing.Size(89, 23);
			this.btnReservada.TabIndex = 2;
			this.btnReservada.Text = "Reservar";
			this.btnReservada.UseVisualStyleBackColor = true;
			this.btnReservada.Click += new System.EventHandler(this.btnReservada_Click);
			// 
			// btnDesocupada
			// 
			this.btnDesocupada.Location = new System.Drawing.Point(416, 200);
			this.btnDesocupada.Name = "btnDesocupada";
			this.btnDesocupada.Size = new System.Drawing.Size(89, 23);
			this.btnDesocupada.TabIndex = 3;
			this.btnDesocupada.Text = "Desocupar";
			this.btnDesocupada.UseVisualStyleBackColor = true;
			this.btnDesocupada.Click += new System.EventHandler(this.btnDesocupada_Click);
			// 
			// btnVer
			// 
			this.btnVer.Location = new System.Drawing.Point(416, 171);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(89, 23);
			this.btnVer.TabIndex = 4;
			this.btnVer.Text = "Ver reserva";
			this.btnVer.UseVisualStyleBackColor = true;
			this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
			// 
			// FrmReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 322);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.btnDesocupada);
			this.Controls.Add(this.btnReservada);
			this.Controls.Add(this.lblMesas);
			this.Controls.Add(this.dgvReserva);
			this.Name = "FrmReserva";
			this.Text = "FrmReserva";
			this.Load += new System.EventHandler(this.FrmReserva_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvReserva;
		private System.Windows.Forms.Label lblMesas;
		private System.Windows.Forms.Button btnReservada;
		private System.Windows.Forms.Button btnDesocupada;
		private System.Windows.Forms.Button btnVer;
	}
}