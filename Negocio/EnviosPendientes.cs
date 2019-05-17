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
    public class EnviosPendientes
    {
        public List<Envio> listarEnviosPendientes()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Envio> listado = new List<Envio>();
            Envio nuevo;
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-BKKOHQN\\SQLEXPRESS; initial catalog=CASSANO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select ID, IDPEDIDO, IDCLIENTE, PAGO From ENVIOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Envio();
                    nuevo.ID = lector.GetInt32(0); 
                    nuevo.IDPedido = lector.GetInt32(1);
                    nuevo.Cliente = new Cliente();
                    nuevo.Cliente.IDCliente = lector.GetInt32(2);
                    nuevo.Pago = lector.GetBoolean(3);
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
