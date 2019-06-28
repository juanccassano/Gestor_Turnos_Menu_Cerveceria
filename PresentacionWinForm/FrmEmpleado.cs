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

		public FrmEmpleado()
		{
			InitializeComponent();
		}

		public FrmEmpleado (Empleado empleado)
		{
			InitializeComponent();
			empleadoLocal = empleado;

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
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private void btnAceptar_Click(object sender, EventArgs e)
		{
			EmpleadoNegocio negocio = new EmpleadoNegocio();

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
				

				if (empleadoLocal.ID != 0)
				{
					negocio.modificarEmpleado(empleadoLocal);
				}
				else
				{
					negocio.agregarEmpleado(empleadoLocal);
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


	}
}
