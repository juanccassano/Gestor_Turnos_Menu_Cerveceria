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
	public partial class FrmAltaBebida : Form
	{
		private Bebida bebidaLocal = null;
		public FrmAltaBebida()
		{
			InitializeComponent();
		}

		public FrmAltaBebida(Bebida bebida)
		{
			InitializeComponent();
			bebidaLocal = bebida;
		}

		private void FrmAltaBebida_Load_1(object sender, EventArgs e)
		{

			try
			{


				if (bebidaLocal != null)
				{
					txtNombre.Text = bebidaLocal.Nombre;
					txtMarca.Text = bebidaLocal.Marca;
					ckbAlcoholica.Checked = bebidaLocal.ContieneAlcohol;
					txtPrecioUnitario.Text = bebidaLocal.PrecioUnitario.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnAceptar_Click_1(object sender, EventArgs e)
		{
			BebidaNegocio negocio = new BebidaNegocio();
			try
			{

				if (bebidaLocal == null)
					bebidaLocal = new Bebida();

				bebidaLocal.Nombre = txtNombre.Text;
				bebidaLocal.Marca = txtMarca.Text;
				bebidaLocal.ContieneAlcohol = ckbAlcoholica.Checked;
				bebidaLocal.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);


				if (bebidaLocal.ID != 0)
				{
					negocio.modificarBebida(bebidaLocal);
				}
				else
				{
					negocio.agregarBebida(bebidaLocal);
				}

				Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnCancelar_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
			{ e.Handled = true; }

		}

		private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
			{ e.Handled = true; }
		}

		private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && e.KeyChar != '.')
			{ e.Handled = true; }
		}
	}
}
