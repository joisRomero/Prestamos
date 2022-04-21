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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Diagnostics;
using System.Threading;
using ReglaNegocio;

namespace Prestamos
{
    public partial class FrmPrestamo : Form
    {
        private ICliente Cliente;
        public static FrmPrestamo Instancia = null;
        private List<Cuota> Cuotas = new List<Cuota>();
        List<TipoDocumento> tipoDocumentos;
        SaveFileDialog GuardarArchivoDialogo = new SaveFileDialog();
        private bool estaExportanto = false;
        private Thread subProceso;
        private FrmPrestamo()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public static FrmPrestamo LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmPrestamo();
                }
                return Instancia;
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
            if (this.Cliente is ClientePersona)
            {
                this.CboTipoCliente.SelectedIndex = 0;
                //switch (((ClientePersona)this.Cliente).TipoDocumento)
                //{
                //    case "D": this.CboTipoDocumento.SelectedIndex = 0; break;
                //    case "C": this.CboTipoDocumento.SelectedIndex = 1; break;
                //    case "P": this.CboTipoDocumento.SelectedIndex = 2; break;
                //}
                this.TxtNumeroDocumento.Text = ((ClientePersona)this.Cliente).NumeroDocumento;
            }
            else
            {
                this.CboTipoCliente.SelectedIndex = 1;
                this.CboTipoDocumento.SelectedIndex = 0;
                this.TxtNumeroDocumento.Text = ((ClienteEmpresa)this.Cliente).RUC;
            }
            this.TxtCliente.Text = this.Cliente.Nombre;
            this.NudInteres.Value = (decimal)this.Cliente.Categoria.InteresAnual;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {            
            string numeroDocumento = this.TxtNumeroDocumento.Text.Trim();
            TipoDocumento tipoDocumento = (TipoDocumento)this.CboTipoDocumento.SelectedItem;

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
                this.BuscarClientePersona(numeroDocumento, tipoDocumento.Codigo);
            }
            else
            {
                this.BuscarClienteEmpresa(numeroDocumento);
            }

            if (this.Cliente != null)
            {
                this.TxtCliente.Text = this.Cliente.Nombre;
                this.NudInteres.Value = (decimal)this.Cliente.Categoria.InteresAnual;
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

        private void GenerarCuotas(double montoTotal)
        {
            DateTime fechaInicio = this.DtpFecha.Value;
            decimal montoCuota = Math.Round((decimal)montoTotal / NudCantidadPeriodos.Value, 1);
            decimal totalCuota = 0;
            Cuota cuota = null;

            this.Cuotas.Clear();

            for (int i = 0; i < NudCantidadPeriodos.Value; i++)
            {
                cuota = new Cuota
                {
                    Numero = i + 1,
                    Monto = (double)montoCuota
                };
                switch (this.CboTipoPeriodo.SelectedIndex)
                {
                    case 0:
                        cuota.Fecha = fechaInicio.AddDays(i + 1); break;
                    case 1:
                        cuota.Fecha = fechaInicio.AddDays((i + 1) * 7); break;
                    case 2:
                        cuota.Fecha = fechaInicio.AddDays((i + 1) * 14); break;
                    case 3:
                        cuota.Fecha = fechaInicio.AddMonths(i + 1); break;
                }
                this.Cuotas.Add(cuota);
                totalCuota += montoCuota;
            }

            if ((double)totalCuota != montoTotal)
            {
                cuota.Monto -= (double)Math.Round((double)totalCuota - montoTotal, 1);
            }
        }

        private void LLenarTabla()
        {
            this.DgvCuotas.DataSource = null;
            if (this.Cuotas.Count > 0)
            {
                this.DgvCuotas.AutoGenerateColumns = false;
                this.DgvCuotas.DataSource = this.Cuotas;
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            double total;
            this.BorrarErrores();
            if (this.ValidarDatosCalculo() == true)
            {
                ErrNotificador.SetError(BtnGenerar, "");
                total = this.CalcularTotal();
                this.TxtTotalPagar.Text = Math.Round(total, 1).ToString("0.00");
                this.GenerarCuotas(total);
                LLenarTabla();
            }
        }

        private bool ValidarDatosCalculo()
        {
            bool flag = true;
            if (this.Cliente != null)
            {
                if ((int)NudInteres.Value < Cliente.Categoria.InteresAnual)
                {
                    ErrNotificador.SetError(NudInteres, $"El interés no debe ser menor a {Cliente.Categoria.InteresAnual}%");
                    flag = false;
                }
                if (CboTipoPeriodo.SelectedIndex == -1)
                {
                    ErrNotificador.SetError(CboTipoPeriodo, "Seleccione un tipo de periodo");
                    flag = false;
                }
                return flag;
            }
            else
            {
                ErrNotificador.SetError(BtnBuscar, "Debe buscar un cliente");
                return false;
            }
        }

        private void BorrarErrores()
        {
            ErrNotificador.SetError(NudInteres, "");
            ErrNotificador.SetError(CboTipoPeriodo, "");
            ErrNotificador.SetError(BtnBuscar, "");
            ErrNotificador.SetError(TxtTotalPagar, "");
        }

        private double CalcularTotal()
        {
            double[] cantidadPeriodoAnio = { 360, 51.4286, 25.7143, 12 };
            double total;
            double tasaInteresPerido;
            double interes;

            tasaInteresPerido = (double)this.NudInteres.Value / cantidadPeriodoAnio[this.CboTipoPeriodo.SelectedIndex];
            interes = (double)this.NudMontoPrestar.Value * (tasaInteresPerido / 100) * (double)this.NudCantidadPeriodos.Value;
            total = (double)this.NudMontoPrestar.Value + interes;
            return total;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            RNPrestamo rn;
            Prestamo prestamo;
            if (this.ValidateChildren() == true)
            {
                prestamo = this.CrearEntidad();
                rn = new RNPrestamo();
                try
                {
                    rn.Registrar(prestamo);
                    MessageBox.Show("Codigo " + prestamo.Codigo, this.Text);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo registrar el préstamo", this.Text);
                }
            }
        }

        private Prestamo CrearEntidad()
        {
            Prestamo prestamo = new Prestamo()
            {
                Cliente = this.Cliente,
                Fecha = this.DtpFecha.Value,
                Monto = (double)this.NudMontoPrestar.Value,
                Interes = (double)this.NudInteres.Value,
                DejaGarantia = this.ChkDejaGarantia.Checked,
                TipoPeriodo = this.CboTipoPeriodo.Text.Substring(0, 1),
                CantidadPeriodos = (int)this.NudCantidadPeriodos.Value,
                Cuotas = this.Cuotas,
                Vigente = true
            };
            return prestamo;
        }

        private void TxtNumeroDocumento_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNumeroDocumento.Text = this.TxtNumeroDocumento.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNumeroDocumento.Text) == false)
            {
                ErrNotificador.SetError(BtnBuscar, "");
            }
            else
            {
                ErrNotificador.SetError(BtnBuscar, "Debe buscar un cliente");
                e.Cancel = true;
            }
        }

        private void NudInteres_Validating(object sender, CancelEventArgs e)
        {
            if (Cliente != null)
            {
                if ((int)NudInteres.Value >= Cliente.Categoria.InteresAnual)
                {
                    ErrNotificador.SetError(NudInteres, "");
                }
                else
                {
                    ErrNotificador.SetError(NudInteres, $"El interés no debe ser menor a {Cliente.Categoria.InteresAnual}%");
                    e.Cancel = true;
                }
            }
        }

        private void CboTipoPeriodo_Validating(object sender, CancelEventArgs e)
        {
            if (CboTipoPeriodo.SelectedIndex > -1)
            {
                ErrNotificador.SetError(CboTipoPeriodo, "");
            }
            else
            {
                ErrNotificador.SetError(CboTipoPeriodo, "Seleccione un tipo de periodo");
                e.Cancel = true;
            }
        }

        private void DgvCuotas_Validating(object sender, CancelEventArgs e)
        {
            double totalCuotas = 0;
            for (int i = 0; i < DgvCuotas.RowCount; i++)
            {
                totalCuotas += double.Parse(DgvCuotas.Rows[i].Cells["CdMonto"].Value.ToString());
            }

            if (this.Cuotas.Count > 0)
            {
                if (TxtTotalPagar.Text.Equals(totalCuotas.ToString("0.00")))
                {
                    ErrNotificador.SetError(DgvCuotas, "");
                }
                else
                {
                    ErrNotificador.SetError(DgvCuotas, "El total de cuotas no coincide con el total a pagar");
                    e.Cancel = true;
                }
            }
        }

        private void TxtTotalPagar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtTotalPagar.Text) == false)
            {
                ErrNotificador.SetError(this.TxtTotalPagar, "");
            }
            else
            {
                ErrNotificador.SetError(this.TxtTotalPagar, "Presione el botón Generar para calcular el total a pagar");
                e.Cancel = true;
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

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            CargarTiposDocumentos();
        }
    }
}
