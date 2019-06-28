﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Plato
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool AptoCeliacos { get; set; }
        public bool OpcionVegetariana { get; set; }
        public decimal PrecioUnitario { get; set; }
		public bool Estado { get; set; }

		public override string ToString()
		{
			return Nombre;

		}
	}
}
