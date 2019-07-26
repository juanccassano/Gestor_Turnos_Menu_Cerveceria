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
	public partial class FrmSalon : Form
	{
		PedidoMesa pedido = new PedidoMesa();
		ReservaNegocio reserva = new ReservaNegocio();
		int mesaUnoAbierta = 0, mesaDosAbierta = 0, mesaTresAbierta = 0, mesaCuatroAbierta = 0, mesaCincoAbierta = 0, mesaSeisAbierta = 0, mesaSieteAbierta = 0, mesaOchoAbierta = 0;
		public FrmSalon(int usuario)
		{
			InitializeComponent();
		}

		private void btnCaja_Click(object sender, EventArgs e)
		{
			FrmAltaPedido ventanaAP = new FrmAltaPedido();
			ventanaAP.ShowDialog();
		}

		private void btnMesa1_Click(object sender, EventArgs e)
		{
			if (mesaUnoAbierta == 0)
			{
			if (reserva.estadoMesa(1))
				{
					Reserva reservada = new Reserva();
					string ApNom = reserva.nombreReserva(1);
					reservada = reserva.datosReserva(1);
					TimeSpan diferencia = reservada.FechaHora - DateTime.Now;
					double horas = diferencia.TotalHours;
					if (horas > 0 && horas < 1)
					{
						MessageBox.Show("Recordá que hay una reserva pendiente de " + ApNom + " a las " + reservada.FechaHora.ToString() + ".");
					}

				}
			FrmAltaPedido ventanaAP = new FrmAltaPedido();
			mesaUnoAbierta = pedido.seleccionarPedido();
			ventanaAP.ShowDialog();
			}
			else
			{
				FrmAltaPedido ventanaAP = new FrmAltaPedido(mesaUnoAbierta);
				ventanaAP.ShowDialog();
				if (pedido.PedidoCerrado(mesaUnoAbierta))
				{
					mesaUnoAbierta = 0;
				}
			}
		}

		private void btnMesa2_Click(object sender, EventArgs e)
		{
			if (mesaDosAbierta == 0)
			{
				if (reserva.estadoMesa(2))
				{
					Reserva reservada = new Reserva();
					string ApNom = reserva.nombreReserva(2);
					reservada = reserva.datosReserva(2);
					TimeSpan diferencia = reservada.FechaHora - DateTime.Now;
					double horas = diferencia.TotalHours;
					if (horas > 0 && horas < 1)
					{
						MessageBox.Show("Recordá que hay una reserva pendiente de " + ApNom + " a las " + reservada.FechaHora.ToString() + ".");
					}

				}
				FrmAltaPedido ventanaAP = new FrmAltaPedido();
				mesaDosAbierta = pedido.seleccionarPedido();
				ventanaAP.ShowDialog();
			}
			else
			{
				FrmAltaPedido ventanaAP = new FrmAltaPedido(mesaDosAbierta);
				ventanaAP.ShowDialog();
				if (pedido.PedidoCerrado(mesaDosAbierta))
				{
					mesaDosAbierta = 0;
				}
			}
		}

		private void btnMesa3_Click(object sender, EventArgs e)
		{
			if (mesaTresAbierta == 0)
			{
				if (reserva.estadoMesa(3))
				{
					Reserva reservada = new Reserva();
					string ApNom = reserva.nombreReserva(3);
					reservada = reserva.datosReserva(3);
					TimeSpan diferencia = reservada.FechaHora - DateTime.Now;
					double horas = diferencia.TotalHours;
					if (horas > 0 && horas < 1)
					{
						MessageBox.Show("Recordá que hay una reserva pendiente de " + ApNom + " a las " + reservada.FechaHora.ToString() + ".");
					}

				}
				FrmAltaPedido ventanaAP = new FrmAltaPedido();
				mesaTresAbierta = pedido.seleccionarPedido();
				ventanaAP.ShowDialog();
			}
			else
			{
				FrmAltaPedido ventanaAP = new FrmAltaPedido(mesaTresAbierta);
				ventanaAP.ShowDialog();
				if (pedido.PedidoCerrado(mesaTresAbierta))
				{
					mesaTresAbierta = 0;
				}
			}
		}

		private void btnMesa4_Click(object sender, EventArgs e)
		{
			if (mesaCuatroAbierta == 0)
			{
				if (reserva.estadoMesa(4))
				{
					Reserva reservada = new Reserva();
					string ApNom = reserva.nombreReserva(4);
					reservada = reserva.datosReserva(4);
					TimeSpan diferencia = reservada.FechaHora - DateTime.Now;
					double horas = diferencia.TotalHours;
					if (horas > 0 && horas < 1)
					{
						MessageBox.Show("Recordá que hay una reserva pendiente de " + ApNom + " a las " + reservada.FechaHora.ToString() + ".");
					}

				}
				FrmAltaPedido ventanaAP = new FrmAltaPedido();
				mesaCuatroAbierta = pedido.seleccionarPedido();
				ventanaAP.ShowDialog();
			}
			else
			{
				FrmAltaPedido ventanaAP = new FrmAltaPedido(mesaCuatroAbierta);
				ventanaAP.ShowDialog();
				if (pedido.PedidoCerrado(mesaCuatroAbierta))
				{
					mesaCuatroAbierta = 0;
				}
			}
		}

		private void btnMesa5_Click(object sender, EventArgs e)
		{
			if (mesaCincoAbierta == 0)
			{
				if (reserva.estadoMesa(5))
				{
					Reserva reservada = new Reserva();
					string ApNom = reserva.nombreReserva(5);
					reservada = reserva.datosReserva(5);
					TimeSpan diferencia = reservada.FechaHora - DateTime.Now;
					double horas = diferencia.TotalHours;
					if (horas > 0 && horas < 1)
					{
						MessageBox.Show("Recordá que hay una reserva pendiente de " + ApNom + " a las " + reservada.FechaHora.ToString() + ".");
					}

				}
				FrmAltaPedido ventanaAP = new FrmAltaPedido();
				mesaCincoAbierta = pedido.seleccionarPedido();
				ventanaAP.ShowDialog();
			}
			else
			{
				FrmAltaPedido ventanaAP = new FrmAltaPedido(mesaCincoAbierta);
				ventanaAP.ShowDialog();
				if (pedido.PedidoCerrado(mesaCincoAbierta))
				{
					mesaCincoAbierta = 0;
				}
			}
		}

		private void btnMesa6_Click(object sender, EventArgs e)
		{
			if (mesaSeisAbierta == 0)
			{
				if (reserva.estadoMesa(6))
				{
					Reserva reservada = new Reserva();
					string ApNom = reserva.nombreReserva(6);
					reservada = reserva.datosReserva(6);
					TimeSpan diferencia = reservada.FechaHora - DateTime.Now;
					double horas = diferencia.TotalHours;
					if (horas > 0 && horas < 1)
					{
						MessageBox.Show("Recordá que hay una reserva pendiente de " + ApNom + " a las " + reservada.FechaHora.ToString() + ".");
					}

				}
				FrmAltaPedido ventanaAP = new FrmAltaPedido();
				mesaSeisAbierta = pedido.seleccionarPedido();
				ventanaAP.ShowDialog();
			}
			else
			{
				FrmAltaPedido ventanaAP = new FrmAltaPedido(mesaSeisAbierta);
				ventanaAP.ShowDialog();
				if (pedido.PedidoCerrado(mesaSeisAbierta))
				{
					mesaSeisAbierta = 0;
				}
			}
		}

		private void btnMesa7_Click(object sender, EventArgs e)
		{
			if (mesaSieteAbierta == 0)
			{
				if (reserva.estadoMesa(7))
				{
					Reserva reservada = new Reserva();
					string ApNom = reserva.nombreReserva(7);
					reservada = reserva.datosReserva(7);
					TimeSpan diferencia = reservada.FechaHora - DateTime.Now;
					double horas = diferencia.TotalHours;
					if (horas > 0 && horas < 1)
					{
						MessageBox.Show("Recordá que hay una reserva pendiente de " + ApNom + " a las " + reservada.FechaHora.ToString() + ".");
					}

				}
				FrmAltaPedido ventanaAP = new FrmAltaPedido();
				mesaSieteAbierta = pedido.seleccionarPedido();
				ventanaAP.ShowDialog();
			}
			else
			{
				FrmAltaPedido ventanaAP = new FrmAltaPedido(mesaSieteAbierta);
				ventanaAP.ShowDialog();
				if (pedido.PedidoCerrado(mesaSieteAbierta))
				{
					mesaSieteAbierta = 0;
				}
			}
		}

		private void btnMesa8_Click(object sender, EventArgs e)
		{
			if (mesaOchoAbierta == 0)
			{
				if (reserva.estadoMesa(8))
				{
					Reserva reservada = new Reserva();
					string ApNom = reserva.nombreReserva(8);
					reservada = reserva.datosReserva(8);
					TimeSpan diferencia = reservada.FechaHora - DateTime.Now;
					double horas = diferencia.TotalHours;
					if (horas > 0 && horas < 1)
					{
						MessageBox.Show("Recordá que hay una reserva pendiente de " + ApNom + " a las " + reservada.FechaHora.ToString() + ".");
					}

				}
				FrmAltaPedido ventanaAP = new FrmAltaPedido();
				mesaOchoAbierta = pedido.seleccionarPedido();
				ventanaAP.ShowDialog();
			}
			else
			{
				FrmAltaPedido ventanaAP = new FrmAltaPedido(mesaOchoAbierta);
				ventanaAP.ShowDialog();
				if (pedido.PedidoCerrado(mesaOchoAbierta))
				{
					mesaOchoAbierta = 0;
				}
			}
		}
	}
}
