using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class Usuario
	{
		public string ID { get; set; }
		public string User { get; set; }
		public string Clave { get; set; }
		public int Intentos { get; set; }
		public int Bloqueado { get; set; }
	}
}
