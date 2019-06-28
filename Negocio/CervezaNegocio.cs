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
	public class CervezaNegocio
	{
		public List<Cerveza> listarCervezas()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<Cerveza> listado = new List<Cerveza>();
			Cerveza cerveza;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select C.ID, C.Nombre, C.Tipo, C.Graduacion_Alcoholica, C.Precio_Unitario, C.Estado From CERVEZAS C where C.Estado =1";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					cerveza = new Cerveza();
					cerveza.ID = lector.GetInt32(0);
					cerveza.Nombre = lector["Nombre"].ToString();
					cerveza.Tipo = lector["Tipo"].ToString();
					cerveza.GraduacionAlcoholica = lector.GetDecimal(3);
					cerveza.PrecioUnitario = lector.GetDecimal(4);
					listado.Add(cerveza);
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

		public void agregarCerveza(Cerveza nuevo)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into CERVEZAS (Nombre, Tipo, Graduacion_Alcoholica, Precio_Unitario) values";
				comando.CommandText += "('" + nuevo.Nombre + "', '" + nuevo.Tipo + "', '" + nuevo.GraduacionAlcoholica.ToString() + "', '" + nuevo.PrecioUnitario.ToString() + "')";
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

		public void modificarCerveza(Cerveza modificar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update CERVEZAS Set Nombre=@Nombre, Tipo=@Tipo, Graduacion_Alcoholica=@GA, Precio_Unitario=@PU Where Id=" + modificar.ID.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
				accesoDatos.Comando.Parameters.AddWithValue("@Tipo", modificar.Tipo);
				accesoDatos.Comando.Parameters.AddWithValue("@GA", modificar.GraduacionAlcoholica);
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

		public void borrarCerveza(Cerveza borrar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update CERVEZAS Set Estado=0 Where Id=" + borrar.ID.ToString());
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

