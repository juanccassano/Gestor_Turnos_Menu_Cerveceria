﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Persona
    {
        public int IDCliente { get; set; }
		public override string ToString()
        {
            return IDCliente.ToString();
        }
    }
    
}
