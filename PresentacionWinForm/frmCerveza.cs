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
	public partial class frmCerveza : Form
	{
		private List<Cerveza> listaCervezasLocal;
		public frmCerveza()
		{
			InitializeComponent();
		}

		private void cargarGrilla()
		{
			CervezaNegocio negocio = new CervezaNegocio();
			try
			{
				listaCervezasLocal = negocio.listarCervezas();
				dgvCerveza.DataSource = listaCervezasLocal;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void frmCerveza_Load(object sender, EventArgs e)
		{
			cargarGrilla();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			frmAltaCerveza alta = new frmAltaCerveza();
			alta.ShowDialog();
			cargarGrilla();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			try
			{
				frmAltaCerveza modificar = new frmAltaCerveza((Cerveza)dgvCerveza.CurrentRow.DataBoundItem);
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
				CervezaNegocio negocio = new CervezaNegocio();
				negocio.borrarCerveza((Cerveza)dgvCerveza.CurrentRow.DataBoundItem);
				cargarGrilla();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


	}
}
