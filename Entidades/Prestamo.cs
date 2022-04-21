using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        public int Codigo { get; set; }
        public ICliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Interes { get; set; }
        public double Monto { get; set; }
        public string TipoPeriodo { get; set; } 
        public int CantidadPeriodos { get; set; }
        public bool DejaGarantia { get; set; }
        public bool Vigente { get; set; }
        public List<Cuota> Cuotas { get; set; }

        public string DocumentoCliente
        {
            get
            {
                return this.Cliente.Identidad;
            }
        }

        public string NombreCliente
        {
            get
            {
                return this.Cliente.Nombre;
            }
        }

        public string DescripcionTipoPeriodo
        {
            get
            {
                string[] nombres = { "Diario", "Semanal", "Mensual" };
                string letras = "DSM";

                return nombres[letras.IndexOf(this.TipoPeriodo)];
            }
        }
    }
}
