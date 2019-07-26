using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Reserva
    {
		public int IDMesa { get; set; }
		public int IDCliente { get; set; }
		public DateTime FechaHora { get; set; }
	}
}
