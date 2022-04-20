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
    public partial class FrmCuentaBancaria : Form
    {
        private CuentaBancaria actual;
        // private static FrmCuentaBancaria Instancia;
        public FrmCuentaBancaria()
        {
            InitializeComponent();
        }

        private void ChkVigente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.actual = null;
            this.HabilitarControles(true);
            this.LimpiarControles();
        }

        private void LimpiarControles()
        {
            this.CboEntidadesB.SelectedIndex = -1;
            this.TxtNumero.Text = "";
            this.TxtCCI.Text = "";
            this.ChkVigente.Checked = true;
        }

        private void HabilitarControles(bool v)
        {
            this.GbCuentaBancaria.Enabled = v;
            this.GbListado.Enabled = !v;
            if(v == true)
            {
                this.CboEntidadesB.Focus();
            }
            else
            {
                this.TxtEntidadB.Focus();
            }
        }

        private void BtnCancelarCuentaB_Click(object sender, EventArgs e)
        {
            this.HabilitarControles(false);
            this.BorrarErrores();
            this.LimpiarControles();
        }

        private void BorrarErrores()
        {
            ErrNotificador.SetError(this.CboEntidadesB, "");
            ErrNotificador.SetError(this.TxtNumero, "");
            ErrNotificador.SetError(this.TxtCCI, "");
        }

        private void FrmCuentaBancaria_Load(object sender, EventArgs e)
        {
            this.CargarDatosIniciales();
            this.LimpiarControles();
        }

        private void CargarDatosIniciales()
        {
            this.CargarEntidadesBancarias();
        }

        private void CargarEntidadesBancarias()
        {
            RNEntidadBancaria rn = new RNEntidadBancaria();
            List<EntidadBancaria> entidadesB;

            try
            {
                entidadesB = rn.ListarVigentes();
                this.CboEntidadesB.DataSource = null;
                if(entidadesB.Count > 0)
                {
                    this.CboEntidadesB.DataSource = entidadesB;
                    this.CboEntidadesB.DisplayMember = "Nombre";
                    this.CboEntidadesB.ValueMember = "Codigo";
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar las entidades bancarias", this.Text);
            }
        }

        private void BtnAceptarCuentaB_Click(object sender, EventArgs e)
        {
            RNCuentaBancaria rn;
            CuentaBancaria cb;

            if(this.ValidateChildren() == true)
            {
                cb = this.CrearEntidad();
                rn = new RNCuentaBancaria();

                try
                {
                    if(this.actual == null)
                    {
                        rn.Registrar(cb);
                    }
                    else
                    {
                        rn.Actualizar(cb);
                    }
                    this.HabilitarControles(false);
                    this.BtnListar.PerformClick();
                    this.LimpiarControles();
                }
                catch
                {
                    MessageBox.Show("Error al guardar", this.Text);
                }
            }
        }

        private CuentaBancaria CrearEntidad()
        {
            CuentaBancaria cb = new CuentaBancaria()
            {
                Numero = this.TxtNumero.Text,
                CCI = this.TxtCCI.Text,
                Vigente = this.ChkVigente.Checked,
                EntidadB = (EntidadBancaria)this.CboEntidadesB.SelectedItem
            };

            if(this.actual != null)
            {
                cb.Codigo = this.actual.Codigo;
            }

            return cb;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNCuentaBancaria rn = new RNCuentaBancaria();
            List<CuentaBancaria> encontradas;
            this.DgvListado.DataSource = null;
            try
            {
                encontradas = rn.Listar(TxtEntidadB.Text);
                if(encontradas.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = encontradas;
                    DarFormatoFila(encontradas);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo traer la lista de cuentas bancarias", this.Text);
            }
        }

        private void DarFormatoFila(List<CuentaBancaria> cuentasB)
        {
            for(int i = 0; i < cuentasB.Count; i++)
            {
                if(cuentasB[i].Vigente == false)
                {
                    DgvListado.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    DgvListado.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(DgvListado.CurrentRow != null)
            {
                this.actual = (CuentaBancaria)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta bancaria", this.Text);
                this.DgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            RNCuentaBancaria rn = new RNCuentaBancaria();
            RNEntidadBancaria rnEB = new RNEntidadBancaria();
            try
            {
                this.actual = rn.Leer(this.actual.Codigo);
                EntidadBancaria eb = rnEB.Leer(actual.EntidadB.Codigo);
                this.CboEntidadesB.SelectedValue = this.actual.EntidadB.Codigo;
                this.TxtNumero.Text = this.actual.Numero;
                this.TxtCCI.Text = this.actual.CCI;
                this.ChkVigente.Checked = this.actual.Vigente;

                this.HabilitarControles(true);
            }
            catch
            {
                MessageBox.Show("No se pudo recuperar los datos de la cuenta bancaria", this.Text);
            }
        }
        private void ComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex > -1)
            {
                ErrNotificador.SetError((Control)sender, "");
            }
            else
            {
                ErrNotificador.SetError((Control)sender, "Debe hacer una selección");
                e.Cancel = true;
            }
        }
        private void Control_Validating(object sender, CancelEventArgs e)
        {
            ((Control)sender).Text = ((Control)sender).Text.Trim();
            if (string.IsNullOrEmpty(((Control)sender).Text) == false)
            {
                ErrNotificador.SetError((Control)sender, "");
                if (((Control)sender).Name.Equals("TxtNumero"))
                {
                    this.ValidarLongitudNumero(e);
                    this.ValidarRepeticionNumero(e);
                }
                if (((Control)sender).Name.Equals("TxtCCI"))
                {
                    this.ValidarLongitudCCI(e);
                    this.ValidarRepeticionCCI(e);
                }
            }
            else
            {
                ErrNotificador.SetError((Control)sender, "Debe llenar este campo");
                e.Cancel = true;
            }
        }

        private void ValidarRepeticionCCI(CancelEventArgs e)
        {
            if (ExisteCCIEnLaLista() == true)
            {
                this.ErrNotificador.SetError(this.TxtCCI, "Nro de CCI ya registrado");
                e.Cancel = true;
            }
        }

        private bool ExisteCCIEnLaLista()
        {
            bool band;

            if (actual == null)
            {
                RNCuentaBancaria rn = new RNCuentaBancaria();
                band = rn.ExisteCCI(TxtCCI.Text);
            }
            else
            {
                List<string> NroCCIs = new List<string>();
                for (int i = 0; i < DgvListado.RowCount; i++)
                {
                    NroCCIs.Add(DgvListado.Rows[i].Cells["cdCCI"].Value.ToString());
                }
                band = NroCCIs.Any(r =>
                {
                    if (actual.CCI.Equals(r))
                    {
                        return false;
                    }
                    return TxtCCI.Text.Equals(r);
                });
            }

            return band;
        }

        private void ValidarRepeticionNumero(CancelEventArgs e)
        {
            if (ExisteNumeroEnLaLista() == true)
            {
                this.ErrNotificador.SetError(this.TxtNumero, "Nro de cuenta ya registrado");
                e.Cancel = true;
            }
        }

        private bool ExisteNumeroEnLaLista()
        {
            bool band;

            if (actual == null)
            {
                RNCuentaBancaria rn = new RNCuentaBancaria();
                band = rn.ExisteNumero(TxtNumero.Text);
            }
            else
            {
                List<string> NroCuentas = new List<string>();
                for (int i = 0; i < DgvListado.RowCount; i++)
                {
                    NroCuentas.Add(DgvListado.Rows[i].Cells["cdNumero"].Value.ToString());
                }
                band = NroCuentas.Any(r =>
                {
                    if (actual.Numero.Equals(r))
                    {
                        return false;
                    }
                    return TxtNumero.Text.Equals(r);
                });
            }

            return band;
        }

        private void ValidarLongitudCCI(CancelEventArgs e)
        {
            if (this.TxtCCI.TextLength < 20)
            {
                ErrNotificador.SetError(this.TxtCCI, "El nro de CCI debe contener 20 dígitos");
                e.Cancel = true;
            }
        }

        private void ValidarLongitudNumero(CancelEventArgs e)
        {
            if (this.TxtNumero.TextLength < 13)
            {
                ErrNotificador.SetError(this.TxtNumero, "El nro de cuenta debe contener 13 dígitos");
                e.Cancel = true;
            }
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = this.SoloNumeros(e);
        }

        private bool SoloNumeros(KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TxtCCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = this.SoloNumeros(e);
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
