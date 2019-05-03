using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Envio : Pedido
    {
        public int ID { get; set; }
        public bool Pago { get; set; }
        public Cliente Cliente { get; set; }

    }
}
