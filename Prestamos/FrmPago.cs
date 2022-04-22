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
    public partial class FrmPago : Form
    {
        private ICliente Cliente;
        public static FrmPago Instancia = null;
        List<TipoDocumento> tipoDocumentos;
        List<Prestamo> prestamos;

        private FrmPago()
        {
            InitializeComponent();
        }

        public static FrmPago LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmPago();
                }
                return Instancia;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string numeroDocumento = this.TxtNumeroDocumento.Text.Trim();
            LimpiarTablas();

            if (this.CboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar el tipo de cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.CboTipoCliente.Focus();
            }
            else if (this.CboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar el tipo de documento", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.CboTipoDocumento.Focus();
            }
            else if (this.CboTipoCliente.SelectedIndex == 0)
            {
                TipoDocumento tipoDocumento = (TipoDocumento)this.CboTipoDocumento.SelectedItem;
                this.BuscarClientePersona(numeroDocumento, tipoDocumento.Codigo);
            }
            else
            {
                this.BuscarClienteEmpresa(numeroDocumento);
            }

            if (this.Cliente != null)
            {
                this.TxtCliente.Text = this.Cliente.Nombre;
            }
            else
            {
                if (this.CboTipoCliente.SelectedIndex > -1 && this.CboTipoDocumento.SelectedIndex > -1)
                {
                    MessageBox.Show("Cliente no encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.TxtCliente.Text = "";
            }
        }

        private void LimpiarTablas()
        {
            this.DgvPrestamos.DataSource = null;
            this.DgvCuotas.DataSource = null;
        }

        private void BuscarClientePersona(string numeroDocumento, int codigoTipoDocumento)
        {
            RNClientePersona rnPersona;
            rnPersona = new RNClientePersona();
            try
            {
                this.Cliente = rnPersona.Leer(numeroDocumento, codigoTipoDocumento);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener al cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarClienteEmpresa(string numeroDocumento)
        {
            RNClienteEmpresa rnEmpresa;
            rnEmpresa = new RNClienteEmpresa();
            try
            {
                this.Cliente = rnEmpresa.Leer(numeroDocumento);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener al cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarAvanzada_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frm = new FrmBuscarCliente();

            this.Cliente = frm.Buscar(this.CboTipoCliente.SelectedIndex);

            if (this.Cliente != null)
            {
                this.PresentarDatos();
            }
            else
            {
                this.TxtCliente.Text = "";
            }
        }
        private void PresentarDatos()
        {
            LimpiarTablas();

            if (this.Cliente is ClientePersona)
            {
                this.CboTipoCliente.SelectedIndex = 0;
                this.CboTipoDocumento.SelectedValue = ((ClientePersona)this.Cliente).TipoDocumento.Codigo;
                this.TxtNumeroDocumento.Text = ((ClientePersona)this.Cliente).NumeroDocumento;
            }
            else
            {
                this.CboTipoCliente.SelectedIndex = 1;
                this.CboTipoDocumento.SelectedIndex = 0;
                this.TxtNumeroDocumento.Text = ((ClienteEmpresa)this.Cliente).RUC;
            }
            this.TxtCliente.Text = this.Cliente.Nombre;
        }

        private void CboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CboTipoCliente.SelectedIndex == 0)
            {
                this.CboTipoDocumento.DataSource = null;
                if (tipoDocumentos.Count > 0)
                {
                    CboTipoDocumento.DataSource = tipoDocumentos;
                    this.CboTipoDocumento.DisplayMember = "Nombre";
                    this.CboTipoDocumento.ValueMember = "Codigo";
                }
            }
            else
            {
                this.CboTipoDocumento.DataSource = null;
                this.CboTipoDocumento.Items.Add("RUC");
                this.CboTipoDocumento.SelectedIndex = 0;
            }
        }

        private void CargarTiposDocumentos()
        {
            RNTipoDocumento rn = new RNTipoDocumento();
            try
            {
                tipoDocumentos = rn.Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los tipos de documentos", this.Text);
            }
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            CargarTiposDocumentos();
            CargarFormaPago();
        }

        private void CargarFormaPago()
        {
            RNFomaPago rn = new RNFomaPago();
            try
            {
                List<FormaPago> formasPago = rn.Listar();
                this.CboFormaPago.DataSource = null;
                if (formasPago.Count > 0)
                {
                    CboFormaPago.DataSource = formasPago;
                    this.CboFormaPago.DisplayMember = "Nombre";
                    this.CboFormaPago.ValueMember = "Codigo";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar las formas de pago", this.Text);
            }
        }

        private void BtnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                BorrarErrores();
                RNPrestamo rn = new RNPrestamo(); ;
                this.prestamos = new List<Prestamo>();
                this.DgvPrestamos.DataSource = null;

                try
                {
                    prestamos = rn.PrestamosPorPagar(Cliente);
                    if (this.prestamos != null && this.prestamos.Count > 0)
                    {
                        this.DgvPrestamos.AutoGenerateColumns = false;
                        this.DgvPrestamos.DataSource = this.prestamos;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo obtener la lista de prestamos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBuscarPrestamo_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNumeroDocumento.Text = this.TxtNumeroDocumento.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNumeroDocumento.Text) == false)
            {
                this.ErrNotificador.SetError(this.TxtNumeroDocumento, "");
            }
            else
            {
                this.ErrNotificador.SetError(this.BtnBuscar, "Debe buscar un cliente");
                e.Cancel = true;
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                BorrarErrores();
                RNPrestamo rn = new RNPrestamo(); ;
                List<Cuota> cuotas = new List<Cuota>();
                this.DgvCuotas.DataSource = null;
                Prestamo prestamo = (Prestamo)this.DgvPrestamos.CurrentRow.DataBoundItem;
                try
                {
                    cuotas = rn.CuotasPorPagar(prestamo);
                    if (cuotas != null && cuotas.Count > 0)
                    {
                        this.DgvCuotas.AutoGenerateColumns = false;
                        this.DgvCuotas.DataSource = cuotas;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo obtener la lista de prestamos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BorrarErrores()
        {
            this.ErrNotificador.SetError(this.TxtNumeroDocumento, "");
        }
    }
}
