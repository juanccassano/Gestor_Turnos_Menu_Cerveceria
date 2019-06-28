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
	public partial class FrmProveedor : Form
	{
		private List<Proveedor> listaProveedorsLocal;
		public FrmProveedor()
		{
			InitializeComponent();
		}

		private void cargarGrilla()
		{
			ProveedorNegocio negocio = new ProveedorNegocio();
			try
			{
				listaProveedorsLocal = negocio.listarProveedors();
				dgvProveedor.DataSource = listaProveedorsLocal;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void FrmProveedor_Load(object sender, EventArgs e)
		{
			cargarGrilla();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmAltaProveedor alta = new FrmAltaProveedor();
			alta.ShowDialog();
			cargarGrilla();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			try
			{
				FrmAltaProveedor modificar = new FrmAltaProveedor((Proveedor)dgvProveedor.CurrentRow.DataBoundItem);
				modificar.ShowDialog();
				cargarGrilla();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			try
			{
				ProveedorNegocio negocio = new ProveedorNegocio();
				negocio.borrarProveedor((Proveedor)dgvProveedor.CurrentRow.DataBoundItem);
				cargarGrilla();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
