using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteListaPrestamos
    {
        public string TipoCliente { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoPrestado { get; set; }
        public double Interes { get; set; }
        public string Periodo { get; set; }
        public int CantidadCuotas { get; set; }

    }
}
