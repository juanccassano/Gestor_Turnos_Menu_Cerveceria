using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public int Documento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public Telefono Telefono { get; set; }
        public Direccion Direccion { get; set; }
        public Fecha FechaNac { get; set; }
    }
}
