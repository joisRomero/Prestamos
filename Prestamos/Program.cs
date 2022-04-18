using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    static class Program
    {
        public static List<CategoriaCliente> Categorias = new List<CategoriaCliente>();
        public static List<Distrito> Distritos = new List<Distrito>();
        public static List<ClienteEmpresa> Empresas = new List<ClienteEmpresa>();
        public static List<ClientePersona> Personas = new List<ClientePersona>();
        public static List<Personal> Personal = new List<Personal>();
        public static List<Usuario> Usuarios = new List<Usuario>();
        public static List<Prestamo> Prestamos = new List<Prestamo>();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmIniciarSesion());
        }

        public static void CargarDatos()
        {
            //CargarCategorias();
            //CargarDistritos();
            //CargarPersonal();
            //CargarEmpresas();
            //CargarPersonas();
            //CargarPrestamos();
        }
    }
}
