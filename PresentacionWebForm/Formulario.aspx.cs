using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using Negocio;
using Dominio;

namespace PresentacionWebForm
{
	public partial class Formulario : System.Web.UI.Page
	{
		ClienteNegocio neg = new ClienteNegocio();

		protected void Page_Load(object sender, EventArgs e)
		{
			btnMesaUno.Enabled = true;
			btnMesaDos.Enabled = true;
			cldFechaNac.SelectedDate = DateTime.Today;
			cldReserva.SelectedDate = DateTime.Today;

		}

		protected void popUp (string text)
		{
			Type cstype = this.GetType();
			ClientScriptManager cs = Page.ClientScript;
			if (!cs.IsStartupScriptRegistered(cstype, "PopupScript"))
			{
				String cstext = "alert('" + text + "');";
				cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);
			}
		}

		protected void mandarMail(string email, string nombre)
		{
			MailMessage mail = new MailMessage();
			SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

			mail.From = new MailAddress("cerveceria.noreply@gmail.com");
			mail.To.Add(email);
			mail.Subject = "Reserva";
			mail.Body = "Felicidades " + nombre + "! Tu reserva de la mesa fue registrada con éxito. Mostra este correo en la barra para que te acomoden. Gracias por elegirnos!";

			SmtpServer.Port = 587;
			SmtpServer.Credentials = new System.Net.NetworkCredential("cerveceria.noreply@gmail.com", "cerveceria123");
			SmtpServer.EnableSsl = true;

			SmtpServer.Send(mail);
		}

		protected void btnReservar_Click(int IDMesaSeleccionada, object sender, EventArgs e)
		{
			int IDMesa = IDMesaSeleccionada;
			ReservaNegocio negocio = new ReservaNegocio();
			mandarMail(txtEmail.Text, txtNombre.Text);
			negocio.reservarMesa(IDMesa);
			Response.Redirect("~/Reservada.aspx");
			
			
		}

		protected void btnReservarUno_Click(object sender, EventArgs e)
		{
			int IDMesa = 1;
			ReservaNegocio negocio = new ReservaNegocio();
			if (negocio.estadoMesa(IDMesa))
			{
				popUp("Lamentablemente esta mesa ya se encuentra reservada.");
			}
			else
			{
				if (!neg.clienteExiste(txtDNI.Text))
				{
					altaCliente();
				}
				mandarMail(txtEmail.Text, txtNombre.Text);
			negocio.reservarMesa(IDMesa);
			
			int IDCliente = 0;
			IDCliente = negocio.IDCliente(txtDNI.Text);
			negocio.reservaWeb(IDMesa, IDCliente, cldReserva.SelectedDate);
			Response.Redirect("~/Reservada.aspx");
			}
		}

		protected void btnReservarDos_Click(object sender, EventArgs e)
		{
			int IDMesa = 2;
			ReservaNegocio negocio = new ReservaNegocio();
			if (negocio.estadoMesa(IDMesa))
			{
				popUp("Lamentablemente esta mesa ya se encuentra reservada.");
			}
			else
			{
				if (!neg.clienteExiste(txtDNI.Text))
				{
					altaCliente();
				}
				mandarMail(txtEmail.Text, txtNombre.Text);
				negocio.reservarMesa(IDMesa);
				int IDCliente = 0;
				IDCliente = negocio.IDCliente(txtDNI.Text);
				negocio.reservaWeb(IDMesa, IDCliente, cldReserva.SelectedDate);
				Response.Redirect("~/Reservada.aspx");
			}
		}

		protected void btnReservarTres_Click(object sender, EventArgs e)
		{
			int IDMesa = 3;
			ReservaNegocio negocio = new ReservaNegocio();
			if (negocio.estadoMesa(IDMesa))
			{
				popUp("Lamentablemente esta mesa ya se encuentra reservada.");
			}
			else
			{
				if (!neg.clienteExiste(txtDNI.Text))
				{
					altaCliente();
				}
				mandarMail(txtEmail.Text, txtNombre.Text);
				negocio.reservarMesa(IDMesa);
				int IDCliente = 0;
				IDCliente = negocio.IDCliente(txtDNI.Text);
				negocio.reservaWeb(IDMesa, IDCliente, cldReserva.SelectedDate);
				Response.Redirect("~/Reservada.aspx");
			}
		}

		protected void btnReservarCuatro_Click(object sender, EventArgs e)
		{
			int IDMesa = 4;
			ReservaNegocio negocio = new ReservaNegocio();
			if (negocio.estadoMesa(IDMesa))
			{
				popUp("Lamentablemente esta mesa ya se encuentra reservada.");
			}
			else
			{
				if (!neg.clienteExiste(txtDNI.Text))
				{
					altaCliente();
				}
				mandarMail(txtEmail.Text, txtNombre.Text);
				negocio.reservarMesa(IDMesa);
				int IDCliente = 0;
				IDCliente = negocio.IDCliente(txtDNI.Text);
				negocio.reservaWeb(IDMesa, IDCliente, cldReserva.SelectedDate);
				Response.Redirect("~/Reservada.aspx");
			}
		}

		protected void btnReservarCinco_Click(object sender, EventArgs e)
		{
			int IDMesa = 5;
			ReservaNegocio negocio = new ReservaNegocio();
			if (negocio.estadoMesa(IDMesa))
			{
				popUp("Lamentablemente esta mesa ya se encuentra reservada.");
			}
			else
			{
				if (!neg.clienteExiste(txtDNI.Text))
				{
					altaCliente();
				}
				mandarMail(txtEmail.Text, txtNombre.Text);
				negocio.reservarMesa(IDMesa);
				int IDCliente = 0;
				IDCliente = negocio.IDCliente(txtDNI.Text);
				negocio.reservaWeb(IDMesa, IDCliente, cldReserva.SelectedDate);
				Response.Redirect("~/Reservada.aspx");
			}
		}

		protected void btnReservarSeis_Click(object sender, EventArgs e)
		{
			int IDMesa = 6;
			ReservaNegocio negocio = new ReservaNegocio();
			if (negocio.estadoMesa(IDMesa))
			{
				popUp("Lamentablemente esta mesa ya se encuentra reservada.");
			}
			else
			{
				if (!neg.clienteExiste(txtDNI.Text))
				{
					altaCliente();
				}
				mandarMail(txtEmail.Text, txtNombre.Text);
				negocio.reservarMesa(IDMesa);
				int IDCliente = 0;
				IDCliente = negocio.IDCliente(txtDNI.Text);
				negocio.reservaWeb(IDMesa, IDCliente, cldReserva.SelectedDate);
				Response.Redirect("~/Reservada.aspx");
			}
		}

		protected void btnReservarSiete_Click(object sender, EventArgs e)
		{
			int IDMesa = 7;
			ReservaNegocio negocio = new ReservaNegocio();
			if (negocio.estadoMesa(IDMesa))
			{
				popUp("Lamentablemente esta mesa ya se encuentra reservada.");
			}
			else
			{
				if (!neg.clienteExiste(txtDNI.Text))
				{
					altaCliente();
				}
				mandarMail(txtEmail.Text, txtNombre.Text);
				negocio.reservarMesa(IDMesa);
				int IDCliente = 0;
				IDCliente = negocio.IDCliente(txtDNI.Text);
				negocio.reservaWeb(IDMesa, IDCliente, cldReserva.SelectedDate);
				Response.Redirect("~/Reservada.aspx");
			}
		}

		protected void btnReservarOcho_Click(object sender, EventArgs e)
		{
			int IDMesa = 8;
			ReservaNegocio negocio = new ReservaNegocio();
			if (negocio.estadoMesa(IDMesa))
			{
				popUp("Lamentablemente esta mesa ya se encuentra reservada.");
			}
			else
			{
				if (!neg.clienteExiste(txtDNI.Text))
				{
					altaCliente();
				}
				mandarMail(txtEmail.Text, txtNombre.Text);
				negocio.reservarMesa(IDMesa);
				int IDCliente = 0;
				IDCliente = negocio.IDCliente(txtDNI.Text);
				negocio.reservaWeb(IDMesa, IDCliente, cldReserva.SelectedDate);
				Response.Redirect("~/Reservada.aspx");
			}
		}

		protected bool mesaReservada(int mesa)
		{
			ReservaNegocio negocio = new ReservaNegocio();
			if (negocio.estadoMesa(mesa))
			{
				return true;
			}
			else
				return false;
		}

		private void cargarFormulario(Cliente cliente)
		{
			txtNombre.Text = cliente.Nombre;
			txtApellido.Text = cliente.Apellido;
			txtTelefono.Text = cliente.Telefono.Numero.ToString();
			txtCalle.Text = cliente.Direccion.Calle;
			txtNumeracion.Text = cliente.Direccion.Numeracion.ToString();
			txtLocalidad.Text = cliente.Direccion.Localidad.ToString();
			cldFechaNac.SelectedDate = cliente.FechaNac.FechaNac;
		}

		protected bool comprobarDNI()
		{
			ReservaNegocio negocio = new ReservaNegocio();
			Cliente cliente = new Cliente();
			if (negocio.comprobarDNI(Convert.ToInt32(txtDNI.Text), cliente))
			{

				cargarFormulario(cliente);
				return true;
			}
			else
			{
				return false;
			}
		}

		protected void btnHide_Click(object sender, EventArgs e)
		{
			comprobarDNI();
		}

		protected void altaCliente()
		{
			Cliente cli = new Cliente();
			cli.Telefono = new Telefono();
			cli.Direccion = new Direccion();
			cli.FechaNac = new Fecha();

			cli.Documento = Convert.ToInt32(txtDNI.Text);
			cli.Apellido = txtApellido.Text;
			cli.Nombre = txtNombre.Text;
			cli.Telefono.Numero = Convert.ToInt32(txtTelefono.Text);
			cli.Direccion.Calle = txtCalle.Text;
			cli.Direccion.Numeracion = Convert.ToInt32(txtNumeracion.Text);
			cli.Direccion.Localidad = txtLocalidad.Text;
			cli.FechaNac.FechaNac = cldFechaNac.SelectedDate;
			neg.agregarCliente(cli);

		}





	}
}