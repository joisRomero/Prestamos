using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Personal
    {
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string CorreoPersonal { get; set; }
        public string CorreoLaboral { get; set; }
        public string Celular { get; set; }
        public bool Vigente { get; set; }
    }
}
