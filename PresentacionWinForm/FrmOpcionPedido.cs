using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWinForm
{
	public partial class FrmOpcionPedido : Form
	{
		FrmAltaPedido frm = null;
		int IDPedidoLocal;
		public FrmOpcionPedido(int IDPedido, FrmAltaPedido form)
		{
			InitializeComponent();
			IDPedidoLocal = IDPedido;
			frm = form;
		}

		private void btnBebida_Click(object sender, EventArgs e)
		{
			FrmAgregarBebida ventanaAB = new FrmAgregarBebida(IDPedidoLocal);
			ventanaAB.ShowDialog();
		}

		private void btnCerveza_Click(object sender, EventArgs e)
		{
			FrmAgregarCerveza ventanaAC = new FrmAgregarCerveza(IDPedidoLocal);
			ventanaAC.ShowDialog();
		}

		private void btnPlato_Click(object sender, EventArgs e)
		{
			FrmAgregarPlato ventanaAP = new FrmAgregarPlato(IDPedidoLocal);
			ventanaAP.ShowDialog();
		}

		public void FrmOpcionPedido_FormClosed(object sender, FormClosedEventArgs e)
		{
			frm.FrmRefresh();
		}
	}
}
