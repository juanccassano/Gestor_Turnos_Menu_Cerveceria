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
	public partial class FrmReserva : Form
	{
		ReservaNegocio reserva = new ReservaNegocio();
		Mesa mesaLocal = new Mesa();
		int mesaSeleccionada;
		public FrmReserva()
		{
			InitializeComponent();
			frmRefresh();
		}

		private void btnReservada_Click(object sender, EventArgs e)
		{
			mesaLocal = (Mesa)dgvReserva.CurrentRow.DataBoundItem;
			mesaSeleccionada = mesaLocal.ID;
			reserva.reservarMesa(mesaSeleccionada);
			frmRefresh();
		}

		private void btnDesocupada_Click(object sender, EventArgs e)
		{
			mesaLocal = (Mesa)dgvReserva.CurrentRow.DataBoundItem;
			mesaSeleccionada = mesaLocal.ID;
			reserva.habilitarMesa(mesaSeleccionada);
			frmRefresh();
		}

		private void frmRefresh()
		{
			dgvReserva.DataSource = reserva.listarMesas();
		}
	}
}
