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
        public string CodigoTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public bool Vigente { get; set; }
    }
}
