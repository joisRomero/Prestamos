using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CategoriaCliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Interes { get; set; } // tasa de interes anual 360 dias
        public bool Vigente { get; set; }
        public bool Negociable { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
