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
	public partial class FrmAgregarBebida : Form
	{
		PedidoMesa pedido = new PedidoMesa();
		Bebida bebidaLocal = new Bebida();
		BebidaNegocio negocio = new BebidaNegocio();
		int IDPedidoLocal;
		public FrmAgregarBebida(int IDPedido)
		{
			InitializeComponent();
			IDPedidoLocal = IDPedido;
		}

		private void FrmAgregarBebida_Load(object sender, EventArgs e)
		{
			cbxBebida.DataSource = negocio.listarBebidas();
			txtCantidad.Text = "1";

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{

			pedido.agregarBebidaPedido(IDPedidoLocal, bebidaLocal.ID, Convert.ToInt32(txtCantidad.Text), Convert.ToDecimal(bebidaLocal.PrecioUnitario * Convert.ToInt32(txtCantidad.Text)));
			Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbxBebida_SelectedValueChanged(object sender, EventArgs e)
		{
			bebidaLocal = (Bebida)cbxBebida.SelectedItem;
			decimal precioParcial;
			int Cantidad;
			lblTipo.Text = "Tipo: " + bebidaLocal.Nombre;
			if (bebidaLocal.ContieneAlcohol)
			{
				lblContieneAlcohol.Text = "Contiene alcohol";
			}
			else
			{
				lblContieneAlcohol.Text = "No contiene alcohol";
			}
			lblPrecio.Text = "Precio unitario: " + bebidaLocal.PrecioUnitario;
			//Cantidad = Convert.ToInt32(txtCantidad.Text);
			//precioParcial = bebidaLocal.PrecioUnitario * Cantidad;
			//lblPrecioParcial.Text = "Precio parcial: " + precioParcial.ToString();
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar))) 
			{ e.Handled = true; }
		}
	}
}
