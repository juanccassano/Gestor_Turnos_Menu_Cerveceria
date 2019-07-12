using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class ProductoPedido
	{
		public int IDEnPedido { get; set; }
		public int IDProducto { get; set; }
		public string Descripcion { get; set; }
		public int IDPedido { get; set; }
		public int Cantidad { get; set; }
		public decimal PrecioParcial { get; set; }
	}
}
