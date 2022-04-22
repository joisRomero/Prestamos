using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuotaPago
    {
        public Pago Pago { get; set; }
        public Cuota Cuota { get; set; }
        public double Monto { get; set; }
        public bool Vigente { get; set; }
    }
}
