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
	public class BebidaNegocio
	{
		public List<Bebida> listarBebidas()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<Bebida> listado = new List<Bebida>();
			Bebida bebida;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select B.ID, B.Nombre, B.Marca, B.Contiene_Alcohol, B.Precio_Unitario, B.Estado From BEBIDAS B where B.Estado =1";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					bebida = new Bebida();
					bebida.ID = lector.GetInt32(0);
					bebida.Nombre = lector["Nombre"].ToString();
					bebida.Marca = lector["Marca"].ToString();
					bebida.ContieneAlcohol = (bool)lector["Contiene_Alcohol"];
					bebida.PrecioUnitario = lector.GetDecimal(4);
					listado.Add(bebida);
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

		public void agregarBebida(Bebida nuevo)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into BEBIDAS (Nombre, Marca, Contiene_Alcohol, Precio_Unitario) values";
				comando.CommandText += "('" + nuevo.Nombre + "', '" + nuevo.Marca + "', '" + nuevo.ContieneAlcohol.ToString() + "', '" + nuevo.PrecioUnitario.ToString()+ "')";
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

		public void modificarBebida(Bebida modificar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update BEBIDAS Set Nombre=@Nombre, Marca=@Marca, Contiene_Alcohol=@CA, Precio_Unitario=@PU Where Id=" + modificar.ID.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
				accesoDatos.Comando.Parameters.AddWithValue("@Marca", modificar.Marca);
				accesoDatos.Comando.Parameters.AddWithValue("@CA", modificar.ContieneAlcohol);
				accesoDatos.Comando.Parameters.AddWithValue("@PU", modificar.PrecioUnitario);
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

		public void borrarBebida (Bebida borrar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update BEBIDAS Set Estado=0 Where Id=" + borrar.ID.ToString());
				accesoDatos.Comando.Parameters.Clear();
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

	}
}
