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
	public partial class FrmEmpleado : Form
	{
		private Empleado empleadoLocal = null;
		public string usuario = "Nuevo", clave = "Nuevo";
		EmpleadoNegocio negocio = new EmpleadoNegocio();

		public FrmEmpleado()
		{
			InitializeComponent();
		}

		public FrmEmpleado (Empleado empleado)
		{
			InitializeComponent();
			empleadoLocal = empleado;
			usuario = negocio.buscarUsuario(empleadoLocal.ID);
			clave = negocio.buscarClave(empleadoLocal.ID);

		}

		private void FrmEmpleado_Load(object sender, EventArgs e)
		{
			try
			{


				if (empleadoLocal != null)
				{
					txtDNI.Text = empleadoLocal.Documento.ToString();
					txtApellido.Text = empleadoLocal.Apellido;
					txtNombre.Text = empleadoLocal.Nombre;
					txtTelefono.Text = empleadoLocal.Telefono.Numero.ToString();
					txtCalle.Text = empleadoLocal.Direccion.Calle;
					txtNumeracion.Text = empleadoLocal.Direccion.Numeracion.ToString();
					txtLocalidad.Text = empleadoLocal.Direccion.Localidad;
					dtpFechaNac.Value = empleadoLocal.FechaNac.FechaNac;
					txtTarea.Text = empleadoLocal.Tarea;
					dtpFechaIng.Value = empleadoLocal.FechaIngreso.FechaNac;
					txtUsuario.Text = usuario;
					txtClave.Text = clave;
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private void btnAceptar_Click(object sender, EventArgs e)
		{

			try
			{

				if (empleadoLocal == null)
				empleadoLocal = new Empleado();
				empleadoLocal.Telefono = new Telefono();
				empleadoLocal.Direccion = new Direccion();
				empleadoLocal.FechaNac = new Fecha();
				empleadoLocal.FechaIngreso = new Fecha();



				empleadoLocal.Documento = Convert.ToInt32(txtDNI.Text);
				empleadoLocal.Apellido = txtApellido.Text;
				empleadoLocal.Nombre = txtNombre.Text;
				empleadoLocal.Telefono.Numero = Convert.ToInt32(txtTelefono.Text);
				empleadoLocal.Direccion.Calle = txtCalle.Text;
				empleadoLocal.Direccion.Numeracion = Convert.ToInt32(txtNumeracion.Text);
				empleadoLocal.Direccion.Localidad = txtLocalidad.Text;
				empleadoLocal.FechaNac.FechaNac = dtpFechaNac.Value;
				empleadoLocal.Tarea = txtTarea.Text;
				empleadoLocal.FechaIngreso.FechaNac = dtpFechaNac.Value;
				usuario = txtUsuario.Text;
				clave = txtClave.Text;
				

				if (empleadoLocal.ID != 0)
				{
					negocio.modificarEmpleado(empleadoLocal);
					negocio.modificarUsuario(empleadoLocal.ID, usuario, clave);
				}
				else
				{
					int ultimoAgregado = 0;
					negocio.agregarEmpleado(empleadoLocal);
					ultimoAgregado = negocio.buscarUltimo();
					negocio.agregarUsuario(ultimoAgregado, usuario, clave);
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

		private void txtTarea_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
			{ e.Handled = true; }
		}
	}
}
