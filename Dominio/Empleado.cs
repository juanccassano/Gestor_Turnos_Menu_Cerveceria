using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado : Persona
    {
		public int ID { get; set; }
        public string Tarea { get; set; }
        public Fecha FechaIngreso { get; set; }
		public bool Estado { get; set; }
	}
}
