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
	public partial class frmAltaCerveza : Form
	{
		private Cerveza cervezaLocal = null;
		public frmAltaCerveza()
		{
			InitializeComponent();
		}
		public frmAltaCerveza(Cerveza cerveza)
		{
			InitializeComponent();
			cervezaLocal = cerveza;
		}

		private void frmAltaCerveza_Load(object sender, EventArgs e)
		{
			try
			{


				if (cervezaLocal != null)
				{
					txtNombre.Text = cervezaLocal.Nombre;
					txtTipo.Text = cervezaLocal.Tipo;
					txtGraduacionAlcoholica.Text = cervezaLocal.GraduacionAlcoholica.ToString();
					txtPrecioUnitario.Text = cervezaLocal.PrecioUnitario.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void lblAceptar_Click(object sender, EventArgs e)
		{
			CervezaNegocio negocio = new CervezaNegocio();
			try
			{

				if (cervezaLocal == null)
					cervezaLocal = new Cerveza();

				cervezaLocal.Nombre = txtNombre.Text;
				cervezaLocal.Tipo = txtTipo.Text;
				cervezaLocal.GraduacionAlcoholica = Convert.ToDecimal(txtGraduacionAlcoholica.Text);
				cervezaLocal.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);


				if (cervezaLocal.ID != 0)
				{
					negocio.modificarCerveza(cervezaLocal);
				}
				else
				{
					negocio.agregarCerveza(cervezaLocal);
				}

				Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void lblCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}


	}
}
