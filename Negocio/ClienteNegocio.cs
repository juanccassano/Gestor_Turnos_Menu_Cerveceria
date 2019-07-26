using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
	public class ClienteNegocio
	{
		public List<Cliente> listarClientes()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<Cliente> listado = new List<Cliente>();
			Cliente cliente;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select C.ID, C.Documento , C.Apellido, C.Nombre, C.Telefono, C.Calle, C.Numeracion, C.Localidad, C.FechaNac From CLIENTES C";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					cliente = new Cliente();
					cliente.Telefono = new Telefono();
					cliente.Direccion = new Direccion();
					cliente.FechaNac = new Fecha();
					cliente.IDCliente = lector.GetInt32(0);
					cliente.Documento = lector.GetInt32(1);
					cliente.Apellido = lector["Apellido"].ToString();
					cliente.Nombre = lector["Nombre"].ToString();
					cliente.Telefono.Numero = lector.GetInt32(4);
					cliente.Direccion.Calle = lector["Calle"].ToString();
					cliente.Direccion.Numeracion = lector.GetInt32(6);
					cliente.Direccion.Localidad = lector["Localidad"].ToString();
					cliente.FechaNac.FechaNac = lector.GetDateTime(8);
					listado.Add(cliente);
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

		public void agregarCliente(Cliente nuevo)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into CLIENTES (Documento, Apellido, Nombre, Telefono, Calle, Numeracion, Localidad, FechaNac) values";
				comando.CommandText += "('" + nuevo.Documento.ToString() + "','" + nuevo.Apellido + "','" + nuevo.Nombre + "','" + nuevo.Telefono.Numero.ToString() + "', '" + nuevo.Direccion.Calle + "', '" + nuevo.Direccion.Numeracion.ToString() + "', '" + nuevo.Direccion.Localidad + "', '" + nuevo.FechaNac.FechaNac + "')";
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

		public void modificarCliente(Cliente modificar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{
				accesoDatos.setearConsulta("update CLIENTES Set Documento=@DNI, Apellido=@Apellido, Nombre=@Nombre, Telefono=@Telefono, Calle=@Calle, Numeracion=@Numeracion, Localidad=@Localidad, FechaNac=@FechaNac Where Id=" + modificar.IDCliente.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@DNI", modificar.Documento);
				accesoDatos.Comando.Parameters.AddWithValue("@Apellido", modificar.Apellido);
				accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
				accesoDatos.Comando.Parameters.AddWithValue("@Telefono", modificar.Telefono.Numero);
				accesoDatos.Comando.Parameters.AddWithValue("@Calle", modificar.Direccion.Calle);
				accesoDatos.Comando.Parameters.AddWithValue("@Numeracion", modificar.Direccion.Numeracion);
				accesoDatos.Comando.Parameters.AddWithValue("@Localidad", modificar.Direccion.Localidad);
				accesoDatos.Comando.Parameters.AddWithValue("@FechaNac", modificar.FechaNac.FechaNac);
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

		public int ultimoCliente()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			int resultado = 0;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select MAX(ID) From CLIENTES";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					resultado = lector.GetInt32(0);
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

		public void agregarIntentos(int IDCliente)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into RESERVAS_FALLIDAS (IDCliente, Intentos) values";
				comando.CommandText += "(" + IDCliente.ToString() + ",0)";
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

	}
}
