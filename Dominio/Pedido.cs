using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public int IDPedido { get; set; }
        public decimal TotalAPagar { get; set; }
        public Bebida Bebida { get; set; }
        public Cerveza Cerveza{ get; set; }
        public Plato Plato { get; set; }
        public Combo Combo { get; set; }
        public Promocion Promocion { get; set; }
        public Cliente Cliente { get; set; }

    }
}
