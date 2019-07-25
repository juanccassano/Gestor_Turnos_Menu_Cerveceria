namespace PresentacionWinForm
{
	partial class FrmSalon
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
			this.btnMesa1 = new System.Windows.Forms.Button();
			this.btnMesa2 = new System.Windows.Forms.Button();
			this.btnMesa3 = new System.Windows.Forms.Button();
			this.btnMesa4 = new System.Windows.Forms.Button();
			this.btnMesa5 = new System.Windows.Forms.Button();
			this.btnMesa6 = new System.Windows.Forms.Button();
			this.btnMesa7 = new System.Windows.Forms.Button();
			this.btnMesa8 = new System.Windows.Forms.Button();
			this.btnCaja = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMesa1
			// 
			this.btnMesa1.Location = new System.Drawing.Point(12, 73);
			this.btnMesa1.Name = "btnMesa1";
			this.btnMesa1.Size = new System.Drawing.Size(146, 66);
			this.btnMesa1.TabIndex = 0;
			this.btnMesa1.Text = "Mesa 1";
			this.btnMesa1.UseVisualStyleBackColor = true;
			this.btnMesa1.Click += new System.EventHandler(this.btnMesa1_Click);
			// 
			// btnMesa2
			// 
			this.btnMesa2.Location = new System.Drawing.Point(166, 73);
			this.btnMesa2.Name = "btnMesa2";
			this.btnMesa2.Size = new System.Drawing.Size(146, 66);
			this.btnMesa2.TabIndex = 1;
			this.btnMesa2.Text = "Mesa 2";
			this.btnMesa2.UseVisualStyleBackColor = true;
			this.btnMesa2.Click += new System.EventHandler(this.btnMesa2_Click);
			// 
			// btnMesa3
			// 
			this.btnMesa3.Location = new System.Drawing.Point(12, 145);
			this.btnMesa3.Name = "btnMesa3";
			this.btnMesa3.Size = new System.Drawing.Size(146, 66);
			this.btnMesa3.TabIndex = 2;
			this.btnMesa3.Text = "Mesa 3";
			this.btnMesa3.UseVisualStyleBackColor = true;
			this.btnMesa3.Click += new System.EventHandler(this.btnMesa3_Click);
			// 
			// btnMesa4
			// 
			this.btnMesa4.Location = new System.Drawing.Point(166, 145);
			this.btnMesa4.Name = "btnMesa4";
			this.btnMesa4.Size = new System.Drawing.Size(146, 66);
			this.btnMesa4.TabIndex = 3;
			this.btnMesa4.Text = "Mesa 4";
			this.btnMesa4.UseVisualStyleBackColor = true;
			this.btnMesa4.Click += new System.EventHandler(this.btnMesa4_Click);
			// 
			// btnMesa5
			// 
			this.btnMesa5.Location = new System.Drawing.Point(12, 217);
			this.btnMesa5.Name = "btnMesa5";
			this.btnMesa5.Size = new System.Drawing.Size(146, 66);
			this.btnMesa5.TabIndex = 4;
			this.btnMesa5.Text = "Mesa 5";
			this.btnMesa5.UseVisualStyleBackColor = true;
			this.btnMesa5.Click += new System.EventHandler(this.btnMesa5_Click);
			// 
			// btnMesa6
			// 
			this.btnMesa6.Location = new System.Drawing.Point(166, 217);
			this.btnMesa6.Name = "btnMesa6";
			this.btnMesa6.Size = new System.Drawing.Size(146, 66);
			this.btnMesa6.TabIndex = 5;
			this.btnMesa6.Text = "Mesa 6";
			this.btnMesa6.UseVisualStyleBackColor = true;
			this.btnMesa6.Click += new System.EventHandler(this.btnMesa6_Click);
			// 
			// btnMesa7
			// 
			this.btnMesa7.Location = new System.Drawing.Point(12, 289);
			this.btnMesa7.Name = "btnMesa7";
			this.btnMesa7.Size = new System.Drawing.Size(146, 66);
			this.btnMesa7.TabIndex = 6;
			this.btnMesa7.Text = "Mesa 7";
			this.btnMesa7.UseVisualStyleBackColor = true;
			this.btnMesa7.Click += new System.EventHandler(this.btnMesa7_Click);
			// 
			// btnMesa8
			// 
			this.btnMesa8.Location = new System.Drawing.Point(164, 289);
			this.btnMesa8.Name = "btnMesa8";
			this.btnMesa8.Size = new System.Drawing.Size(146, 66);
			this.btnMesa8.TabIndex = 7;
			this.btnMesa8.Text = "Mesa 8";
			this.btnMesa8.UseVisualStyleBackColor = true;
			this.btnMesa8.Click += new System.EventHandler(this.btnMesa8_Click);
			// 
			// btnCaja
			// 
			this.btnCaja.Location = new System.Drawing.Point(12, 12);
			this.btnCaja.Name = "btnCaja";
			this.btnCaja.Size = new System.Drawing.Size(300, 55);
			this.btnCaja.TabIndex = 8;
			this.btnCaja.Text = "Pedido en caja";
			this.btnCaja.UseVisualStyleBackColor = true;
			this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
			// 
			// FrmSalon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 365);
			this.Controls.Add(this.btnCaja);
			this.Controls.Add(this.btnMesa8);
			this.Controls.Add(this.btnMesa7);
			this.Controls.Add(this.btnMesa6);
			this.Controls.Add(this.btnMesa5);
			this.Controls.Add(this.btnMesa4);
			this.Controls.Add(this.btnMesa3);
			this.Controls.Add(this.btnMesa2);
			this.Controls.Add(this.btnMesa1);
			this.Name = "FrmSalon";
			this.Text = "Salon";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMesa1;
		private System.Windows.Forms.Button btnMesa2;
		private System.Windows.Forms.Button btnMesa3;
		private System.Windows.Forms.Button btnMesa4;
		private System.Windows.Forms.Button btnMesa5;
		private System.Windows.Forms.Button btnMesa6;
		private System.Windows.Forms.Button btnMesa7;
		private System.Windows.Forms.Button btnMesa8;
		private System.Windows.Forms.Button btnCaja;
	}
}