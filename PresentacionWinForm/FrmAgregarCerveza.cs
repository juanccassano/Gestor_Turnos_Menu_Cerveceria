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
	public partial class FrmAgregarCerveza : Form
	{
		PedidoMesa pedido = new PedidoMesa();
		Cerveza cervezaLocal = new Cerveza();
		CervezaNegocio negocio = new CervezaNegocio();
		int IDPedidoLocal;
		public FrmAgregarCerveza(int IDPedido)
		{
			InitializeComponent();
			IDPedidoLocal = IDPedido;
		}

		private void FrmAgregarCerveza_Load(object sender, EventArgs e)
		{
			cbxCerveza.DataSource = negocio.listarCervezas();
			txtCantidad.Text = "1";
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			pedido.agregarCervezaPedido(IDPedidoLocal, cervezaLocal.ID, Convert.ToInt32(txtCantidad.Text), Convert.ToDecimal(cervezaLocal.PrecioUnitario * Convert.ToInt32(txtCantidad.Text)));
			Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			cervezaLocal = (Cerveza)cbxCerveza.SelectedItem;
			decimal precioParcial;
			int Cantidad;
			lblTipo.Text = "Tipo: " + cervezaLocal.Tipo;
			lblGraduacionAlcoholica.Text = "Graduación alcoholica: " + cervezaLocal.GraduacionAlcoholica.ToString();
			lblPrecioUnitario.Text = "Precio unitario: " + cervezaLocal.PrecioUnitario;
		}

		private void txtCantidad_TextChanged(object sender, EventArgs e)
		{


		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
			{ e.Handled = true; }
		}
	}
}
