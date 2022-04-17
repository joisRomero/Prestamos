using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos
{
    public class ReporteResumenClientesDistrito
    {
        public string Distrito { get; set; }
        public int CantidadEmpresas { get; set; }
        public int CantidadPersonas { get; set; }

        public int CantidadTotal
        {
            get
            {
                return this.CantidadEmpresas + this.CantidadPersonas;
            }
        }
    }
}
