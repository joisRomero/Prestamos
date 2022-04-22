using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteListaPagos
    {
        public DateTime Fecha { get; set; }
        public double MontoPagado { get; set; }
        public string FormaPago { get; set; }
        public string NombreCliente { get; set; }
    }
}
