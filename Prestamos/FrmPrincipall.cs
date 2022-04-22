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
    public partial class FrmPrincipall : Form
    {
        public FrmPrincipall()
        {
            InitializeComponent();
            this.CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            InformacionUsuario();
            EstadoCaja();
            MenusSegunUsuario();
        }

        private void EstadoCaja()
        {
            Caja caja;
            RNCaja rn;
            try
            {
                rn = new RNCaja();
                caja = rn.TieneCajaAbierta(Sesion.Usuario.Codigo);
                if (caja != null)
                {
                    Sesion.Caja = caja;
                }
            }
            catch (Exception)
            {

                throw;
            }

            if (caja == null)
            {
                LblBarraEstado.Text = "Cerrada";
                LblBarraEstado.ForeColor = Color.Red;
            }
            else
            {
                LblBarraEstado.Text = "Abierta";
                LblBarraEstado.ForeColor = Color.Green;
            }
        }

        private void InformacionUsuario()
        {
            LblBarraPersonal.Text = Sesion.Usuario.NombrePersonal;
            LblBarraNombreUsuario.Text = Sesion.Usuario.Nombre;
        }

        private void MenusSegunUsuario()
        {
            if (Sesion.Usuario.Tipo.Equals("L"))
            {
                LblBarraTipoUsuario.Text = "Limitado";
                MnuPersonal.Visible = false;
                MnuUsuarios.Visible = false;
                TsbPersonal.Visible = false;
                TsbUsuarios.Visible = false;
                Separador2.Visible = false;
                MnuSeparador2.Visible = false;
                Separador3.Visible = false;
                MnuCuentaBancaria.Visible = false;
                MnuEntidadBancaria.Visible = false;
                MnuListaTotalDePrestamos.Visible = false;
            }
            else
            {
                LblBarraTipoUsuario.Text = "Adminitrador";
            }
        }

        private void FrmPrincipall_Load(object sender, EventArgs e)
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
            if (Sesion.Caja == null || Sesion.Caja.Estado == false)
            {
                MessageBox.Show("La caja está cerrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmPrestamo frm = FrmPrestamo.LlamarFormulario;

                frm.MdiParent = this;
                frm.Show();
                frm.Focus();
            }
        }

        private void IniciarFrmPago()
        {
            if (Sesion.Caja == null || Sesion.Caja.Estado == false)
            {
                MessageBox.Show("La caja está cerrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmPago frm = FrmPago.LlamarFormulario;

                frm.MdiParent = this;
                frm.Show();
                frm.Focus();
            }
        }

        private void IniciarFrmListaPrestamos()
        {
            if (Sesion.Caja == null || Sesion.Caja.Estado == false)
            {
                MessageBox.Show("La caja está cerrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmListaPrestamos frm = FrmListaPrestamos.LlamarFormulario;

                frm.MdiParent = this;
                frm.Show();
                frm.Focus();
            }
        }

        private void IniciarFrmListaTotalPrestamos()
        {
            if (Sesion.Caja == null || Sesion.Caja.Estado == false)
            {
                MessageBox.Show("La caja está cerrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmListaTotalPrestamos frm = FrmListaTotalPrestamos.LlamarFormulario;

                frm.MdiParent = this;
                frm.Show();
                frm.Focus();
            }
        }

        private void IniciarFrmResumenClientesPorDistrito()
        {
            FrmResumenClientesPorDistrito frm = FrmResumenClientesPorDistrito.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void MnuEntidadBancaria_Click(object sender, EventArgs e)
        {
            FrmEntidadBancaria frm = FrmEntidadBancaria.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void MnuCuentaBancaria_Click(object sender, EventArgs e)
        {
            FrmCuentaBancaria frm = FrmCuentaBancaria.LlamarFormulario;

            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void MnuIniciarCaja_Click(object sender, EventArgs e)
        {
            if (Sesion.Caja != null && Sesion.Caja.Estado == true)
            {
                MessageBox.Show("La caja está iniciada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmIniciarCaja frm = FrmIniciarCaja.LlamarFormulario;
                if (frm.OperacionRealizada())
                {
                    LblBarraEstado.Text = "Abierta";
                    LblBarraEstado.ForeColor = Color.Green;
                }
            }
        }

        private void MnuCerrarCaja_Click(object sender, EventArgs e)
        {
            if (Sesion.Caja == null || Sesion.Caja.Estado == false)
            {
                MessageBox.Show("La caja está cerrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmCerrarCaja frm = FrmCerrarCaja.LlamarFormulario;
                if (frm.OperacionRealizada())
                {
                    LblBarraEstado.Text = "Cerrada";
                    LblBarraEstado.ForeColor = Color.Red;
                }
            }
        }

        #endregion

        #region Menus 
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

        private void MnuCerrarSesion_Click(object sender, EventArgs e)
        {
            Sesion.CerrarSesion = true;
            this.Close();
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Sesion.CerrarSesion = false;
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
        #endregion

        private void MnuPago_Click(object sender, EventArgs e)
        {
            IniciarFrmPago();
        }

        private void MnuEstadoDeCuenta_Click(object sender, EventArgs e)
        {
            if (Sesion.Caja != null && Sesion.Caja.Estado == true)
            {
                MessageBox.Show("La caja está cerrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MnuListaTotalDePrestamos_Click(object sender, EventArgs e)
        {
            IniciarFrmListaTotalPrestamos();
        }

        private void TsbPago_Click(object sender, EventArgs e)
        {
            IniciarFrmPago();
        }

    }
}
