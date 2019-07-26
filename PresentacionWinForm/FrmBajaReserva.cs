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
	public partial class FrmBajaReserva : Form
	{
		int mesaSeleccionada = 0;
		ReservaNegocio reserva = new ReservaNegocio();
		Reserva mesa = new Reserva();

		public FrmBajaReserva(int mesaSelec)
		{
			InitializeComponent();
			mesaSeleccionada = mesaSelec;
			mesa = reserva.datosReserva(mesaSeleccionada);

		}

		private void btnSi_Click(object sender, EventArgs e)
		{
			reserva.habilitarMesa(mesaSeleccionada);
			this.Close();
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			int IDCliente = 0;
			int Intentos = 0;			
			IDCliente = mesa.IDCliente;
			Intentos = reserva.intentosTotales(IDCliente) + 1;
			reserva.sumarIntento(IDCliente, Intentos);
			this.Close();
		}

		private void lblMensaje_Click(object sender, EventArgs e)
		{

		}

		private void FrmBajaReserva_Load(object sender, EventArgs e)
		{
			lblMensaje.Text = "¿Cumplió " + reserva.nombreReserva(mesaSeleccionada) + " con la reserva?";
		}
	}
}
