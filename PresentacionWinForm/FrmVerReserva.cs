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
	public partial class FrmVerReserva : Form
	{
		int IDMesa;
		ReservaNegocio reserva = new ReservaNegocio();
		public FrmVerReserva(int ID)
		{
			InitializeComponent();
			IDMesa = ID;
		}

		private void FrmVerReserva_Load(object sender, EventArgs e)
		{
			lblCliente.Text = "Cliente: " + reserva.nombreReserva(IDMesa);
			lblFecha.Text = "Fecha: " + reserva.fechaReserva(IDMesa);
		}
	}
}
