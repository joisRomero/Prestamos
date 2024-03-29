﻿using Entidades;
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
        Prestamo prestamo;


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
            BorrarErrores();

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
                MessageBox.Show("No se pudo cargar los tipos de documentos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No se pudo cargar las formas de pago", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCuentaBancaria()
        {
            RNCuentaBancaria rn = new RNCuentaBancaria();

            try
            {
                EntidadBancaria entidadBancaria = ((EntidadBancaria)this.CboEntidadBancaria.SelectedItem);
                List<CuentaBancaria> cuentasBancarias = rn.Listar(entidadBancaria.Nombre);
                this.CboCuentaBancaria.DataSource = null;
                if (cuentasBancarias.Count > 0)
                {
                    CboCuentaBancaria.DataSource = cuentasBancarias;
                    this.CboCuentaBancaria.DisplayMember = "Numero";
                    this.CboCuentaBancaria.ValueMember = "Codigo";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar las cuentas bancarias", this.Text);
            }
        }
        private void CargarEntidadBancaria()
        {
            RNEntidadBancaria rn = new RNEntidadBancaria();
            try
            {
                List<EntidadBancaria> entidadesBancarias = rn.Listar();
                this.CboEntidadBancaria.DataSource = null;
                if (entidadesBancarias.Count > 0)
                {
                    CboEntidadBancaria.DataSource = entidadesBancarias;
                    this.CboEntidadBancaria.DisplayMember = "Siglas";
                    this.CboEntidadBancaria.ValueMember = "Codigo";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar las entidades bancarias", this.Text);
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
                    else
                    {
                        MessageBox.Show("El cliente no registra préstamos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (ValidateChildren() && DgvPrestamos.DataSource != null)
            {
                RNPrestamo rn = new RNPrestamo(); ;
                List<Cuota> cuotas = new List<Cuota>();
                this.DgvCuotas.DataSource = null;
                prestamo = (Prestamo)this.DgvPrestamos.CurrentRow.DataBoundItem;
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
            else
            {
                MessageBox.Show("Busque los préstamos del cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BorrarErrores()
        {
            this.ErrNotificador.SetError(this.BtnBuscar, "");
            this.ErrNotificador.SetError(this.BtnBuscarPrestamo, "");
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                RNPago rn;
                RNPrestamo rnp;
                Pago pago;
                try
                {
                    rn = new RNPago();
                    rnp = new RNPrestamo();
                    pago = CrearEntidad();
                    rn.Registrar(pago);
                    rnp.ActualizarMontoPagado(prestamo, pago.Monto);

                    BtnSeleccionar.PerformClick();
                    BtnBuscarPrestamo.PerformClick();
                    MessageBox.Show("Pago realizado con éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar el pago", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Pago CrearEntidad()
        {

            List<CuotaPago> cuotasPagos = new List<CuotaPago>();
            Cuota cuota = (Cuota)this.DgvCuotas.CurrentRow.DataBoundItem;
            CuotaPago cuotapago = new CuotaPago()
            {
                Cuota = cuota,
                Monto = cuota.Monto
            };
            cuotasPagos.Add(cuotapago);
            Pago pago = new Pago()
            {
                Monto = cuota.Monto,
                NumeroOperacion = TxtNumeroOperacion.Text,
                Fecha = DtpFecha.Value,
                Vigente = true,
                FormaPago = (FormaPago)this.CboFormaPago.SelectedItem,
                Caja = Sesion.Caja,
                CuentaBancaria = (CuentaBancaria)CboCuentaBancaria.SelectedItem,
                CuotasPago = cuotasPagos
            };
            return pago;
        }

        

        private void TxtNumeroOperacion_Validating(object sender, CancelEventArgs e)
        {
            TxtNumeroOperacion.Text = TxtNumeroOperacion.Text.Trim();
            if (((FormaPago)CboFormaPago.SelectedItem).Nombre.Equals("Depósito") &&
                string.IsNullOrEmpty(TxtNumeroOperacion.Text))
            {
                this.ErrNotificador.SetError(this.TxtNumeroOperacion, "Ingrese el numero de operación");
                e.Cancel = true;
            }
            else
            {
                this.ErrNotificador.SetError(this.TxtNumeroOperacion, "");
            }
        }

        private void CboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((FormaPago)CboFormaPago.SelectedItem).Nombre.Equals("Depósito") ||
                ((FormaPago)CboFormaPago.SelectedItem).Nombre.Equals("Tarjeta"))
            {
                TxtNumeroOperacion.Enabled = true;
                CboEntidadBancaria.Enabled = true;
                CboCuentaBancaria.Enabled = true;
                CargarEntidadBancaria();
            }

            if (((FormaPago)CboFormaPago.SelectedItem).Nombre.Equals("Efectivo"))
            {
                CboEntidadBancaria.Enabled = false;
                CboCuentaBancaria.Enabled = false;
                CboCuentaBancaria.DataSource = null;
                CboEntidadBancaria.DataSource = null;
                TxtNumeroOperacion.Enabled = false;
            }
        }

        private void CboEntidadBancaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboEntidadBancaria.DataSource != null)
            {
                CargarCuentaBancaria();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
