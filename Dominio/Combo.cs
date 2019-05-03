using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Combo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Plato Plato { get; set; }
        public Bebida Bebida { get; set; }
        public Cerveza Cerveza { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
