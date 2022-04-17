using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades 
{
    public class ClientePersona : ICliente
    {
        public CategoriaCliente Categoria { get; set; }
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; } // DNI, Carnet de extranjería, Pasaporte
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Distrito Distrito { get; set; }
        public string Direccion { get; set; }
        public string CorreoPersonal { get; set; }
        public string Celular { get; set; }
        public bool Vigente { get; set; }

        public string NombreCompleto
        {
            get
            {
                return $"{this.Apellidos} {this.Nombres}";
            }
        }
        public string NombreCategoria
        {
            get
            {
                string nombre = "";

                if (this.Categoria != null)
                {
                    nombre = this.Categoria.Nombre;
                }

                return nombre;
            }
        }

        public string NombreDistrito
        {
            get
            {
                string dist = "";

                if (this.Distrito != null)
                {
                    dist = this.Distrito.DistritoNombre;
                }

                return dist;
            }
        }

        public string Identidad
        {
            get
            {
                return $"{this.SiglasTipoDocumento} : {this.NumeroDocumento}";
            }
        }

        public string SiglasTipoDocumento
        {
            get
            {
                string siglas = "";
                switch (this.TipoDocumento)
                {
                    case "D": siglas = "DNI"; break;
                    case "C": siglas = "Carnet extrangería"; break;
                    case "P": siglas = "Pasaporte"; break;
                }
                return siglas;
            }
        }

        public string Nombre
        {
            get
            {
                return this.NombreCompleto;
            }
        }

    }
}
