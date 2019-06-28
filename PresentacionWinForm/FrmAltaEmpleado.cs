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
	public partial class FrmAltaEmpleado : Form
	{
		private List<Empleado> listaEmpleadosLocal;
		public FrmAltaEmpleado()
		{
			InitializeComponent();
		}

		private void cargarGrilla()
		{
			EmpleadoNegocio negocio = new EmpleadoNegocio();
			try
			{
				listaEmpleadosLocal = negocio.listarEmpleados();
				dgvEmpleado.DataSource = listaEmpleadosLocal;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void FrmAltaEmpleado_Load(object sender, EventArgs e)
		{
			cargarGrilla();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmEmpleado alta = new FrmEmpleado();
			alta.ShowDialog();
			cargarGrilla();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			FrmEmpleado modificar = new FrmEmpleado((Empleado)dgvEmpleado.CurrentRow.DataBoundItem);
			modificar.ShowDialog();
			cargarGrilla();
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			try
			{
				EmpleadoNegocio negocio = new EmpleadoNegocio();
				negocio.borrarEmpleado((Empleado)dgvEmpleado.CurrentRow.DataBoundItem);
				cargarGrilla();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
