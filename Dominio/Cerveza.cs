using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cerveza
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal GraduacionAlcoholica { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
