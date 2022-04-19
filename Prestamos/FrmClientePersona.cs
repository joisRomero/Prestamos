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
    public partial class FrmClientePersona : Form
    {
        private ClientePersona actual;
        private static FrmClientePersona Instancia;
        private FrmClientePersona()
        {
            InitializeComponent();
        }

        public static FrmClientePersona LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmClientePersona();
                }
                return Instancia;
            }
        }

        private void FrmClientePersona_Load(object sender, EventArgs e)
        {
            this.CargarDatosIniciales();
            this.LimpiarControles();
        }

        private void CargarDatosIniciales()
        {
            this.CargarCategoriasCliente();
            this.CargarDistritos();
            this.CargarDepartamentos();
            this.CargarTiposDocumentos();
        }

        private void CargarDepartamentos()
        {
            RNDistrito rn = new RNDistrito();
            List<Distrito> distritos;

            try
            {
                distritos = rn.ListarDepartamentos();
                this.CboDepartamento.DataSource = null;
                if (distritos.Count > 0)
                {
                    this.CboDepartamento.DataSource = distritos;
                    this.CboDepartamento.DisplayMember = "Departamento";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede cargar los departamentos", this.Text);
            }
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

        private void CargarDistritos()
        {
            RNDistrito rn = new RNDistrito();
            List<Distrito> distritos;

            try
            {
                distritos = rn.ListarDistritos(this.CboProvincia.Text);
                this.CboDistrito.DataSource = null;
                if (distritos.Count > 0)
                {
                    this.CboDistrito.DataSource = distritos;
                    this.CboDistrito.DisplayMember = "DistritoNombre";
                    this.CboDistrito.ValueMember = "Codigo"; //BD
                    if (distritos.Count == 1)
                    {
                        this.CboDistrito.SelectedIndex = 0;
                    }
                    else
                    {
                        this.CboDistrito.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los distritos", this.Text);
            }
        }

        private void CargarProvincias()
        {
            RNDistrito rn = new RNDistrito();
            List<Distrito> provincias;

            try
            {
                provincias = rn.ListarProvincias(this.CboDepartamento.Text);
                this.CboProvincia.DataSource = null;
                if (provincias.Count > 0)
                {
                    this.CboProvincia.DataSource = provincias;
                    this.CboProvincia.DisplayMember = "Provincia";
                    if (provincias.Count == 1)
                    {
                        this.CboProvincia.SelectedIndex = 0;
                    }
                    else
                    {
                        this.CboProvincia.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar las provincias", this.Text);
            }
        }

        private void CargarCategoriasCliente()
        {
            RNCategoriaCliente rn = new RNCategoriaCliente();
            List<CategoriaCliente> categorias;

            try
            {
                categorias = rn.ListarVigentes();
                this.CboCategoria.DataSource = null;
                if (categorias.Count > 0)
                {
                    this.CboCategoria.DataSource = categorias;
                    this.CboCategoria.DisplayMember = "Nombre";
                    this.CboCategoria.ValueMember = "Codigo";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar las categorías", this.Text);
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
            this.CboCategoria.SelectedIndex = -1;
            this.TxtNombres.Text = "";
            this.TxtApellidos.Text = "";
            this.CboTipoDocumento.SelectedIndex = -1;
            this.TxtNumDocumento.Text = "";
            this.CboDistrito.SelectedIndex = -1;
            this.CboDepartamento.SelectedIndex = -1;
            this.CboProvincia.SelectedIndex = -1;
            this.TxtDireccion.Text = "";
            this.TxtCorreoPersonal.Text = "";
            this.TxtCelular.Text = "";
            this.ChkVigente.Checked = true;
            this.DtpFechaNacimiento.Value = DateTime.Now;
        }

        private void HabilitarControles(bool v)
        {
            GbPersona.Enabled = v;
            GbListado.Enabled = !v;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.HabilitarControles(false);
            this.LimpiarControles();
            this.BorrarErrores();
        }

        private void BorrarErrores()
        {
            ErrNotificador.SetError(this.CboCategoria, "");
            ErrNotificador.SetError(this.TxtNombres, "");
            ErrNotificador.SetError(this.TxtApellidos, "");
            ErrNotificador.SetError(this.CboTipoDocumento, "");
            ErrNotificador.SetError(this.TxtNumDocumento, "");
            ErrNotificador.SetError(this.TxtDireccion, "");
            ErrNotificador.SetError(this.TxtCorreoPersonal, "");
            ErrNotificador.SetError(this.TxtCelular, "");
            ErrNotificador.SetError(this.CboDistrito, "");
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            RNClientePersona rn;
            ClientePersona per;

            if (this.ValidateChildren() == true)
            {
                per = this.CrearEntidad();
                rn = new RNClientePersona();
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
                    this.LimpiarControles();
                    this.BtnListar.PerformClick();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar", this.Text);
                }
            }
        }

        private ClientePersona CrearEntidad()
        {
            ClientePersona per = new ClientePersona()
            {
                Categoria = (CategoriaCliente)this.CboCategoria.SelectedItem,
                Nombres = this.TxtNombres.Text,
                Apellidos = this.TxtApellidos.Text,
                NumeroDocumento = this.TxtNumDocumento.Text,
                FechaNacimiento = this.DtpFechaNacimiento.Value,
                Distrito = (Distrito)this.CboDistrito.SelectedItem,
                Direccion = this.TxtDireccion.Text,
                CorreoPersonal = this.TxtCorreoPersonal.Text,
                Celular = this.TxtCelular.Text,
                Vigente = this.ChkVigente.Checked,
                TipoDocumento = (TipoDocumento)this.CboTipoDocumento.SelectedItem
            };

            if (this.actual != null)
            {
                per.Codigo = this.actual.Codigo;
            }

            return per;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNClientePersona rn = new RNClientePersona();
            List<ClientePersona> encontradas;
            this.DgvListado.DataSource = null;
            try
            {
                encontradas = rn.Listar(TxtPersona.Text);
                if (encontradas.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = encontradas;
                    this.DarFormatoFila(encontradas);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo traer la lista de empresas", this.Text);
            }
        }

        private void DarFormatoFila(List<ClientePersona> encontradas)
        {
            for (int i = 0; i < encontradas.Count; i++)
            {
                if (encontradas[i].Vigente == false)
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
                this.actual = (ClientePersona)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar a una persona", this.Text);
                this.DgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            RNClientePersona rn = new RNClientePersona();
            RNDistrito rnD = new RNDistrito();

            try
            {
                this.actual = rn.Leer(this.actual.Codigo);
                Distrito dis = rnD.Leer(actual.Distrito.Codigo);
                this.CboCategoria.SelectedValue = this.actual.Categoria.Codigo;
                this.TxtNombres.Text = this.actual.Nombres;
                this.TxtApellidos.Text = this.actual.Apellidos;
                this.CboTipoDocumento.SelectedValue = this.actual.TipoDocumento.Codigo;
                this.TxtNumDocumento.Text = this.actual.NumeroDocumento;
                this.DtpFechaNacimiento.Value = this.actual.FechaNacimiento;
                this.CboDepartamento.Text = dis.Departamento;
                this.CargarProvincias();
                this.CboProvincia.Text = dis.Provincia;
                this.CargarDistritos();
                this.CboDistrito.SelectedValue = this.actual.Distrito.Codigo;
                this.TxtDireccion.Text = this.actual.Direccion;
                this.TxtCorreoPersonal.Text = this.actual.CorreoPersonal;
                this.TxtCelular.Text = this.actual.Celular;
                this.ChkVigente.Checked = this.actual.Vigente;
                this.HabilitarControles(true);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo recuperar los datos de la persona", this.Text);
            }
        }

        private void ComboBox_Validating(object sender, CancelEventArgs e)
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

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            ((Control)sender).Text = ((Control)sender).Text.Trim();
            if (string.IsNullOrEmpty(((Control)sender).Text) == false)
            {
                ErrNotificador.SetError((Control)sender, "");
                if (((Control)sender).Name.Equals("TxtCorreo"))
                {
                    this.ValidarCorreo((Control)sender, e);
                }

                if (((Control)sender).Name.Equals("TxtCelular"))
                {
                    this.ValidarLongitudCelular(e);
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

        private void TxtNumDocumento_Validating(object sender, CancelEventArgs e)
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
                this.ErrNotificador.SetError(this.TxtNumDocumento, "Numero de documento ya registrado");
                e.Cancel = true;
            }
        }

        private bool ExisteNumDocumentoEnLaLista()
        {
            bool band;

            if (actual == null)
            {
                RNClientePersona rn = new RNClientePersona();
                band = rn.ExistePersona(TxtNumDocumento.Text);
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

        private void TxtNumDocumento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtPersona_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnListar.PerformClick();
            }
        }

        private void CboProvincia_Enter(object sender, EventArgs e)
        {
            if (this.CboDepartamento.SelectedIndex > -1)
            {
                this.CargarProvincias();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el departamento");
            }
        }

        private void CboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CboDistrito.DataSource = null;
        }

        private void CboDistrito_Enter(object sender, EventArgs e)
        {
            if (this.CboProvincia.SelectedIndex > -1)
            {
                this.CargarDistritos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la provincia");
            }
        }
    }
}
