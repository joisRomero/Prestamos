using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ICliente
    {
        int Codigo { get; set; }
        string Identidad { get; }
        string Nombre { get; }
        CategoriaCliente Categoria { get; set; }
    }
}
