﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuota
    {
        public int Codigo { get; set; }
        public int Numero { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double Monto { get; set; }
    }
}