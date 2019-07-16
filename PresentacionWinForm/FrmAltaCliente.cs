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
	public partial class FrmAltaCliente : Form
	{
		private Cliente clienteLocal = null;
		public FrmAltaCliente()
		{
			InitializeComponent();
		}
		public FrmAltaCliente(Cliente cliente)
		{
			InitializeComponent();
			clienteLocal = cliente;

		}

		private void FrmAltaCliente_Load(object sender, EventArgs e)
		{
			try
			{


				if (clienteLocal != null)
				{
					txtDNI.Text = clienteLocal.Documento.ToString();
					txtApellido.Text = clienteLocal.Apellido;
					txtNombre.Text = clienteLocal.Nombre;
					txtTelefono.Text = clienteLocal.Telefono.Numero.ToString();
					txtCalle.Text = clienteLocal.Direccion.Calle;
					txtNumeracion.Text = clienteLocal.Direccion.Numeracion.ToString();
					txtLocalidad.Text = clienteLocal.Direccion.Localidad;
					dtpFechaNac.Value = clienteLocal.FechaNac.FechaNac;
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			ClienteNegocio negocio = new ClienteNegocio();

			try
			{

				if (clienteLocal == null)
					clienteLocal = new Cliente();
				clienteLocal.Telefono = new Telefono();
				clienteLocal.Direccion = new Direccion();
				clienteLocal.FechaNac = new Fecha();



				clienteLocal.Documento = Convert.ToInt32(txtDNI.Text);
				clienteLocal.Apellido = txtApellido.Text;
				clienteLocal.Nombre = txtNombre.Text;
				clienteLocal.Telefono.Numero = Convert.ToInt32(txtTelefono.Text);
				clienteLocal.Direccion.Calle = txtCalle.Text;
				clienteLocal.Direccion.Numeracion = Convert.ToInt32(txtNumeracion.Text);
				clienteLocal.Direccion.Localidad = txtLocalidad.Text;
				clienteLocal.FechaNac.FechaNac = dtpFechaNac.Value;
				
				if (clienteLocal.IDCliente != 0)
				{
					negocio.modificarCliente(clienteLocal);
				}
				else
				{
					negocio.agregarCliente(clienteLocal);
				}

				Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
			{ e.Handled = true; }
		}

		private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
			{ e.Handled = true; }
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
			{ e.Handled = true; }
		}

		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
			{ e.Handled = true; }
		}

		private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
			{ e.Handled = true; }
		}

		private void txtNumeracion_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
			{ e.Handled = true; }
		}

		private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
			{ e.Handled = true; }
		}
	}
}
