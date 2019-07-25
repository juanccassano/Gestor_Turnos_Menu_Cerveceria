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
		EmpleadoNegocio empleado = new EmpleadoNegocio();
		PedidoMesa pedido = new PedidoMesa();
		public FrmAltaPedido()
		{
			InitializeComponent();
			pedido.agregarPedido();
			IDPedido = pedido.seleccionarPedido();
			cbxMesero.DataSource = empleado.listarEmpleados();
		}

		public FrmAltaPedido(int IDPedidoAbierta)
		{
			InitializeComponent();
			IDPedido = IDPedidoAbierta;
			FrmRefresh();
			cbxMesero.DataSource = empleado.listarEmpleados();

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			string agregar = "agregar";
			FrmOpcionPedido ventanaOP = new FrmOpcionPedido(IDPedido, this, agregar);
			ventanaOP.ShowDialog();
		}

		private void FrmAltaPedido_Load(object sender, EventArgs e)
		{
			

		}

		public void FrmRefresh()
		{
			dgvProductos.DataSource = pedido.listarProductos(IDPedido);
			dgvProductos.Columns[1].Visible = false;
			dgvProductos.Columns[2].Visible = false;
			dgvProductos.Columns[4].Visible = false;
			lblTotal.Text = "Total: " + pedido.precioFinalPedido(IDPedido).ToString();
			
		}

		private void btnCerrarPedido_Click(object sender, EventArgs e)
		{
			int IDEmpleado = 0;
			Empleado empleadoSeleccionado = new Empleado();
			empleadoSeleccionado = (Empleado)cbxMesero.SelectedItem;

			decimal totalACobrar;
			totalACobrar = pedido.precioFinalPedido(IDPedido);
			pedido.cargarPedido(IDPedido);
			IDEmpleado = empleadoSeleccionado.ID;
			pedido.cargarIDEmpleado(IDPedido, IDEmpleado);
			MessageBox.Show("Carga de pedido exitosa. Total a cobrar: $"+totalACobrar.ToString());
			Close();
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			ProductoPedido productoSeleccionado = new ProductoPedido();

			if (dgvProductos.SelectedRows.Count > 0)
			{
				productoSeleccionado = (ProductoPedido)dgvProductos.CurrentRow.DataBoundItem;

				if (productoSeleccionado.Tipo == "Bebida")
				{
					pedido.borrarBebida(IDPedido, productoSeleccionado.IDEnPedido);
					FrmRefresh();
				}

				if (productoSeleccionado.Tipo == "Cerveza")
				{
					pedido.borrarCerveza(IDPedido, productoSeleccionado.IDEnPedido);
					FrmRefresh();
				}

				if (productoSeleccionado.Tipo == "Plato")
				{
					pedido.borrarPlato(IDPedido, productoSeleccionado.IDEnPedido);
					FrmRefresh();
				}

			}



			//FrmOpcionPedido ventanaOP = new FrmOpcionPedido(IDPedido, this, borrar, bebSel , cerSel, plaSel);
			//ventanaOP.ShowDialog();
		}

	}
}
