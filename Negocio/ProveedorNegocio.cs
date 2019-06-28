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
	public class ProveedorNegocio
	{
		public List<Proveedor> listarProveedors()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<Proveedor> listado = new List<Proveedor>();
			Proveedor proveedor;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select P.ID, P.DNI ,P.CUIT, P.Apellido, P.Nombre, P.Telefono, P.Calle, P.Numeracion, P.Localidad, P.FechaNac, P.Rubro, P.Monotributista, P.Responsable_Insc, P.Estado From PROVEEDORES P where P.Estado=1";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					proveedor = new Proveedor();
					proveedor.Telefono = new Telefono();
					proveedor.Direccion = new Direccion();
					proveedor.FechaNac = new Fecha();
					proveedor.ID = lector.GetInt32(0);
					proveedor.Documento = lector.GetInt32(1);
					proveedor.CUIT = lector["CUIT"].ToString();
					proveedor.Apellido = lector["Apellido"].ToString();
					proveedor.Nombre = lector["Nombre"].ToString();
					proveedor.Telefono.Numero = lector.GetInt32(5);
					proveedor.Direccion.Calle = lector["Calle"].ToString();
					proveedor.Direccion.Numeracion = lector.GetInt32(7);
					proveedor.Direccion.Localidad = lector["Localidad"].ToString();
					proveedor.FechaNac.FechaNac = lector.GetDateTime(9);
					proveedor.Rubro = lector["Rubro"].ToString();
					proveedor.Monotributista = (bool)lector["Monotributista"];
					proveedor.ResponsableInscripto = (bool)lector["Responsable_Insc"];
					listado.Add(proveedor);
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

		public void agregarProveedor(Proveedor nuevo)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into PROVEEDORES (DNI, CUIT, Apellido, Nombre, Telefono, Calle, Numeracion, Localidad, FechaNac, Rubro, Monotributista, Responsable_Insc) values";
				comando.CommandText += "('" + nuevo.Documento.ToString() + "','" + nuevo.CUIT + "','" + nuevo.Apellido + "','" + nuevo.Nombre + "','" + nuevo.Telefono.Numero.ToString() + "', '" + nuevo.Direccion.Calle + "', '" + nuevo.Direccion.Numeracion.ToString() + "', '" + nuevo.Direccion.Localidad + "', '" + nuevo.FechaNac.FechaNac + "', '" + nuevo.Rubro + "', '" + nuevo.Monotributista.ToString() + "', '" + nuevo.ResponsableInscripto.ToString() + "')";
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

		public void modificarProveedor(Proveedor modificar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{
				accesoDatos.setearConsulta("update PROVEEDORES Set DNI=@DNI, CUIT=@CUIT, Apellido=@Apellido, Nombre=@Nombre, Telefono=@Telefono, Calle=@Calle, Numeracion=@Numeracion, Localidad=@Localidad, FechaNac=@FechaNac, Rubro=@Rubro, Monotributista=@Monotributista, Responsable_Insc=@RI Where Id=" + modificar.ID.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@DNI", modificar.Documento);
				accesoDatos.Comando.Parameters.AddWithValue("@CUIT", modificar.CUIT);
				accesoDatos.Comando.Parameters.AddWithValue("@Apellido", modificar.Apellido);
				accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
				accesoDatos.Comando.Parameters.AddWithValue("@Telefono", modificar.Telefono.Numero);
				accesoDatos.Comando.Parameters.AddWithValue("@Calle", modificar.Direccion.Calle);
				accesoDatos.Comando.Parameters.AddWithValue("@Numeracion", modificar.Direccion.Numeracion);
				accesoDatos.Comando.Parameters.AddWithValue("@Localidad", modificar.Direccion.Localidad);
				accesoDatos.Comando.Parameters.AddWithValue("@FechaNac", modificar.FechaNac.FechaNac);
				accesoDatos.Comando.Parameters.AddWithValue("@Rubro", modificar.Rubro);
				accesoDatos.Comando.Parameters.AddWithValue("@Monotributista", modificar.Monotributista);
				accesoDatos.Comando.Parameters.AddWithValue("@RI", modificar.ResponsableInscripto);

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

		public void borrarProveedor(Proveedor borrar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update PROVEEDORES Set Estado=0 Where Id=" + borrar.ID.ToString());
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
