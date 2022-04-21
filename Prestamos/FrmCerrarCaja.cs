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
    public partial class FrmCerrarCaja : Form
    {
        public static FrmCerrarCaja Instancia = null;
        Caja caja = null;
        public FrmCerrarCaja()
        {
            InitializeComponent();
        }

        public static FrmCerrarCaja LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmCerrarCaja();
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
                rn.CerrarCaja(caja);
                Sesion.Caja = caja;
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
                FechaFin = DtpFechaCierre.Value,
                Codigo = Sesion.Caja.Codigo,
                Personal = new Personal()
                {
                    Codigo = Sesion.Usuario.Codigo
                }
            };
            return caja;
        }

        private void FrmCerrarCaja_Load(object sender, EventArgs e)
        {
            DtpFechaInicio.Value = Sesion.Caja.FechaInicio;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
