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
    public partial class FrmClienteEmpresa : Form
    {
        private ClienteEmpresa actual;
        private static FrmClienteEmpresa Instancia;
        private FrmClienteEmpresa()
        {
            InitializeComponent();
        }

        public static FrmClienteEmpresa LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmClienteEmpresa();
                }
                return Instancia;
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
            this.TxtRazonSocial.Text = "";
            this.TxtRUC.Text = "";
            this.TxtTelefono.Text = "";
            this.TxtCorreo.Text = "";
            this.CboDistrito.SelectedIndex = -1;
            this.CboDepartamento.SelectedIndex = -1;
            this.CboProvincia.SelectedIndex = -1;
            this.TxtDireccion.Text = "";
            this.ChkVigente.Checked = true;
        }

        private void HabilitarControles(bool v)
        {
            this.GbEmpresa.Enabled = v;
            this.GbListado.Enabled = !v;

            if (v == true)
            {
                this.CboCategoria.Focus();
            }
            else
            {
                this.TxtEmpresa.Focus();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.HabilitarControles(false);
            this.BorrarErrores();
            this.LimpiarControles();
        }

        private void FrmClienteEmpersa_Load(object sender, EventArgs e)
        {
            this.CargarDatosIniciales();
            this.LimpiarControles();
        }

        private void CargarDatosIniciales()
        {
            this.CargarCategoriasCliente();
            this.CargarDepartamentos();
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
                MessageBox.Show("No se puede cargar los departamentos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los distritos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No se pudo cargar las provincias", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No se pudo cargar las categorías", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            RNClienteEmpresa rn;
            ClienteEmpresa cli;

            if (this.ValidateChildren() == true)
            {
                cli = this.CrearEntidad();
                rn = new RNClienteEmpresa();

                try
                {
                    if (this.actual == null)
                    {
                        rn.Registrar(cli);
                    }
                    else
                    {
                        rn.Actualizar(cli);
                    }
                    this.HabilitarControles(false);
                    this.BtnListar.PerformClick();
                    this.LimpiarControles();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private ClienteEmpresa CrearEntidad()
        {
            ClienteEmpresa cli = new ClienteEmpresa()
            {
                RazonSocial = this.TxtRazonSocial.Text,
                Categoria = (CategoriaCliente)this.CboCategoria.SelectedItem,
                RUC = this.TxtRUC.Text,
                Telefono = this.TxtTelefono.Text,
                Correo = this.TxtCorreo.Text,
                Distrito = (Distrito)this.CboDistrito.SelectedItem,
                Direccion = this.TxtDireccion.Text,
                Vigente = this.ChkVigente.Checked
            };

            if (this.actual != null)
            {
                cli.Codigo = this.actual.Codigo;
            }

            return cli;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNClienteEmpresa rn = new RNClienteEmpresa();
            List<ClienteEmpresa> encontradas;
            this.DgvListado.DataSource = null;
            try
            {
                encontradas = rn.Listar(TxtEmpresa.Text);
                if (encontradas.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = encontradas;
                    DarFormatoFila(encontradas);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo traer la lista de empresas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DarFormatoFila(List<ClienteEmpresa> empresas)
        {
            for (int i = 0; i < empresas.Count; i++)
            {
                if (empresas[i].Vigente == false)
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
                this.actual = (ClienteEmpresa)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una empresa", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            RNClienteEmpresa rn = new RNClienteEmpresa();
            RNDistrito rnD = new RNDistrito();
            try
            {
                this.actual = rn.Leer(this.actual.Codigo);
                Distrito dis = rnD.Leer(actual.Distrito.Codigo);
                this.CboCategoria.SelectedValue = this.actual.Categoria.Codigo;
                this.TxtRazonSocial.Text = this.actual.RazonSocial;
                this.TxtRUC.Text = this.actual.RUC;
                this.TxtTelefono.Text = this.actual.Telefono;
                this.TxtCorreo.Text = this.actual.Correo;
                this.CboDepartamento.Text = dis.Departamento;
                this.CargarProvincias();
                this.CboProvincia.Text = dis.Provincia;
                this.CargarDistritos();
                this.CboDistrito.SelectedValue = this.actual.Distrito.Codigo;
                this.TxtDireccion.Text = this.actual.Direccion;
                this.ChkVigente.Checked = this.actual.Vigente;

                this.HabilitarControles(true);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo recuperar los datos de la empresa", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarErrores()
        {
            ErrNotificador.SetError(this.CboCategoria, "");
            ErrNotificador.SetError(this.TxtRazonSocial, "");
            ErrNotificador.SetError(this.TxtRUC, "");
            ErrNotificador.SetError(this.TxtTelefono, "");
            ErrNotificador.SetError(this.TxtCorreo, "");
            ErrNotificador.SetError(this.CboDistrito, "");
            ErrNotificador.SetError(this.TxtDireccion, "");
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
                if (((Control)sender).Name.Equals("TxtCorreo"))
                {
                    this.ValidarCorreo((Control)sender, e);
                }
                if (((Control)sender).Name.Equals("TxtRUC"))
                {
                    this.ValidarLongitudRUC(e);
                    this.ValidarRepeticionRUC(e);
                }
                if (((Control)sender).Name.Equals("TxtTelefono"))
                {
                    this.ValidarLongitudTelefono(e);
                }

            }
            else
            {
                ErrNotificador.SetError((Control)sender, "Debe llenar este campo");
                e.Cancel = true;
            }
        }

        private void ValidarLongitudTelefono(CancelEventArgs e)
        {
            if (this.TxtTelefono.TextLength < 9)
            {
                ErrNotificador.SetError(this.TxtTelefono, "El teléfono debe contener 9 números");
                e.Cancel = true;
            }
        }

        private void ValidarRepeticionRUC(CancelEventArgs e)
        {
            if (ExisteRUCEnLaLista() == true)
            {
                this.ErrNotificador.SetError(this.TxtRUC, "RUC ya registrado");
                e.Cancel = true;
            }
        }

        private bool ExisteRUCEnLaLista()
        {
            bool band;

            if (actual == null)
            {
                RNClienteEmpresa rn = new RNClienteEmpresa();
                band = rn.ExisteEmpresa(TxtRUC.Text);
            } else
            {
                List<string> rucEmpresas = new List<string>();
                for (int i = 0; i < DgvListado.RowCount; i++)
                {
                    rucEmpresas.Add(DgvListado.Rows[i].Cells["cdRUC"].Value.ToString());
                }
                band = rucEmpresas.Any(r =>
                {
                    if (actual.RUC.Equals(r))
                    {
                        return false;
                    }
                    return TxtRUC.Text.Equals(r);
                });
            }

            return band;
        }

        private void ValidarLongitudRUC(CancelEventArgs e)
        {
            if (this.TxtRUC.TextLength < 11)
            {
                ErrNotificador.SetError(this.TxtRUC, "El RUC debe contener 11 números");
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

        private void TxtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = this.SoloNumeros(e);
        }

        private bool SoloNumeros(KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboProvincia_Enter(object sender, EventArgs e)
        {
            if (this.CboDepartamento.SelectedIndex > -1)
            {
                this.CargarProvincias();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el departamento", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Debe seleccionar la provincia", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
