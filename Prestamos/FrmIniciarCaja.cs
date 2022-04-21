using Entidades;
using ReglaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class FrmIniciarCaja : Form
    {
        public static FrmIniciarCaja Instancia = null;
        Caja caja = null;
        public FrmIniciarCaja()
        {
            InitializeComponent();
        }
        public static FrmIniciarCaja LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmIniciarCaja();
                }
                return Instancia;
            }
        }

        public bool OperacionRealizada()
        {
            this.ShowDialog();
            return caja != null;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            caja = CrearEntidad();
            RNCaja rn;
            try
            {
                rn = new RNCaja();
                rn.IniciarCaja(caja);
                Sesion.Caja= rn.TieneCajaAbierta(Sesion.Usuario.Codigo);
            }
            catch (Exception)
            {
                throw;
            }
            this.Close();
        }

        private Caja CrearEntidad()
        {
            Caja caja = new Caja()
            {
                Estado = true,
                FechaInicio = DtpFechaInicio.Value,
                FechaFin = DtpFechaInicio.Value,
                Personal = new Personal()
                {
                    Codigo = Sesion.Usuario.Codigo
                }
            };
            return caja;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
