using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public Personal Personal { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public bool Vigente { get; set; }

        public string NombrePersonal
        {
            get
            {
                string dni = "";
                if (this.Personal != null)
                {
                    dni = this.Personal.DNI;
                }
                return dni;
            }
        }
    }
}
