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
    public class PedidoMesa
    {
        public List<Pedido> listarPedidos()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Pedido> listado = new List<Pedido>();
            Pedido nuevo;
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                //   comando.CommandText = "select ID, IDPEDIDO, IDCLIENTE, PAGO From ENVIOS";
                comando.CommandText = "select ID, IDCLIENTE, PRECIO_FINAL From PEDIDOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Pedido();
                    nuevo.IDPedido = lector.GetInt32(0);
                    nuevo.Cliente = new Cliente();
                    nuevo.Cliente.IDCliente = lector.GetInt32(1);
                    nuevo.TotalAPagar = lector.GetDecimal(2);
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

		public List<ProductoPedido> listarProductos(int IDPedido)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<ProductoPedido> listado = new List<ProductoPedido>();
			ProductoPedido producto;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select P.IDBebida, B.Marca, P.IDPedido, P.Cantidad, P.Precio_Parcial, P.ID From PRODUCTOS_POR_PEDIDO P, BEBIDAS B where (P.IDBebida = B.ID) AND P.IDPedido=" + IDPedido.ToString();
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					producto = new ProductoPedido();
					producto.Tipo = "Bebida";
					producto.IDProducto = lector.GetInt32(0);
					producto.Descripcion = lector["Marca"].ToString();
					producto.IDPedido = lector.GetInt32(2);
					producto.Cantidad = lector.GetInt32(3);
					producto.PrecioParcial = lector.GetDecimal(4);
					producto.IDEnPedido = lector.GetInt32(5);
					listado.Add(producto);
				}
				conexion.Close();
				comando.CommandText = "select P.IDCerveza, C.Nombre, P.IDPedido, P.Cantidad, P.Precio_Parcial, P.ID From PRODUCTOS_POR_PEDIDO P, CERVEZAS C where (P.IDCerveza = C.ID) AND P.IDPedido=" + IDPedido.ToString();
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					producto = new ProductoPedido();
					producto.Tipo = "Cerveza";
					producto.IDProducto = lector.GetInt32(0);
					producto.Descripcion = lector["Nombre"].ToString();
					producto.IDPedido = lector.GetInt32(2);
					producto.Cantidad = lector.GetInt32(3);
					producto.PrecioParcial = lector.GetDecimal(4);
					producto.IDEnPedido = lector.GetInt32(5);
					listado.Add(producto);
				}
				conexion.Close();
				comando.CommandText = "select P.IDPlato, PL.Nombre, P.IDPedido, P.Cantidad, P.Precio_Parcial, P.ID From PRODUCTOS_POR_PEDIDO P, PLATOS PL where (P.IDPlato = PL.ID) AND P.IDPedido=" + IDPedido.ToString();
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					producto = new ProductoPedido();
					producto.Tipo = "Plato";
					producto.IDProducto = lector.GetInt32(0);
					producto.Descripcion = lector["Nombre"].ToString();
					producto.IDPedido = lector.GetInt32(2);
					producto.Cantidad = lector.GetInt32(3);
					producto.PrecioParcial = lector.GetDecimal(4);
					producto.IDEnPedido = lector.GetInt32(5);
					listado.Add(producto);
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


		public List<ProductoPedido> listarBebidas(int IDPedido)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<ProductoPedido> listado = new List<ProductoPedido>();
			ProductoPedido producto;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select P.IDBebida, B.Marca, P.IDPedido, P.Cantidad, P.Precio_Parcial, P.ID From PRODUCTOS_POR_PEDIDO P, BEBIDAS B where (P.IDBebida = B.ID) AND P.IDPedido=" + IDPedido.ToString();
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					producto = new ProductoPedido();
					producto.IDProducto = lector.GetInt32(0);
					producto.Descripcion = lector["Marca"].ToString();
					producto.IDPedido = lector.GetInt32(2);
					producto.Cantidad = lector.GetInt32(3);
					producto.PrecioParcial = lector.GetDecimal(4);
					producto.IDEnPedido = lector.GetInt32(5);
					listado.Add(producto);
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

		public List<ProductoPedido> listarCervezas(int IDPedido)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<ProductoPedido> listado = new List<ProductoPedido>();
			ProductoPedido cerveza;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select P.IDCerveza, C.Nombre, P.IDPedido, P.Cantidad, P.Precio_Parcial, P.ID From PRODUCTOS_POR_PEDIDO P, CERVEZAS C where (P.IDCerveza = C.ID) AND P.IDPedido=" + IDPedido.ToString();
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					cerveza = new ProductoPedido();
					cerveza.IDProducto = lector.GetInt32(0);
					cerveza.Descripcion = lector["Nombre"].ToString();
					cerveza.IDPedido = lector.GetInt32(2);
					cerveza.Cantidad = lector.GetInt32(3);
					cerveza.PrecioParcial = lector.GetDecimal(4);
					cerveza.IDEnPedido = lector.GetInt32(5);
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

		public List<ProductoPedido> listarPlatos(int IDPedido)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			List<ProductoPedido> listado = new List<ProductoPedido>();
			ProductoPedido plato;
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select P.IDPlato, PL.Nombre, P.IDPedido, P.Cantidad, P.Precio_Parcial, P.ID From PRODUCTOS_POR_PEDIDO P, PLATOS PL where (P.IDPlato = PL.ID) AND P.IDPedido=" + IDPedido.ToString();
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					plato = new ProductoPedido();
					plato.IDProducto = lector.GetInt32(0);
					plato.Descripcion = lector["Nombre"].ToString();
					plato.IDPedido = lector.GetInt32(2);
					plato.Cantidad = lector.GetInt32(3);
					plato.PrecioParcial = lector.GetDecimal(4);
					plato.IDEnPedido = lector.GetInt32(5);
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



		public void agregarPedido()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into PEDIDOS (IDCliente, IDEmpleado, Precio_Final) values";
				comando.CommandText += "(NULL, NULL, 1)";
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

		public void cargarPedido(int IDPedido)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update PEDIDOS Set Precio_Final=@PF Where ID=" + IDPedido.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@PF", precioFinalPedido(IDPedido));
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

		public void cargarIDEmpleado(int IDPedido, int IDEmpleado)
		{
			AccesoDatosManager accesoDatos = new AccesoDatosManager();
			try
			{

				accesoDatos.setearConsulta("update PEDIDOS Set IDEMPLEADO=@IDE Where ID=" + IDPedido.ToString());
				accesoDatos.Comando.Parameters.Clear();
				accesoDatos.Comando.Parameters.AddWithValue("@IDE", IDEmpleado);
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

		//comando.CommandText += "(NULL,(Select SUM(PRECIO_PARCIAL) from PRODUCTOS_POR_PEDIDO where IDPEDIDO =" + IDPedido.ToString() + ")";

		public int seleccionarPedido()
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			int pedido = 0 ;
			
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select MAX(ID) From PEDIDOS";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{	
					pedido = lector.GetInt32(0);
				}

				return pedido;

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


		public decimal precioFinalPedido(int IDPedido)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			decimal pedido = 0;

			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select SUM(Precio_Parcial) as 'Precio' From PRODUCTOS_POR_PEDIDO where IDPedido =" + IDPedido.ToString();
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					if (!Convert.IsDBNull(lector["Precio"]))
					{
						pedido = lector.GetDecimal(0);
					}
					else
					{
						return 0;
					}
				}

				return pedido;

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


		public void agregarBebidaPedido(int IDPedido, int IDBebida, int Cantidad, decimal Precio_Parcial)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into PRODUCTOS_POR_PEDIDO (IDPlato, IDBebida, IDCerveza, IDPedido, Cantidad, Precio_Parcial) values";
				comando.CommandText += "(NULL, '" + IDBebida.ToString() + "', NULL, '" + IDPedido.ToString() + "', '" + Cantidad.ToString() + "', '" + Precio_Parcial.ToString() + "')";
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

		public void agregarCervezaPedido(int IDPedido, int IDCerveza, int Cantidad, decimal Precio_Parcial)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into PRODUCTOS_POR_PEDIDO (IDPlato, IDBebida, IDCerveza, IDPedido, Cantidad, Precio_Parcial) values";
				comando.CommandText += "(NULL, NULL,'" + IDCerveza.ToString() + "', '" + IDPedido.ToString() + "', '" + Cantidad.ToString() + "', '" + Precio_Parcial.ToString() + "')";
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

		public void agregarPlatoPedido(int IDPedido, int IDPlato, int Cantidad, decimal Precio_Parcial)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "insert into PRODUCTOS_POR_PEDIDO (IDPlato, IDBebida, IDCerveza, IDPedido, Cantidad, Precio_Parcial) values";
				comando.CommandText += "('" + IDPlato.ToString() + "', NULL, NULL,'" + IDPedido.ToString() + "','" + Cantidad.ToString() + "', '" + Precio_Parcial.ToString() + "')";
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

		public void borrarBebida (int IDPedido, int IDBebida)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();

			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "Delete from PRODUCTOS_POR_PEDIDO where ID =" + IDBebida.ToString(); ;
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

		public void borrarCerveza(int IDPedido, int IDCerveza)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();

			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "Delete from PRODUCTOS_POR_PEDIDO where ID =" + IDCerveza.ToString(); ;
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

		public void borrarPlato(int IDPedido, int IDPlato)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();

			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "Delete from PRODUCTOS_POR_PEDIDO where ID =" + IDPlato.ToString(); ;
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

		public bool PedidoCerrado(int IDPedido)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			int pedido = 0;

			try
			{
				conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select COUNT(IDPedido) From PRODUCTOS_POR_PEDIDO where ID=" + IDPedido;
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					pedido = lector.GetInt32(0);
				}

				if (pedido == 0)
				{
					return true;
				}

				else
				{
					return false;
				}

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

