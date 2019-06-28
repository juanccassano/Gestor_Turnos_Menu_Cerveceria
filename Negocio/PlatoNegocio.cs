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
	public class PlatoNegocio
	{
		public List<Plato> listarPlatos()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<Plato> listado = new List<Plato>();
			Plato plato;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select P.ID, P.Nombre, P.APTO_CELIACOS, P.OPCION_VEGETARIANA, P.Precio_Unitario, P.Estado From PLATOS P where P.Estado =1";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					plato = new Plato();
					plato.ID = lector.GetInt32(0);
					plato.Nombre = lector["Nombre"].ToString();
					plato.AptoCeliacos = (bool)lector["Apto_celiacos"];
					plato.OpcionVegetariana = (bool)lector["Opcion_Vegetariana"];
					plato.PrecioUnitario = lector.GetDecimal(4);
					listado.Add(plato);
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

		public void agregarPlato(Plato nuevo)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into PLATOS (Nombre, Apto_Celiacos, Opcion_Vegetariana, Precio_Unitario) values";
				comando.CommandText += "('" + nuevo.Nombre + "', '" + nuevo.AptoCeliacos.ToString() + "', '" + nuevo.OpcionVegetariana.ToString() + "', '" + nuevo.PrecioUnitario.ToString() + "')";
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

		public void modificarPlato(Plato modificar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update PLATOS Set Nombre=@Nombre, Apto_Celiacos=@AC, Opcion_Vegetariana=@OV, Precio_Unitario=@PU Where Id=" + modificar.ID.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
				accesoDatos.Comando.Parameters.AddWithValue("@AC", modificar.AptoCeliacos);
				accesoDatos.Comando.Parameters.AddWithValue("@OV", modificar.OpcionVegetariana);
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

		public void borrarPlato(Plato borrar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update PLATOS Set Estado=0 Where Id=" + borrar.ID.ToString());
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
