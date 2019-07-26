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
		int mesaSeleccionada=1;
		public FrmReserva()
		{
			InitializeComponent();
			frmRefresh();
		}

		private void btnReservada_Click(object sender, EventArgs e)
		{
			mesaLocal = (Mesa)dgvReserva.CurrentRow.DataBoundItem;
			if (!mesaLocal.Reservada)
			{ 
			mesaSeleccionada = mesaLocal.ID;
			FrmAltaReserva ventanaR = new FrmAltaReserva(mesaSeleccionada);
			ventanaR.ShowDialog();
			frmRefresh();
			}
			else
			{
				MessageBox.Show("Ésta mesa ya se encuentra reservada");
			}
		}

		private void btnDesocupada_Click(object sender, EventArgs e)
		{
			mesaLocal = (Mesa)dgvReserva.CurrentRow.DataBoundItem;
			if (mesaLocal.Reservada)
			{
				mesaSeleccionada = mesaLocal.ID;
				FrmBajaReserva ventanaB = new FrmBajaReserva(mesaSeleccionada);
				ventanaB.ShowDialog();
				frmRefresh();
			}
			else
			{
				MessageBox.Show("Ésta mesa no se encuentra reservada");
			}

		}

		private void frmRefresh()
		{
			dgvReserva.DataSource = reserva.listarMesas();
		}

		private void btnVer_Click(object sender, EventArgs e)
		{
			mesaLocal = (Mesa)dgvReserva.CurrentRow.DataBoundItem;
			if (mesaLocal.Reservada)
			{ 
			mesaSeleccionada = mesaLocal.ID;
			FrmVerReserva reserva = new FrmVerReserva(mesaSeleccionada);
			reserva.ShowDialog();
				frmRefresh();
			}
			else
			{
				MessageBox.Show("Ésta mesa no se encuentra reservada");
			}
		}

		private void FrmReserva_Load(object sender, EventArgs e)
		{

		}
	}
}
