namespace PresentacionWinForm
{
    partial class FrmMesa
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
			this.lblMesaNumero = new System.Windows.Forms.Label();
			this.dgvMesa = new System.Windows.Forms.DataGridView();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblAtendidoPor = new System.Windows.Forms.Label();
			this.btnAbrirMesa = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			this.btnCerrarMesa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMesaNumero
			// 
			this.lblMesaNumero.AutoSize = true;
			this.lblMesaNumero.Location = new System.Drawing.Point(12, 9);
			this.lblMesaNumero.Name = "lblMesaNumero";
			this.lblMesaNumero.Size = new System.Drawing.Size(54, 13);
			this.lblMesaNumero.TabIndex = 0;
			this.lblMesaNumero.Text = "Mesa nºx:";
			// 
			// dgvMesa
			// 
			this.dgvMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMesa.Location = new System.Drawing.Point(12, 25);
			this.dgvMesa.Name = "dgvMesa";
			this.dgvMesa.Size = new System.Drawing.Size(418, 299);
			this.dgvMesa.TabIndex = 1;

			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(12, 336);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(37, 13);
			this.lblTotal.TabIndex = 2;
			this.lblTotal.Text = "Total: ";
			// 
			// lblAtendidoPor
			// 
			this.lblAtendidoPor.AutoSize = true;
			this.lblAtendidoPor.Location = new System.Drawing.Point(157, 336);
			this.lblAtendidoPor.Name = "lblAtendidoPor";
			this.lblAtendidoPor.Size = new System.Drawing.Size(73, 13);
			this.lblAtendidoPor.TabIndex = 3;
			this.lblAtendidoPor.Text = "Atendido por: ";
			// 
			// btnAbrirMesa
			// 
			this.btnAbrirMesa.Location = new System.Drawing.Point(436, 153);
			this.btnAbrirMesa.Name = "btnAbrirMesa";
			this.btnAbrirMesa.Size = new System.Drawing.Size(75, 23);
			this.btnAbrirMesa.TabIndex = 4;
			this.btnAbrirMesa.Text = "Abrir mesa";
			this.btnAbrirMesa.UseVisualStyleBackColor = true;
			// 
			// btnVer
			// 
			this.btnVer.Location = new System.Drawing.Point(436, 182);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(75, 23);
			this.btnVer.TabIndex = 5;
			this.btnVer.Text = "Ver";
			this.btnVer.UseVisualStyleBackColor = true;
			// 
			// btnCerrarMesa
			// 
			this.btnCerrarMesa.Location = new System.Drawing.Point(436, 211);
			this.btnCerrarMesa.Name = "btnCerrarMesa";
			this.btnCerrarMesa.Size = new System.Drawing.Size(75, 23);
			this.btnCerrarMesa.TabIndex = 7;
			this.btnCerrarMesa.Text = "Cerrar mesa";
			this.btnCerrarMesa.UseVisualStyleBackColor = true;
			// 
			// FrmMesa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 370);
			this.Controls.Add(this.btnCerrarMesa);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.btnAbrirMesa);
			this.Controls.Add(this.lblAtendidoPor);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.dgvMesa);
			this.Controls.Add(this.lblMesaNumero);
			this.Name = "FrmMesa";
			this.Text = "Mesa";
			this.Load += new System.EventHandler(this.FrmMesa_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesaNumero;
        private System.Windows.Forms.DataGridView dgvMesa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAtendidoPor;
        private System.Windows.Forms.Button btnAbrirMesa;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnCerrarMesa;
    }
}