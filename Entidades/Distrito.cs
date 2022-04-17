using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Distrito
    {
        public int Codigo { get; set; }
        public string DistritoNombre { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
        public bool Vigente { get; set; }
        public override string ToString()
        {
            return DistritoNombre;
        }
    }

}
