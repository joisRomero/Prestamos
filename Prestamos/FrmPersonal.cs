using Entidades;
using ReglaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class FrmPersonal : Form
    {
        private Personal actual;
        private static FrmPersonal Instancia;

        private FrmPersonal()
        {
            InitializeComponent();
        }

        public static FrmPersonal LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmPersonal();
                }
                return Instancia;
            }
        }
        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            this.CargarDatosIniciales();
            this.LimpiarControles();
        }

        private void CargarDatosIniciales()
        {
            this.CargarTiposDocumentos();
        }

        private void CargarTiposDocumentos()
        {
            RNTipoDocumento rn = new RNTipoDocumento();
            List<TipoDocumento> tipoDocumentos;

            try
            {
                tipoDocumentos = rn.Listar();
                this.CboTipoDocumento.DataSource = null;
                if (tipoDocumentos.Count > 0)
                {
                    CboTipoDocumento.DataSource = tipoDocumentos;
                    this.CboTipoDocumento.DisplayMember = "Nombre";
                    this.CboTipoDocumento.ValueMember = "Codigo";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los tipos de documentos", this.Text);
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.actual = null;
            this.HabilitarControles(true);
            this.LimpiarControles();
        }

        private void LimpiarControles()
        {
            this.TxtNombres.Text = "";
            this.TxtApellidos.Text = "";
            this.CboTipoDocumento.SelectedIndex = -1;
            this.TxtNumDocumento.Text = "";
            this.TxtCorreo.Text = "";
            this.TxtCelular.Text = "";
            this.TxtDireccion.Text = "";
            this.ChkVigente.Checked = true;
        }

        private void HabilitarControles(bool v)
        {
            this.GbPersonal.Enabled = v;
            this.GbListado.Enabled = !v;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.HabilitarControles(false);
            this.LimpiarControles();
            this.BorrarErrores();
        }

        private void BorrarErrores()
        {
            this.ErrNotificador.SetError(this.TxtNombres, "");
            this.ErrNotificador.SetError(this.TxtApellidos, "");
            this.ErrNotificador.SetError(this.CboTipoDocumento, "");
            this.ErrNotificador.SetError(this.TxtNumDocumento, "");
            this.ErrNotificador.SetError(this.TxtCorreo, "");
            this.ErrNotificador.SetError(this.TxtCelular, "");
            this.ErrNotificador.SetError(this.TxtDireccion, "");
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Personal per;
            RNPersonal rn;

            if (this.ValidateChildren() == true)
            {
                per = this.CrearEntidad();
                rn = new RNPersonal();
                try
                {
                    if (this.actual == null)
                    {
                        rn.Registrar(per);
                    }
                    else
                    {
                        rn.Actualizar(per);
                    }
                    this.HabilitarControles(false);
                    this.BtnListar.PerformClick();
                    this.LimpiarControles();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo registrar el personal", this.Text);
                }
            }
        }

        private Personal CrearEntidad()
        {
            Personal per = new Personal()
            {
                Nombres = this.TxtNombres.Text,
                Apellidos = this.TxtApellidos.Text,
                TipoDocumento = (TipoDocumento)this.CboTipoDocumento.SelectedItem,
                NumeroDocumento = this.TxtNumDocumento.Text,
                Correo = this.TxtCorreo.Text,
                Celular = this.TxtCelular.Text,
                Direccion = this.TxtDireccion.Text,
                Vigente = this.ChkVigente.Checked,
            };
            if (this.actual != null)
            {
                per.Codigo = this.actual.Codigo;
            }
            return per;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNPersonal rn = new RNPersonal();
            List<Personal> personal;
            this.DgvListado.DataSource = null;

            try
            {
                personal = rn.Listar();
                if (personal.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = personal;
                    this.DarFormatoFila(personal);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener al personal", this.Text);
            }
        }

        private void DarFormatoFila(List<Personal> personal)
        {
            for (int i = 0; i < personal.Count; i++)
            {
                if (personal[i].Vigente == false)
                {
                    DgvListado.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    DgvListado.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.actual = (Personal)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un personal", this.Text);
                this.DgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            RNPersonal rn = new RNPersonal();

            try
            {
                this.actual = rn.Leer(this.actual.Codigo);
                if (this.actual != null)
                {
                    this.TxtNombres.Text = this.actual.Nombres;
                    this.TxtApellidos.Text = this.actual.Apellidos;
                    this.CboTipoDocumento.SelectedValue = this.actual.TipoDocumento.Codigo;
                    this.TxtNumDocumento.Text = this.actual.NumeroDocumento;
                    this.TxtCorreo.Text = this.actual.Correo;
                    this.TxtCelular.Text = this.actual.Celular;
                    this.TxtDireccion.Text = this.actual.Direccion;
                    this.ChkVigente.Checked = this.actual.Vigente;
                    this.HabilitarControles(true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener al personal solicitado", this.Text); ;
            }
        }

        private void CmbTipoDocumento_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex > -1)
            {
                ErrNotificador.SetError((ComboBox)sender, "");
            }
            else
            {
                ErrNotificador.SetError((ComboBox)sender, "Debe hacer una selección");
                e.Cancel = true;
            }
        }

        private void Controles_Validating(object sender, CancelEventArgs e)
        {
            ((Control)sender).Text = ((Control)sender).Text.Trim();
            if (string.IsNullOrEmpty(((Control)sender).Text) == false)
            {
                ErrNotificador.SetError((Control)sender, "");
                if (((Control)sender).Name.Equals("TxtCorreo"))
                {
                    ValidarCorreo(((Control)sender), e);
                }
                if (((Control)sender).Name.Equals("TxtCelular"))
                {
                    ValidarLongitudCelular(e);
                }
            }
            else
            {
                ErrNotificador.SetError((Control)sender, "Debe llenar este campo");
                e.Cancel = true;
            }
        }

        public void ValidarCorreo(Control correo, CancelEventArgs e)
        {
            if (EsUnCorreoValido(correo.Text) == true)
            {
                this.ErrNotificador.SetError(correo, "");
            }
            else
            {
                this.ErrNotificador.SetError(correo, "Debe ingresar correctamente el correo, por ejemplo: nombre123@dominio.com");
                e.Cancel = true;
            }
        }

        private bool EsUnCorreoValido(string correo)
        {
            string aux_Correo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            return Regex.IsMatch(correo, aux_Correo) &&
                Regex.Replace(correo, aux_Correo, String.Empty).Length == 0;
        }
        private void ValidarLongitudCelular(CancelEventArgs e)
        {
            if (this.TxtCelular.TextLength < 9)
            {
                ErrNotificador.SetError(this.TxtCelular, "El celular debe contener 9 números");
                e.Cancel = true;
            }
        }

        private void TxtNumeroDocumento_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNumDocumento.Text = this.TxtNumDocumento.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNumDocumento.Text) == false)
            {
                ErrNotificador.SetError(this.TxtNumDocumento, "");

                this.ValidarRepeticionNumDocumento(e);

                if (this.CboTipoDocumento.SelectedIndex == 0 && this.TxtNumDocumento.Text.Length < 8)
                {
                    ErrNotificador.SetError(this.TxtNumDocumento, "Ingrese 8 dígitos para el DNI");
                    e.Cancel = true;
                }
                if (this.CboTipoDocumento.SelectedIndex == 2 && this.TxtNumDocumento.TextLength < 9)
                {
                    ErrNotificador.SetError(this.TxtNumDocumento, "Ingrese 9 dígitos para el Carnet de extrangería");
                    e.Cancel = true;
                }
                if (this.CboTipoDocumento.SelectedIndex == 1 && this.TxtNumDocumento.TextLength < 9)
                {
                    ErrNotificador.SetError(this.TxtNumDocumento, "Ingrese 4 letras y 5 números para el Pasaporte");
                    e.Cancel = true;
                }
            }
            else
            {
                ErrNotificador.SetError(this.TxtNumDocumento, "Ingrese número de documento");
                e.Cancel = true;
            }
        }

        private void ValidarRepeticionNumDocumento(CancelEventArgs e)
        {
            if (this.ExisteNumDocumentoEnLaLista() == true)
            {
                this.ErrNotificador.SetError(this.TxtNumDocumento, "Número de documento ya registrado");
                e.Cancel = true;
            }
        }

        private bool ExisteNumDocumentoEnLaLista()
        {
            bool band;

            if (actual == null)
            {
                RNPersonal rn = new RNPersonal();
                band = rn.ExistePersonal(TxtNumDocumento.Text);
            }
            else
            {
                List<string> numDocumentos = new List<string>();
                for (int i = 0; i < DgvListado.RowCount; i++)
                {
                    numDocumentos.Add(DgvListado.Rows[i].Cells["cdNumDocumento"].Value.ToString());
                }
                band = numDocumentos.Any(r =>
                {
                    if (actual.NumeroDocumento.Equals(r))
                    {
                        return false;
                    }
                    return TxtNumDocumento.Text.Equals(r);
                });
            }

            return band;
        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.CboTipoDocumento.Text.Equals("DNI") || this.CboTipoDocumento.Text.Equals("Carnet de extranjería"))
            {
                e.Handled = SoloNumeros(e);
            }
            if (this.CboTipoDocumento.Text.Equals("Pasaporte") && this.TxtNumDocumento.TextLength < 4)
            {
                e.Handled = SoloLetras(e);
            }
            if (this.CboTipoDocumento.Text.Equals("Pasaporte") && this.TxtNumDocumento.TextLength > 3)
            {
                e.Handled = SoloNumeros(e);
            }
        }

        private void CboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.TxtNumDocumento.Text))
            {
                this.TxtNumDocumento.Text = "";
            }
            if (CboTipoDocumento.SelectedIndex == 0)
            {
                ValidarDNI();
            }
            if (CboTipoDocumento.SelectedIndex == 1)
            {
                ValidarPasaporte();
            }
            if (CboTipoDocumento.SelectedIndex == 2)
            {
                ValidarCarnetExtranjeria();
            }
        }

        private void ValidarCarnetExtranjeria()
        {
            this.TxtNumDocumento.MaxLength = 9;
        }

        private void ValidarPasaporte()
        {
            this.TxtNumDocumento.MaxLength = 9;
        }

        private void ValidarDNI()
        {
            this.TxtNumDocumento.MaxLength = 8;
        }

        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = this.SoloNumeros(e);
        }

        private bool SoloNumeros(KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        private bool SoloLetras(KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDarDeBaja_Click(object sender, EventArgs e)
        {
            var rpta = MessageBox.Show("¿Está seguro que deseas darle de baja?", "Salir",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1);

            if (rpta == DialogResult.Yes)
            {
                Personal personal = (Personal)this.DgvListado.CurrentRow.DataBoundItem;
                if (personal.Nombres.Equals("Administrador"))
                {
                    MessageBox.Show("No se le puede dar de baja al administrador", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        RNPersonal rn = new RNPersonal();
                        RNUsuario rnU = new RNUsuario();
                        rn.DarDeBaja(personal.Codigo);
                        rnU.DarDeBajaCodPersonal(personal.Codigo);
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    BtnListar.PerformClick();
                }
            }
        }
    }
}
