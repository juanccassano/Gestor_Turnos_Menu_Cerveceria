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
	public class MesaNegocio
	{
		/*public List<Mesa> listarMesas()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<Mesa> listado = new List<Mesa>();
			Mesa mesa;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select ID, Cantidad_Espacios , IDCLIENTE, IDPEDIDO From MESAS";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					mesa = new Mesa();
					mesa.Telefono = new Telefono();
					mesa.Direccion = new Direccion();
					mesa.FechaNac = new Fecha();
					mesa.IDMesa = lector.GetInt32(0);
					mesa.Documento = lector.GetInt32(1);
					mesa.Apellido = lector["Apellido"].ToString();
					mesa.Nombre = lector["Nombre"].ToString();
					mesa.Telefono.Numero = lector.GetInt32(4);
					mesa.Direccion.Calle = lector["Calle"].ToString();
					mesa.Direccion.Numeracion = lector.GetInt32(6);
					mesa.Direccion.Localidad = lector["Localidad"].ToString();
					mesa.FechaNac.FechaNac = lector.GetDateTime(8);
					listado.Add(mesa);
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
		}*/
	}
}
