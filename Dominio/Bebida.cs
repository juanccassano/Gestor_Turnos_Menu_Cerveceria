using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Bebida
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public bool ContieneAlcohol { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
