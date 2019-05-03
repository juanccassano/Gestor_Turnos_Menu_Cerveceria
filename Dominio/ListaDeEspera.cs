using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ListaDeEspera
    {
        public int Orden { get; set; }
        public int CantidadDePersonas { get; set; }
        public Cliente Cliente { get; set; }
    }
}
