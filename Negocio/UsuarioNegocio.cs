using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data.SqlClient;
using Dominio;


namespace Negocio
{
	public class UsuarioNegocio
	{
		public bool validarUsuario(string usuario, string contra)
		{
			bool validado = false;
			int coincidencia = 0;
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			Usuario user;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select COUNT(Usuario) from USUARIOS Where Usuario='" + usuario.ToString() + "' AND Clave='" + contra.ToString() + "'";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					user = new Usuario();
					coincidencia = lector.GetInt32(0);

				}
				if (coincidencia == 0)
				{
					validado = false;
					return validado;
				}
				else
					validado = true;
				return validado;
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

		public void bloquearUsuario(string usuario)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{
				accesoDatos.setearConsulta("update USUARIOS Set Bloqueado=@Bloq Where Usuario='" + usuario + "'");
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@Bloq", "True");
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

		public void actualizarConteo(string usuario, int conteo)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{
				accesoDatos.setearConsulta("update USUARIOS Set Intentos=@Ints Where Usuario='" + usuario + "'");
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@Ints", conteo);
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

		public int conteoActual(string usuario)
		{
			int conteoActual = 0;
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			Usuario user;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select Intentos from USUARIOS Where Usuario='" + usuario.ToString() + "'";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					conteoActual = lector.GetInt32(0);

				}

				return conteoActual;
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

		public bool estadoUsuario(string usuario)
		{
			bool bloqueado = false;
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select Bloqueado from USUARIOS Where Usuario='" + usuario.ToString() + "'";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{

					bloqueado = lector.GetBoolean(0);
				}
				return bloqueado;
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

		public string tareaUsuario(int usuario)
		{
			string cargo = "Mesero";
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select TAREA from EMPLEADOS Where ID=" + usuario.ToString();
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					cargo = lector["Tarea"].ToString();

				}

				return cargo;
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

		public string datosUsuario(int usuario)
		{
			string nombre = "Vacío";
			string apellido = "Vacío";
			string nombreCompleto = "Vacío";

			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select NOMBRE, APELLIDO from EMPLEADOS Where ID=" + usuario.ToString();
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					nombre = lector["NOMBRE"].ToString();
					apellido = lector["APELLIDO"].ToString();
					nombreCompleto = nombre + " " + apellido;

				}

				return nombreCompleto;
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

		public int IDUsuario (string usuario)
		{
			int ID = 0;
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select ID from USUARIOS Where Usuario LIKE'" + usuario.ToString() + "'";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					ID = lector.GetInt32(0);

				}

				return ID;
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
