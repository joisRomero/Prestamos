using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteListaTotalPrestamo
    {
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoPrestado { get; set; }
        public double MontoPagado { get; set; }
    }
}
