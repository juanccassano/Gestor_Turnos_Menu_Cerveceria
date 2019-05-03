using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Reserva
    {
        public int ID { get; set; }
        public int CantidadDeEspacios { get; set; }
        public Cliente Cliente { get; set; }
        public Mesa Mesa { get; set; }
    }
}
