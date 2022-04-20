using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaBancaria
    {
        public int Codigo { get; set; }
        public string Numero { get; set; }
        public string CCI { get; set; }
        public bool Vigente { get; set; }
        public EntidadBancaria EntidadB { get; set; }
    }
}
