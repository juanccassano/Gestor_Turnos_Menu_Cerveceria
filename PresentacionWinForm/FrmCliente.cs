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
	public partial class FrmCliente : Form
	{
		private List<Cliente> listaClientesLocal;
		public FrmCliente()
		{
			InitializeComponent();
		}

		private void cargarGrilla()
		{
			ClienteNegocio negocio = new ClienteNegocio();
			try
			{
				listaClientesLocal = negocio.listarClientes();
				dgvCliente.DataSource = listaClientesLocal;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void FrmCliente_Load(object sender, EventArgs e)
		{
			cargarGrilla();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmAltaCliente alta = new FrmAltaCliente();
			alta.ShowDialog();
			cargarGrilla();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			try
			{
				FrmAltaCliente modificar = new FrmAltaCliente((Cliente)dgvCliente.CurrentRow.DataBoundItem);
				modificar.ShowDialog();
				cargarGrilla();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


	}
}
