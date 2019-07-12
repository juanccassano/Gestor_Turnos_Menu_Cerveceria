namespace PresentacionWinForm
{
	partial class FrmOpcionPedido
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
			this.btnBebida = new System.Windows.Forms.Button();
			this.btnCerveza = new System.Windows.Forms.Button();
			this.btnPlato = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBebida
			// 
			this.btnBebida.Location = new System.Drawing.Point(12, 12);
			this.btnBebida.Name = "btnBebida";
			this.btnBebida.Size = new System.Drawing.Size(130, 58);
			this.btnBebida.TabIndex = 0;
			this.btnBebida.Text = "Bebida";
			this.btnBebida.UseVisualStyleBackColor = true;
			this.btnBebida.Click += new System.EventHandler(this.btnBebida_Click);
			// 
			// btnCerveza
			// 
			this.btnCerveza.Location = new System.Drawing.Point(148, 12);
			this.btnCerveza.Name = "btnCerveza";
			this.btnCerveza.Size = new System.Drawing.Size(130, 58);
			this.btnCerveza.TabIndex = 1;
			this.btnCerveza.Text = "Cerveza";
			this.btnCerveza.UseVisualStyleBackColor = true;
			this.btnCerveza.Click += new System.EventHandler(this.btnCerveza_Click);
			// 
			// btnPlato
			// 
			this.btnPlato.Location = new System.Drawing.Point(284, 12);
			this.btnPlato.Name = "btnPlato";
			this.btnPlato.Size = new System.Drawing.Size(130, 58);
			this.btnPlato.TabIndex = 2;
			this.btnPlato.Text = "Plato";
			this.btnPlato.UseVisualStyleBackColor = true;
			this.btnPlato.Click += new System.EventHandler(this.btnPlato_Click);
			// 
			// FrmOpcionPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 79);
			this.Controls.Add(this.btnPlato);
			this.Controls.Add(this.btnCerveza);
			this.Controls.Add(this.btnBebida);
			this.Name = "FrmOpcionPedido";
			this.Text = "FrmOpcionPedido";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOpcionPedido_FormClosed);
			this.Load += new System.EventHandler(this.FrmOpcionPedido_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBebida;
		private System.Windows.Forms.Button btnCerveza;
		private System.Windows.Forms.Button btnPlato;
	}
}