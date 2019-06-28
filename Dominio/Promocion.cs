using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Promocion
    {
        public int ID { get; set; }
        public string TipoDescuento { get; set; }
        public int PorcentajeDescuento { get; set; }
		public bool Estado { get; set; }
	}
}
