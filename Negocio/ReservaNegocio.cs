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

	}
}
