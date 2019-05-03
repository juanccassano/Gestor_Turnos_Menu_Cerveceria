using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado : Persona
    {
     public int Legajo { get; set; }
        public string Tarea { get; set; }
        public Fecha FechaIngreso { get; set; }
    }
}
