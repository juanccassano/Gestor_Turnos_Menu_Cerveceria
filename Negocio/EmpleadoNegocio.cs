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
	public class EmpleadoNegocio
	{
		public List<Empleado> listarEmpleados()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<Empleado> listado = new List<Empleado>();
			Empleado empleado;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select E.ID, E.Documento, E.Apellido, E.Nombre, E.Telefono, E.Calle, E.Numeracion, E.Localidad, E.FechaNac, E.Tarea, E.Fecha_Ingreso, E.Estado From EMPLEADOS E where E.Estado=1";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					empleado = new Empleado();
					empleado.Telefono = new Telefono();
					empleado.Direccion = new Direccion();
					empleado.FechaNac = new Fecha();
					empleado.FechaIngreso = new Fecha();

					empleado.ID = lector.GetInt32(0);
					empleado.Documento = lector.GetInt32(1);
					empleado.Apellido = lector["Apellido"].ToString();
					empleado.Nombre = lector["Nombre"].ToString();
					empleado.Telefono.Numero = lector.GetInt32(4);
					empleado.Direccion.Calle = lector["Calle"].ToString();
					empleado.Direccion.Numeracion = lector.GetInt32(6);
					empleado.Direccion.Localidad = lector["Localidad"].ToString();
					empleado.FechaNac.FechaNac = lector.GetDateTime(8);
					empleado.Tarea = lector["Tarea"].ToString();
					empleado.FechaIngreso.FechaNac = lector.GetDateTime(10);
					listado.Add(empleado);
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

		public void agregarEmpleado(Empleado nuevo)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into EMPLEADOS (Documento, Apellido, Nombre, Telefono, Calle, Numeracion, Localidad, FechaNac, Tarea, Fecha_Ingreso) values";
				comando.CommandText += "('" + nuevo.Documento.ToString() + "','" + nuevo.Apellido + "','" + nuevo.Nombre + "','" + nuevo.Telefono.Numero.ToString() + "', '" + nuevo.Direccion.Calle + "', '" + nuevo.Direccion.Numeracion.ToString() + "', '" + nuevo.Direccion.Localidad + "', '" + nuevo.FechaNac.FechaNac + "', '" + nuevo.Tarea + "', '" + nuevo.FechaIngreso.FechaNac + "')";
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

		public void modificarEmpleado(Empleado modificar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{
				accesoDatos.setearConsulta("update EMPLEADOS Set Documento=@DNI, Apellido=@Apellido, Nombre=@Nombre, Telefono=@Telefono, Calle=@Calle, Numeracion=@Numeracion, Localidad=@Localidad, FechaNac=@FechaNac, Tarea=@Tarea, Fecha_Ingreso=@FI Where Id=" + modificar.ID.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@DNI", modificar.Documento);
				accesoDatos.Comando.Parameters.AddWithValue("@Apellido", modificar.Apellido);
				accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
				accesoDatos.Comando.Parameters.AddWithValue("@Telefono", modificar.Telefono.Numero);
				accesoDatos.Comando.Parameters.AddWithValue("@Calle", modificar.Direccion.Calle);
				accesoDatos.Comando.Parameters.AddWithValue("@Numeracion", modificar.Direccion.Numeracion);
				accesoDatos.Comando.Parameters.AddWithValue("@Localidad", modificar.Direccion.Localidad);
				accesoDatos.Comando.Parameters.AddWithValue("@FechaNac", modificar.FechaNac.FechaNac);
				accesoDatos.Comando.Parameters.AddWithValue("@Tarea", modificar.Tarea);
				accesoDatos.Comando.Parameters.AddWithValue("@FI", modificar.FechaIngreso.FechaNac);
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

		public void borrarEmpleado(Empleado borrar)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update EMPLEADOS Set Estado=0 Where Id=" + borrar.ID.ToString());
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
