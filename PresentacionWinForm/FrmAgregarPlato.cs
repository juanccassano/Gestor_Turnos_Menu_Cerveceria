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
	public partial class FrmAgregarPlato : Form
	{
		PedidoMesa pedido = new PedidoMesa();
		Plato platoLocal = new Plato();
		PlatoNegocio negocio = new PlatoNegocio();
		int IDPedidoLocal;
		public FrmAgregarPlato(int IDPedido)
		{
			InitializeComponent();
			IDPedidoLocal = IDPedido;
		}

		private void FrmAgregarPlato_Load(object sender, EventArgs e)
		{
			cbxNombre.DataSource = negocio.listarPlatos();
			txtCantidad.Text = "1";
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (txtCantidad.Text.Trim() != string.Empty)
			{
				//cod
				pedido.agregarPlatoPedido(IDPedidoLocal, platoLocal.ID, Convert.ToInt32(txtCantidad.Text), Convert.ToDecimal(platoLocal.PrecioUnitario * Convert.ToInt32(txtCantidad.Text)));
				Close();

			}

			else
			{
				MessageBox.Show("Todos los campos deben estar completos.");
			}



		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbxNombre_SelectedValueChanged(object sender, EventArgs e)
		{
			platoLocal = (Plato)cbxNombre.SelectedItem;
			decimal precioParcial;
			int Cantidad;
			if (platoLocal.AptoCeliacos)
			{
				lblAptoCeliacos.Text = "Apto celiacos: Sí";
			}
			else
			{
				lblAptoCeliacos.Text = "Apto celiacos: No";
			}
			if (platoLocal.OpcionVegetariana)
			{
				lblOpcionVegetariana.Text = "Vegetariano";
			}
			else
			{
				lblOpcionVegetariana.Text = "No vegetariano";
			}
			lblPrecioUnitario.Text = "Precio unitario: " + platoLocal.PrecioUnitario;
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
			{ e.Handled = true; }
		}
	}
}
