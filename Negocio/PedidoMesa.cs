using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

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
    }
}

