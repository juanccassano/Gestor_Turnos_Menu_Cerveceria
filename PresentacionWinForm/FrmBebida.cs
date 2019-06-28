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
	public partial class FrmBebida : Form
	{
		private List<Bebida> listaBebidasLocal;
		public FrmBebida()
		{
			InitializeComponent();
		}




		private void cargarGrilla()
		{
			BebidaNegocio negocio = new BebidaNegocio();
			try
			{
				listaBebidasLocal = negocio.listarBebidas();
				dgvBebida.DataSource = listaBebidasLocal;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void FrmBebida_Load(object sender, EventArgs e)
		{
			cargarGrilla();
		}

		private void btnAgregar_Click_1(object sender, EventArgs e)
		{
			FrmAltaBebida alta = new FrmAltaBebida();
			alta.ShowDialog();
			cargarGrilla();
		}

		private void btnModificar_Click_1(object sender, EventArgs e)
		{
			try
			{
				FrmAltaBebida modificar = new FrmAltaBebida((Bebida)dgvBebida.CurrentRow.DataBoundItem);
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
				BebidaNegocio negocio = new BebidaNegocio();
				negocio.borrarBebida ((Bebida)dgvBebida.CurrentRow.DataBoundItem);
				cargarGrilla();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
