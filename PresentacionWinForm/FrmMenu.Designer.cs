namespace PresentacionWinForm
{
    partial class FrmMenu
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
            this.lblEnvios = new System.Windows.Forms.Label();
            this.lblSalon = new System.Windows.Forms.Label();
            this.btnSalon = new System.Windows.Forms.Button();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnvios
            // 
            this.lblEnvios.AutoSize = true;
            this.lblEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvios.Location = new System.Drawing.Point(179, 73);
            this.lblEnvios.Name = "lblEnvios";
            this.lblEnvios.Size = new System.Drawing.Size(39, 13);
            this.lblEnvios.TabIndex = 2;
            this.lblEnvios.Text = "Envios";
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalon.Location = new System.Drawing.Point(562, 73);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(34, 13);
            this.lblSalon.TabIndex = 3;
            this.lblSalon.Text = "Salón";
            // 
            // btnSalon
            // 
            this.btnSalon.Image = global::PresentacionWinForm.Properties.Resources.Cerveza;
            this.btnSalon.Location = new System.Drawing.Point(409, 99);
            this.btnSalon.Name = "btnSalon";
            this.btnSalon.Size = new System.Drawing.Size(326, 320);
            this.btnSalon.TabIndex = 1;
            this.btnSalon.UseVisualStyleBackColor = true;
            this.btnSalon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSalon_MouseClick);
            // 
            // btnEnvios
            // 
            this.btnEnvios.Image = global::PresentacionWinForm.Properties.Resources.Moto;
            this.btnEnvios.Location = new System.Drawing.Point(32, 99);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(323, 320);
            this.btnEnvios.TabIndex = 0;
            this.btnEnvios.UseVisualStyleBackColor = true;
            this.btnEnvios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEnvios_MouseClick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 461);
            this.Controls.Add(this.lblSalon);
            this.Controls.Add(this.lblEnvios);
            this.Controls.Add(this.btnSalon);
            this.Controls.Add(this.btnEnvios);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvios;
        private System.Windows.Forms.Button btnSalon;
        private System.Windows.Forms.Label lblEnvios;
        private System.Windows.Forms.Label lblSalon;
    }
}