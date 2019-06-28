using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor : Persona
    {
		public int ID { get; set; }
		public string Rubro { get; set; }
        public bool Monotributista { get; set; }
        public bool ResponsableInscripto { get; set; }
        public string CUIT { get; set; }
		public bool Estado { get; set; }

	}
}
