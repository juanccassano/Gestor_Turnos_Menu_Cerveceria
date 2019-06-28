using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Fecha
	{
        public DateTime FechaNac { get; set; }
		//public int Dia { get; set; }
		//public int Mes { get; set; }
		//public int Año { get; set; }
		public override string ToString()
		{
			return FechaNac.ToShortDateString();
		}
	}
}
