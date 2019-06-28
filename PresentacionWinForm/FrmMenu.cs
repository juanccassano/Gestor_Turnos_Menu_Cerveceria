using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWinForm
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnEnvios_MouseClick(object sender, MouseEventArgs e)
        {
            FrmEnvio ventanaE = new FrmEnvio();
            ventanaE.ShowDialog();
        }

		private void bebidaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmBebida ventanaB = new FrmBebida();
			ventanaB.ShowDialog();
		}

		private void cervezaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCerveza ventanaC = new frmCerveza();
			ventanaC.ShowDialog();
		}

		private void platosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmPlato ventanaP = new FrmPlato();
			ventanaP.ShowDialog();
		}

		private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmProveedor ventanaPv = new FrmProveedor();
			ventanaPv.ShowDialog();
		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmCliente ventanaCl = new FrmCliente();
			ventanaCl.ShowDialog();
		}

		private void personaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmAltaEmpleado ventanaAE = new FrmAltaEmpleado();
			ventanaAE.ShowDialog();
		}

		private void btnSalon_Click(object sender, EventArgs e)
		{
			FrmSalon ventanaS = new FrmSalon();
			ventanaS.ShowDialog();
		}
	}
}
