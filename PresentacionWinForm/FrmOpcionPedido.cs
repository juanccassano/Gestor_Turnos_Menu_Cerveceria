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
	public partial class FrmOpcionPedido : Form
	{
		FrmAltaPedido frm = null;
		PedidoMesa pedido = new PedidoMesa();
		int IDPedidoLocal, IDBebidaBorrar, IDCervezaBorrar, IDPlatoBorrar;
		string tipoLocal;

		public FrmOpcionPedido(int IDPedido, FrmAltaPedido form, string tipo)
		{
			InitializeComponent();
			IDPedidoLocal = IDPedido;
			frm = form;
			tipoLocal = tipo;
		}

		public FrmOpcionPedido(int IDPedido, FrmAltaPedido form, string tipo, int IDbebida, int IDcerveza, int IDplato)
		{
			InitializeComponent();
			IDPedidoLocal = IDPedido;
			frm = form;
			tipoLocal = tipo;
			IDBebidaBorrar = IDbebida;
			IDCervezaBorrar = IDcerveza;
			IDPlatoBorrar = IDplato;
		}


		private void btnBebida_Click(object sender, EventArgs e)
		{
			if (tipoLocal == "agregar")
			{ 
			FrmAgregarBebida ventanaAB = new FrmAgregarBebida(IDPedidoLocal);
			ventanaAB.ShowDialog();
			}
			else
			{
				if (IDBebidaBorrar >= 0)
				{
					pedido.borrarBebida(IDPedidoLocal, IDBebidaBorrar);
					MessageBox.Show("Bebida borrada con éxito");

				}
				else
				{
					MessageBox.Show("No hay ninguna bebida seleccionada");
				}
			}
		}

		private void btnCerveza_Click(object sender, EventArgs e)
		{
			if (tipoLocal == "agregar")
			{ 
			FrmAgregarCerveza ventanaAC = new FrmAgregarCerveza(IDPedidoLocal);
			ventanaAC.ShowDialog();
			}
			else
			{ 
			if (IDCervezaBorrar >= 0)
			{
				pedido.borrarCerveza(IDPedidoLocal, IDCervezaBorrar);
				MessageBox.Show("Cerveza borrada con éxito");
			}
			else
			{
				MessageBox.Show("No hay ninguna cerveza seleccionada");
			}
			}
		}

		private void btnPlato_Click(object sender, EventArgs e)
		{
			if (tipoLocal == "agregar")
			{ 
			FrmAgregarPlato ventanaAP = new FrmAgregarPlato(IDPedidoLocal);
			ventanaAP.ShowDialog();
			}
			else
			{ 
			if (IDPlatoBorrar >= 0)
			{
				pedido.borrarPlato(IDPedidoLocal, IDPlatoBorrar);
				MessageBox.Show("Plato borrada con éxito");
			}
			else
			{
				MessageBox.Show("No hay ningún plato seleccionado");
			}
			}
		}

		public void FrmOpcionPedido_FormClosed(object sender, FormClosedEventArgs e)
		{
			frm.FrmRefresh();
		}

		private void FrmOpcionPedido_Load(object sender, EventArgs e)
		{

		}
	}
}
