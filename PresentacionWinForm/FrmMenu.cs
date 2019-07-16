using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace PresentacionWinForm
{
    public partial class FrmMenu : Form
    {
		int usuarioIngresado;
		string cargoUsuario;
		UsuarioNegocio negocio = new UsuarioNegocio();
        public FrmMenu(int usuario)

        {
			usuarioIngresado = usuario;
			cargoUsuario = negocio.tareaUsuario(usuarioIngresado) ;
            InitializeComponent();
        }

        private void btnEnvios_MouseClick(object sender, MouseEventArgs e)
        {
            FrmEnvio ventanaE = new FrmEnvio();
            ventanaE.ShowDialog();
        }

		private void bebidaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (cargoUsuario == "Encargado")
			{ 
			FrmBebida ventanaB = new FrmBebida();
			ventanaB.ShowDialog();
			}
			else
			{
				MessageBox.Show("Usted no cuenta con los permisos necesarios para esta opción.");
			}
		}

		private void cervezaToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (cargoUsuario == "Encargado")
			{
				frmCerveza ventanaC = new frmCerveza();
				ventanaC.ShowDialog();
			}
			else
			{
				MessageBox.Show("Usted no cuenta con los permisos necesarios para esta opción.");
			}
		}

		private void platosToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (cargoUsuario == "Encargado")
			{
				FrmPlato ventanaP = new FrmPlato();
				ventanaP.ShowDialog();
			}
			else
			{
				MessageBox.Show("Usted no cuenta con los permisos necesarios para esta opción.");
			}
		}

		private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (cargoUsuario == "Encargado")
			{
				FrmProveedor ventanaPv = new FrmProveedor();
				ventanaPv.ShowDialog();
			}
			else
			{
				MessageBox.Show("Usted no cuenta con los permisos necesarios para esta opción.");
			}
		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (cargoUsuario == "Encargado")
			{
				FrmCliente ventanaCl = new FrmCliente();
				ventanaCl.ShowDialog();
			}
			else
			{
				MessageBox.Show("Usted no cuenta con los permisos necesarios para esta opción.");
			}
		}

		private void personaToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (cargoUsuario == "Encargado")
			{
				FrmAltaEmpleado ventanaAE = new FrmAltaEmpleado();
				ventanaAE.ShowDialog();
			}
			else
			{
				MessageBox.Show("Usted no cuenta con los permisos necesarios para esta opción.");
			}
		}

		private void btnSalon_Click(object sender, EventArgs e)
		{
			FrmSalon ventanaS = new FrmSalon();
			ventanaS.ShowDialog();
		}

		private void btnEnvios_Click(object sender, EventArgs e)
		{

		}

		private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
		{


			if (cargoUsuario == "Encargado")
			{
				FrmReserva ventanaR = new FrmReserva();
				ventanaR.ShowDialog();
			}
			else
			{
				MessageBox.Show("Usted no cuenta con los permisos necesarios para esta opción.");
			}
		}

		private void FrmMenu_Load(object sender, EventArgs e)
		{

		}
	}
}
