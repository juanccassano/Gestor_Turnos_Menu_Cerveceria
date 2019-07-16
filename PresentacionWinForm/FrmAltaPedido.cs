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
	public partial class FrmAltaPedido : Form
	{
		int IDPedido;
		PedidoMesa pedido = new PedidoMesa();
		public FrmAltaPedido()
		{
			InitializeComponent();
			pedido.agregarPedido();
			IDPedido = pedido.seleccionarPedido();
		}

		public FrmAltaPedido(int IDPedidoAbierta)
		{
			InitializeComponent();
			IDPedido = IDPedidoAbierta;
			FrmRefresh();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			string agregar = "agregar";
			FrmOpcionPedido ventanaOP = new FrmOpcionPedido(IDPedido, this, agregar);
			ventanaOP.ShowDialog();
		}

		private void FrmAltaPedido_Load(object sender, EventArgs e)
		{
			//pedido.agregarPedido();
			//IDPedido = pedido.seleccionarPedido();

		}

		public void FrmRefresh()
		{
			dgvBebida.DataSource = pedido.listarBebidas(IDPedido);
			dgvCerveza.DataSource = pedido.listarCervezas(IDPedido);
			dgvPlato.DataSource = pedido.listarPlatos(IDPedido);
			lblTotal.Text = "Total: " + pedido.precioFinalPedido(IDPedido).ToString();
			
		}

		private void btnCerrarPedido_Click(object sender, EventArgs e)
		{
			decimal totalACobrar;
			totalACobrar = pedido.precioFinalPedido(IDPedido);
			pedido.cargarPedido(IDPedido);
			MessageBox.Show("Carga de pedido exitosa. Total a cobrar: $"+totalACobrar.ToString());
			Close();
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			string borrar = "borrar";
			int bebSel = -1, cerSel = -1, plaSel = -1;
			ProductoPedido bebidaSeleccionada = new ProductoPedido();
			ProductoPedido cervezaSeleccionada = new ProductoPedido();
			ProductoPedido platoSeleccionado = new ProductoPedido();


			if (dgvBebida.SelectedRows.Count > 0)
			{
				bebidaSeleccionada = (ProductoPedido)dgvBebida.CurrentRow.DataBoundItem;
				bebSel = bebidaSeleccionada.IDEnPedido;
			}
			if (dgvCerveza.SelectedRows.Count > 0)
			{ 
				cervezaSeleccionada = (ProductoPedido)dgvCerveza.CurrentRow.DataBoundItem;
				cerSel = cervezaSeleccionada.IDEnPedido;
			}
			if (dgvPlato.SelectedRows.Count > 0)
			{ 
				platoSeleccionado = (ProductoPedido)dgvPlato.CurrentRow.DataBoundItem;
				plaSel = platoSeleccionado.IDEnPedido;
			}


			FrmOpcionPedido ventanaOP = new FrmOpcionPedido(IDPedido, this, borrar, bebSel , cerSel, plaSel);
			ventanaOP.ShowDialog();
		}

	}
}
