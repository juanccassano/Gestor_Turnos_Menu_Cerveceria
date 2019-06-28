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

namespace PresentacionWinForm
{
	public partial class FrmAltaPedido : Form
	{
		int IDPedido;
		PedidoMesa pedido = new PedidoMesa();
		public FrmAltaPedido()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmOpcionPedido ventanaOP = new FrmOpcionPedido(IDPedido, this);
			ventanaOP.ShowDialog();
		}

		private void FrmAltaPedido_Load(object sender, EventArgs e)
		{
			pedido.agregarPedido();
			IDPedido = pedido.seleccionarPedido();

		}

		public void FrmRefresh()
		{
			dgvBebida.DataSource = pedido.listarBebidas(IDPedido);
			dgvCerveza.DataSource = pedido.listarCervezas(IDPedido);
			dgvPlato.DataSource = pedido.listarPlatos(IDPedido);
			
		}

		private void btnCerrarPedido_Click(object sender, EventArgs e)
		{
			pedido.cargarPedido(IDPedido);
			MessageBox.Show("Carga de pedido exitosa.");
			Close();
		}
	}
}
