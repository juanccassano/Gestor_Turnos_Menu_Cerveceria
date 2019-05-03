using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesa
    {
        public int ID { get; set; }
        public int CantidadDeEspacios { get; set; }
        public Cliente Cliente { get; set; }
        public Pedido Pedido { get; set; }
    }
}
