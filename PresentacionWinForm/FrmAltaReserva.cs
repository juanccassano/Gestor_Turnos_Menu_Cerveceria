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
	public partial class FrmAltaReserva : Form
	{
		ClienteNegocio cliente = new ClienteNegocio();
		ReservaNegocio reserva = new ReservaNegocio();
		Reserva mesa = new Reserva();

		int mesaSeleccionada = 0;

		public FrmAltaReserva(int mesaSelec)
		{
			InitializeComponent();
			mesaSeleccionada = mesaSelec;
		}

		private void FrmAltaReserva_Load(object sender, EventArgs e)
		{
			dtpFecha.Format = DateTimePickerFormat.Custom;
			dtpFecha.CustomFormat = "yyyy/MM/dd hh:mm:ss";
			cbxCliente.DataSource = cliente.listarClientes();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Cliente clienteSeleccionado = new Cliente();
			clienteSeleccionado = (Cliente)cbxCliente.SelectedItem;
			mesa.IDMesa = mesaSeleccionada;
			mesa.IDCliente = clienteSeleccionado.IDCliente;
			mesa.FechaHora = dtpFecha.Value;
			if (reserva.usuarioHabilitado(mesa.IDCliente))
			{ 
			reserva.reservarMesa(mesaSeleccionada);
			reserva.reservaCliente(mesa);
			this.Close();
			}
			else
			{
				MessageBox.Show("El cliente en cuestión ya falló a presentarse a la reserva de 3 mesas y no se le ofrece más este beneficio.");
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
