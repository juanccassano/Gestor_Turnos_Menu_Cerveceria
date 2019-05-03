namespace PresentacionWinForm
{
    partial class FrmEnvio
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
            this.lblEnviosPendientes = new System.Windows.Forms.Label();
            this.lblEnviosRealizados = new System.Windows.Forms.Label();
            this.dgvEnviosPendientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarIzq = new System.Windows.Forms.Button();
            this.btnModificarIzq = new System.Windows.Forms.Button();
            this.btnBorrarIzq = new System.Windows.Forms.Button();
            this.btnEntregadoIzq = new System.Windows.Forms.Button();
            this.btnDetalleIzq = new System.Windows.Forms.Button();
            this.btnModificarDer = new System.Windows.Forms.Button();
            this.btnBorrarDer = new System.Windows.Forms.Button();
            this.btnDetalleDer = new System.Windows.Forms.Button();
            this.dgvEnviosRealizados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosRealizados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnviosPendientes
            // 
            this.lblEnviosPendientes.AutoSize = true;
            this.lblEnviosPendientes.Location = new System.Drawing.Point(132, 9);
            this.lblEnviosPendientes.Name = "lblEnviosPendientes";
            this.lblEnviosPendientes.Size = new System.Drawing.Size(98, 13);
            this.lblEnviosPendientes.TabIndex = 0;
            this.lblEnviosPendientes.Text = "Envios Pendientes:";
            // 
            // lblEnviosRealizados
            // 
            this.lblEnviosRealizados.AutoSize = true;
            this.lblEnviosRealizados.Location = new System.Drawing.Point(546, 9);
            this.lblEnviosRealizados.Name = "lblEnviosRealizados";
            this.lblEnviosRealizados.Size = new System.Drawing.Size(99, 13);
            this.lblEnviosRealizados.TabIndex = 1;
            this.lblEnviosRealizados.Text = "Envíos Realizados:";
            // 
            // dgvEnviosPendientes
            // 
            this.dgvEnviosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnviosPendientes.Location = new System.Drawing.Point(12, 35);
            this.dgvEnviosPendientes.Name = "dgvEnviosPendientes";
            this.dgvEnviosPendientes.Size = new System.Drawing.Size(309, 356);
            this.dgvEnviosPendientes.TabIndex = 2;
            this.dgvEnviosPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnviosPendientes_CellContentClick);
            // 
            // btnAgregarIzq
            // 
            this.btnAgregarIzq.Location = new System.Drawing.Point(327, 87);
            this.btnAgregarIzq.Name = "btnAgregarIzq";
            this.btnAgregarIzq.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIzq.TabIndex = 4;
            this.btnAgregarIzq.Text = "< Agregar";
            this.btnAgregarIzq.UseVisualStyleBackColor = true;
            // 
            // btnModificarIzq
            // 
            this.btnModificarIzq.Location = new System.Drawing.Point(327, 116);
            this.btnModificarIzq.Name = "btnModificarIzq";
            this.btnModificarIzq.Size = new System.Drawing.Size(75, 23);
            this.btnModificarIzq.TabIndex = 5;
            this.btnModificarIzq.Text = "< Modificar";
            this.btnModificarIzq.UseVisualStyleBackColor = true;
            // 
            // btnBorrarIzq
            // 
            this.btnBorrarIzq.Location = new System.Drawing.Point(327, 145);
            this.btnBorrarIzq.Name = "btnBorrarIzq";
            this.btnBorrarIzq.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarIzq.TabIndex = 6;
            this.btnBorrarIzq.Text = "< Borrar";
            this.btnBorrarIzq.UseVisualStyleBackColor = true;
            // 
            // btnEntregadoIzq
            // 
            this.btnEntregadoIzq.Location = new System.Drawing.Point(327, 174);
            this.btnEntregadoIzq.Name = "btnEntregadoIzq";
            this.btnEntregadoIzq.Size = new System.Drawing.Size(75, 23);
            this.btnEntregadoIzq.TabIndex = 7;
            this.btnEntregadoIzq.Text = "< Entregado";
            this.btnEntregadoIzq.UseVisualStyleBackColor = true;
            // 
            // btnDetalleIzq
            // 
            this.btnDetalleIzq.Location = new System.Drawing.Point(327, 203);
            this.btnDetalleIzq.Name = "btnDetalleIzq";
            this.btnDetalleIzq.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleIzq.TabIndex = 8;
            this.btnDetalleIzq.Text = "< Detalle";
            this.btnDetalleIzq.UseVisualStyleBackColor = true;
            // 
            // btnModificarDer
            // 
            this.btnModificarDer.Location = new System.Drawing.Point(327, 232);
            this.btnModificarDer.Name = "btnModificarDer";
            this.btnModificarDer.Size = new System.Drawing.Size(75, 23);
            this.btnModificarDer.TabIndex = 9;
            this.btnModificarDer.Text = "Modificar >";
            this.btnModificarDer.UseVisualStyleBackColor = true;
            // 
            // btnBorrarDer
            // 
            this.btnBorrarDer.Location = new System.Drawing.Point(327, 261);
            this.btnBorrarDer.Name = "btnBorrarDer";
            this.btnBorrarDer.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarDer.TabIndex = 10;
            this.btnBorrarDer.Text = "Borrar >";
            this.btnBorrarDer.UseVisualStyleBackColor = true;
            // 
            // btnDetalleDer
            // 
            this.btnDetalleDer.Location = new System.Drawing.Point(327, 290);
            this.btnDetalleDer.Name = "btnDetalleDer";
            this.btnDetalleDer.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleDer.TabIndex = 11;
            this.btnDetalleDer.Text = "Detalle >";
            this.btnDetalleDer.UseVisualStyleBackColor = true;
            // 
            // dgvEnviosRealizados
            // 
            this.dgvEnviosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnviosRealizados.Location = new System.Drawing.Point(408, 35);
            this.dgvEnviosRealizados.Name = "dgvEnviosRealizados";
            this.dgvEnviosRealizados.Size = new System.Drawing.Size(309, 356);
            this.dgvEnviosRealizados.TabIndex = 12;
            // 
            // FrmEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 408);
            this.Controls.Add(this.dgvEnviosRealizados);
            this.Controls.Add(this.btnDetalleDer);
            this.Controls.Add(this.btnBorrarDer);
            this.Controls.Add(this.btnModificarDer);
            this.Controls.Add(this.btnDetalleIzq);
            this.Controls.Add(this.btnEntregadoIzq);
            this.Controls.Add(this.btnBorrarIzq);
            this.Controls.Add(this.btnModificarIzq);
            this.Controls.Add(this.btnAgregarIzq);
            this.Controls.Add(this.dgvEnviosPendientes);
            this.Controls.Add(this.lblEnviosRealizados);
            this.Controls.Add(this.lblEnviosPendientes);
            this.Name = "FrmEnvio";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosRealizados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnviosPendientes;
        private System.Windows.Forms.Label lblEnviosRealizados;
        private System.Windows.Forms.DataGridView dgvEnviosPendientes;
        private System.Windows.Forms.Button btnAgregarIzq;
        private System.Windows.Forms.Button btnModificarIzq;
        private System.Windows.Forms.Button btnBorrarIzq;
        private System.Windows.Forms.Button btnEntregadoIzq;
        private System.Windows.Forms.Button btnDetalleIzq;
        private System.Windows.Forms.Button btnModificarDer;
        private System.Windows.Forms.Button btnBorrarDer;
        private System.Windows.Forms.Button btnDetalleDer;
        private System.Windows.Forms.DataGridView dgvEnviosRealizados;
    }
}