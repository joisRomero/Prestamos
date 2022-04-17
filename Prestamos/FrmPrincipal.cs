using Entidades;
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
    public partial class FrmPrincipal : Form
    {
        private Configuracion configuracion;
        public FrmPrincipal()
        {
            InitializeComponent();
            //@rodo
        }

        #region Iniciar formularios

        private void IniciarFrmCategoriaCliente()
        {
            FrmCategoriaCliente frm = FrmCategoriaCliente.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void IniciarFrmClienteEmpresa()
        {
            FrmClienteEmpresa frm = FrmClienteEmpresa.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void IniciarFrmClientePersona()
        {
            FrmClientePersona frm = FrmClientePersona.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void IniciarFrmPersonal()
        {
            FrmPersonal frm = FrmPersonal.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void IniciarFrmUsuarios()
        {
            FrmUsuario frm = FrmUsuario.LLamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void IniciarFrmDistritos()
        {
            FrmDistrito frm = FrmDistrito.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void IniciarFrmPrestamo()
        {
            FrmPrestamo frm = FrmPrestamo.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void IniciarFrmListaPrestamos()
        {
            FrmListaPrestamos frm = FrmListaPrestamos.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void IniciarFrmResumenClientesPorDistrito()
        {
            FrmResumenClientesPorDistrito frm = FrmResumenClientesPorDistrito.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        #endregion

        #region Menú predeterminado
        private void MnuCategoriaCliente_Click(object sender, EventArgs e)
        {
            this.IniciarFrmCategoriaCliente();
        }

        private void MnuEmpresas_Click(object sender, EventArgs e)
        {
            this.IniciarFrmClienteEmpresa();   
        }

        private void MnuPersonas_Click(object sender, EventArgs e)
        {
            this.IniciarFrmClientePersona();
        }

        private void MnuPersonal_Click(object sender, EventArgs e)
        {
            this.IniciarFrmPersonal();
        }

        private void MnuUsuarios_Click(object sender, EventArgs e)
        {
            this.IniciarFrmUsuarios();
        }

        private void MnuDistritos_Click(object sender, EventArgs e)
        {
            this.IniciarFrmDistritos();
        }

        private void MnuPrestamo_Click(object sender, EventArgs e)
        {
            this.IniciarFrmPrestamo();
        }

        private void MnuConfiguracion_Click(object sender, EventArgs e)
        {
            this.ConfigurarFrmPrincipal();
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuListaPrestamos_Click(object sender, EventArgs e)
        {
            IniciarFrmListaPrestamos();
        }

        private void MnuResumenDeClientePorDistrito_Click(object sender, EventArgs e)
        {
            IniciarFrmResumenClientesPorDistrito();
        }

        #endregion

        #region Menú Ribbo
        private void RbConfiguracion_Click(object sender, EventArgs e)
        {
            this.ConfigurarFrmPrincipal();
        }

        private void RbCategoriaCliente_Click(object sender, EventArgs e)
        {
            this.IniciarFrmCategoriaCliente();
        }

        private void RbDistritos_Click(object sender, EventArgs e)
        {
            this.IniciarFrmDistritos();
        }

        private void RbEmpreas_Click(object sender, EventArgs e)
        {
            this.IniciarFrmClienteEmpresa();
        }

        private void RbPersonas_Click(object sender, EventArgs e)
        {
            this.IniciarFrmClientePersona();
        }

        private void RbPersonal_Click(object sender, EventArgs e)
        {
            this.IniciarFrmPersonal();
        }

        private void RbUsuarios_Click(object sender, EventArgs e)
        {
            this.IniciarFrmUsuarios();
        }

        private void RbPrestamo_Click(object sender, EventArgs e)
        {
            this.IniciarFrmPrestamo();
        }
        #endregion

        #region Barra de herramientas
        private void TsbCategoriaCliente_Click(object sender, EventArgs e)
        {
            this.IniciarFrmCategoriaCliente();
        }

        private void TsbDistritos_Click(object sender, EventArgs e)
        {
            this.IniciarFrmDistritos();
        }

        private void TsbEmpresas_Click(object sender, EventArgs e)
        {
            this.IniciarFrmClienteEmpresa();
        }

        private void TsbPersonas_Click(object sender, EventArgs e)
        {
            this.IniciarFrmClientePersona();
        }

        private void TsbPersonal_Click(object sender, EventArgs e)
        {
            this.IniciarFrmPersonal();
        }

        private void TsbUsuarios_Click(object sender, EventArgs e)
        {
            this.IniciarFrmUsuarios();
        }

        private void TsbPrestamo_Click(object sender, EventArgs e)
        {
            this.IniciarFrmPrestamo();
        }

        private void TsbConfiguracion_Click(object sender, EventArgs e)
        {
            this.ConfigurarFrmPrincipal();
        }
        #endregion

        private void ConfigurarFrmPrincipal()
        {
            configuracion = new Configuracion
            {
                EsVisibleMenuPreterminado = this.MnuBarraPredeterminada.Visible,
                EsVisibleMnuRibbon = this.MnuRibbon.Visible,
                AgregarBarraHerramientas = this.TsBarraHerramientas.Visible
            };
            FrmConfiguracion frm = new FrmConfiguracion();
            configuracion = frm.ObtenerConfiguracion(configuracion);
            if (configuracion != null)
            {
                this.MnuBarraPredeterminada.Visible = configuracion.EsVisibleMenuPreterminado;
                this.MnuRibbon.Visible = configuracion.EsVisibleMnuRibbon;
                this.TsBarraHerramientas.Visible = configuracion.AgregarBarraHerramientas;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.CambiarColorFondo();
        }

        private void CambiarColorFondo()
        {
            MdiClient oMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    oMDI = (MdiClient)ctl;
                    oMDI.BackColor = Color.Gainsboro;
                }
                catch (InvalidCastException)
                {
                }
            }
        }

        private void RBListadoPrestamos_Click(object sender, EventArgs e)
        {
            IniciarFrmListaPrestamos();
        }

        private void RbResumenClientesDistrito_Click(object sender, EventArgs e)
        {
            IniciarFrmResumenClientesPorDistrito();
        }
    }
}
