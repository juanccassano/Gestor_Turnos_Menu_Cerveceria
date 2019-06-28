using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int Numeracion { get; set; }
		public string Localidad { get; set; }

		public override string ToString()
		{
			string devuelto;
			devuelto = Calle + " " + Numeracion.ToString();
			return devuelto;
		}
	}
}
