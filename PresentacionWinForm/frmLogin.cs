using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionWinForm
{
	public partial class frmLogin : Form
	{
		public int local=0;
		UsuarioNegocio negocio = new UsuarioNegocio();
		string usuario;
		string contra;

		public frmLogin()
		{
			InitializeComponent();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			int conteo = 0;
			bool seguir = true;

			if (negocio.estadoUsuario(usuario) == true)

			{
				seguir = false;
			}

			if (negocio.validarUsuario(usuario, contra) == true && negocio.estadoUsuario(usuario) == false && seguir == true)
			{
				negocio.actualizarConteo(usuario, conteo);
				local = negocio.IDUsuario(usuario);
				this.DialogResult = DialogResult.OK;
				this.Close();

			}
			else
			{
				conteo = negocio.conteoActual(usuario) + 1;
				negocio.actualizarConteo(usuario, conteo);

				if (conteo < 3)
				{
					MessageBox.Show("No coincide usuario y contrasena con BBDD");
				}
				else
				{
					negocio.bloquearUsuario(usuario);
					MessageBox.Show("Usuario bloqueado");
				}
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			usuario = textBox1.Text;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			contra = textBox2.Text;
		}
	}
}
