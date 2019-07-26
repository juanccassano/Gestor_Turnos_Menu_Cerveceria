using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Data.SqlClient;

namespace Negocio
{
	public class ReservaNegocio
	{
		public List<Mesa> listarMesas()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<Mesa> listado = new List<Mesa>();
			Mesa nuevo;
			try
			{
				conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select ID, CANTIDAD_ESPACIOS, RESERVADA From MESAS";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					nuevo = new Mesa();
					nuevo.ID = lector.GetInt32(0);
					nuevo.CantidadDeEspacios = lector.GetInt32(1);
					nuevo.Reservada = lector.GetBoolean(2);
					listado.Add(nuevo);
				}

				return listado;

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}

		public void habilitarMesa(int IDMesa)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update MESAS Set RESERVADA=@R Where ID=" + IDMesa.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@R", 0);
				accesoDatos.abrirConexion();
				accesoDatos.ejecutarAccion();

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				accesoDatos.cerrarConexion();
			}
		}

		public void reservarMesa(int IDMesa)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update MESAS Set RESERVADA=@R Where ID=" + IDMesa.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@R", 1);
				accesoDatos.abrirConexion();
				accesoDatos.ejecutarAccion();

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				accesoDatos.cerrarConexion();
			}
		}

		public bool estadoMesa(int numeroMesa)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			bool resultado = false;
			List<Mesa> listado = new List<Mesa>();
			try
			{
				conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select ID, CANTIDAD_ESPACIOS, RESERVADA From MESAS where ID="+ numeroMesa;
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					resultado = lector.GetBoolean(2);
				}

				return resultado;

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}

		public void reservaCliente(Reserva nuevo)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into RESERVAS (IDMesa, IDCliente, Fecha) values";
				comando.CommandText += "('" + nuevo.IDMesa.ToString() + "', '" + nuevo.IDCliente.ToString() + "', '" + nuevo.FechaHora.ToString() + "')";
				comando.Connection = conexion;
				conexion.Open();

				comando.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}

		public void reservaWeb (int IDMesa, int IDCliente, DateTime Fecha)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into RESERVAS (IDMesa, IDCliente, Fecha) values";
				comando.CommandText += "('" + IDMesa.ToString() + "', '" + IDCliente.ToString() + "', '" + Fecha.ToString() + "')";
				comando.Connection = conexion;
				conexion.Open();

				comando.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}


		public string fechaReserva(int numeroMesa)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			string resultado = "";
			try
			{
				conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select TOP 1 FECHA From Reservas where IDMesa=" + numeroMesa + " ORDER BY ID DESC";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					resultado = lector.GetDateTime(0).ToString();
				}

				return resultado;

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}

		public string nombreReserva(int numeroMesa)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			string resultado = "";
			string apellido = "";
			string nombre = "";
			int IDCliente =0;
			try
			{
				conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select TOP 1 IDCLIENTE From Reservas where IDMesa=" + numeroMesa + " ORDER BY ID DESC";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					IDCliente = lector.GetInt32(0);
				}
				conexion.Close();

				comando.CommandText = "select APELLIDO, NOMBRE From CLIENTES where ID=" + IDCliente;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					apellido = lector["Apellido"].ToString();
					nombre = lector["Nombre"].ToString();

				}

				resultado = nombre + " " + apellido;


				return resultado;

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}

		public Reserva datosReserva(int numeroMesa)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			Reserva reserva = new Reserva();
			try
			{
				conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select TOP 1 IDMesa, IDCLIENTE, Fecha From Reservas where IDMesa=" + numeroMesa + " ORDER BY ID DESC";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					reserva.IDMesa = lector.GetInt32(0);
					reserva.IDCliente = lector.GetInt32(1);
					reserva.FechaHora = lector.GetDateTime(2);
				}

				return reserva;

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}

		public bool usuarioHabilitado(int IDUsuario)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			bool resultado = true;
			int intentos = 0;
			try
			{
				conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select INTENTOS From RESERVAS_FALLIDAS where IDCliente=" + IDUsuario;
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					intentos = lector.GetInt32(0);
				}

				if (intentos > 2)

				{
					resultado = false;
				}

				return resultado;

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}

		public int intentosTotales(int IDUsuario)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			int intentos = 0;
			try
			{
				conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select INTENTOS From RESERVAS_FALLIDAS where IDCliente=" + IDUsuario;
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					intentos = lector.GetInt32(0);
				}

				return intentos;

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}

		public void sumarIntento(int IDCliente, int Intentos)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update RESERVAS_FALLIDAS Set INTENTOS=@I Where IDCliente=" + IDCliente.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@I", Intentos);
				accesoDatos.abrirConexion();
				accesoDatos.ejecutarAccion();

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				accesoDatos.cerrarConexion();
			}
		}

		public bool comprobarDNI(int DNI, Cliente cliente)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{
				accesoDatos.setearConsulta("SELECT * FROM CLIENTES WHERE DOCUMENTO = " + DNI);
				accesoDatos.abrirConexion();
				accesoDatos.ejecutarConsulta();
				while (accesoDatos.Lector.Read())
				{
					cliente.Telefono = new Telefono();
					cliente.Direccion = new Direccion();
					cliente.FechaNac = new Fecha();
					cliente.IDCliente = Convert.ToInt32(accesoDatos.Lector.GetInt32(0));
					cliente.Documento = accesoDatos.Lector.GetInt32(1);
					cliente.Apellido = accesoDatos.Lector.GetString(2);
					cliente.Nombre = accesoDatos.Lector.GetString(3);
					cliente.Telefono.Numero = accesoDatos.Lector.GetInt32(4);
					cliente.Direccion.Calle = accesoDatos.Lector.GetString(5);
					cliente.Direccion.Numeracion = accesoDatos.Lector.GetInt32(6);
					cliente.Direccion.Localidad = accesoDatos.Lector.GetString(7);
					cliente.FechaNac.FechaNac = accesoDatos.Lector.GetDateTime(8);
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				accesoDatos.cerrarConexion();
			}
		}

		public int IDCliente (string DNI)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			int IDCliente = 0;
			try
			{
				conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select ID From Clientes where Documento=" + DNI;
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					IDCliente = lector.GetInt32(0);
				}

				return IDCliente;

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conexion.Close();
			}
		}


	}
}
