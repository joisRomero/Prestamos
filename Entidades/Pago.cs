using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pago
    {
        public int Codigo { get; set; }
        public double Monto { get; set; }
        public string NumeroOperacion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Vigente { get; set; }
        public FormaPago FormaPago { get; set; }
        public Caja Caja { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }
        public List<CuotaPago> CuotasPago { get; set; }
    }
}
