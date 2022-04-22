using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteEmpresa : ICliente
    {
        public int Codigo { get; set; }
        public CategoriaCliente Categoria { get; set; }
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Distrito Distrito { get; set; }
        public string Direccion { get; set; }
        public bool Vigente { get; set; }

        public string Nombre
        {
            get
            {
                return this.RazonSocial;
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
                return "RUC : " + this.RUC;
            }
        }

        public string Tipo
        {
            get
            {
                return "Empresa";
            }
        }
    }
}
