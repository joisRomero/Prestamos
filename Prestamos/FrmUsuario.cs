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
    public partial class FrmUsuario : Form
    {
        Usuario actual;
        Personal personal;
        private static FrmUsuario Instancia = null;
        private FrmUsuario()
        {
            InitializeComponent();
        }

        public static FrmUsuario LLamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmUsuario();
                }
                return Instancia;
            }
        }

        private void BtnNuevoDistrito_Click(object sender, EventArgs e)
        {
            this.actual = null;
            this.HabilitarControles(true);
            this.LimpiarControles();
        }

        private void LimpiarControles()
        {
            this.TxtPersonal.Text = "";
            this.TxtNombre.Text = "";
            this.TxtNombrePersonal.Text = "";
            this.TxtClave.Text = "";
            this.TxtConfirmar.Text = "";
            this.CboTipoUsuario.SelectedIndex = -1;
            this.ChkVigente.Checked = true;
        }

        private void HabilitarControles(bool v)
        {
            this.GbUsuario.Enabled = v;
            this.GbListado.Enabled = !v;
        }

        private void BtnCancelarDistrito_Click(object sender, EventArgs e)
        {
            this.HabilitarControles(false);
            this.BorrarErrores();
            this.LimpiarControles();
        }

        private void BorrarErrores()
        {
            ErrNotificador.SetError(this.BtnBuscar, "");
            ErrNotificador.SetError(this.TxtNombre, "");
            ErrNotificador.SetError(this.TxtClave, "");
            ErrNotificador.SetError(this.TxtConfirmar, "");
            ErrNotificador.SetError(this.ChkContineAlMenosUnaMayuscula, "");
            ErrNotificador.SetError(this.ChkContineAlMenosUnaMinuscula, "");
            ErrNotificador.SetError(this.ChkContineAlMenosUnSimbolo, "");
            ErrNotificador.SetError(this.ChkMinimo8Caracteres, "");
            ErrNotificador.SetError(BtnBuscar, "");
        }


        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            RNUsuario rn;
            if (this.ValidateChildren() == true)
            {
                usuario = this.CrearEntidad();
                rn = new RNUsuario();

                try
                {
                    if (this.actual == null)
                    {
                        rn.Registrar(usuario);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.TxtClave.Text) == true)
                        {
                            rn.ActualizarSinClave(usuario);
                        }
                        else
                        {
                            rn.ActualizarConClave(usuario);
                        }

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

        private Usuario CrearEntidad()
        {
            Usuario usuario = new Usuario()
            {
                Personal = this.personal,
                Tipo = this.CboTipoUsuario.Text.Substring(0, 1),
                Nombre = this.TxtNombre.Text,
                Clave = Utilidades.Encriptar(this.TxtClave.Text),
                Vigente = this.ChkVigente.Checked
            };
            if (this.actual != null)
            {
                usuario.Codigo = this.actual.Codigo;
            }
            return usuario;
        }

        private void TxtPersonal_Validating(object sender, CancelEventArgs e)
        {
            this.TxtPersonal.Text = TxtPersonal.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtPersonal.Text) == false)
            {
                ErrNotificador.SetError(BtnBuscar, "");
                if (this.TieneUsuarioEstePersonal() == true)
                {
                    ErrNotificador.SetError(BtnBuscar, "El personal ya tiene un usuario registrado");
                    e.Cancel = true;
                }
            }
            else
            {
                ErrNotificador.SetError(BtnBuscar, "Debe buscar a un Personal");
                e.Cancel = true;
            }
        }

        private bool TieneUsuarioEstePersonal()
        {

            bool band;

            if (actual == null)
            {
                try
                {
                    RNUsuario rn = new RNUsuario();
                    band = rn.EstaRegistradoElUsuario(personal.Codigo);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                band = false;
            }

            return band;
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNombre.Text = TxtNombre.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNombre.Text) == false)
            {
                ErrNotificador.SetError(TxtNombre, "");
                if (this.EstaRegistradoElNombre() == true)
                {
                    ErrNotificador.SetError(TxtNombre, "Nombre de usuario ya registrado");
                    e.Cancel = true;
                }
            }
            else
            {
                ErrNotificador.SetError(TxtNombre, "Debe llenar este campo");
                e.Cancel = true;
            }
        }

        private bool EstaRegistradoElNombre()
        {
            bool band;

            if (actual == null)
            {
                try
                {
                    RNUsuario rn = new RNUsuario();
                    band = rn.EstaRegistradoElNombreDeUsuario(TxtNombre.Text);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                List<string> nombres = new List<string>();
                for (int i = 0; i < DgvListado.RowCount; i++)
                {
                    nombres.Add(DgvListado.Rows[i].Cells["CdNombre"].Value.ToString());
                }
                band = nombres.Any(r =>
                {
                    if (actual.Nombre.Equals(r))
                    {
                        return false;
                    }
                    return TxtNombre.Text.Equals(r);
                });
            }

            return band;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNUsuario rn = new RNUsuario();
            List<Usuario> usuario;
            this.DgvListado.DataSource = null;

            try
            {
                usuario = rn.Listar();
                if (usuario.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = usuario;
                    this.DarFormatoFila(usuario);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener al personal", this.Text);
            }
        }

        private void DarFormatoFila(List<Usuario> usuario)
        {
            for (int i = 0; i < usuario.Count; i++)
            {
                if (usuario[i].Vigente == false)
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
                this.actual = (Usuario)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una empresa", this.Text);
                this.DgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            RNUsuario rn = new RNUsuario();

            try
            {
                this.actual = rn.Leer(this.actual.Codigo);
                if (this.actual != null)
                {
                    this.personal = actual.Personal;
                    this.TxtPersonal.Text = actual.Personal.NumeroDocumento;
                    this.TxtNombrePersonal.Text = actual.Personal.NombreCompleto;
                    this.TxtNombre.Text = actual.Nombre;
                    this.ChkVigente.Checked = actual.Vigente;
                    this.HabilitarControles(true);

                    if (actual.Tipo.Equals("L"))
                    {
                        CboTipoUsuario.SelectedIndex = 0;
                    }
                    else
                    {
                        CboTipoUsuario.SelectedIndex = 1;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener al personal solicitado", this.Text); ;
            }
        }

        private void TxtClave_Validating(object sender, CancelEventArgs e)
        {
            this.TxtClave.Text = this.TxtClave.Text.Trim();
            if (actual != null || string.IsNullOrEmpty(this.TxtClave.Text) == false &&
                ContieneAlmenosOchoDigitos() &&
                ContieneAlMenosUnaMayuscula() &&
                ContieneAlMenosUnaMinuscula() &&
                ContieneAlMenosUnSimbolo())
            {
                ErrNotificador.SetError(TxtClave, "");
            }
            else
            {
                ErrNotificador.SetError(TxtClave, "Cumpla con todas las condiciones");
                e.Cancel = true;
            }
        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {
            ChkMinimo8Caracteres.Checked = ContieneAlmenosOchoDigitos();
            ChkContineAlMenosUnaMayuscula.Checked = ContieneAlMenosUnaMayuscula();
            ChkContineAlMenosUnaMinuscula.Checked = ContieneAlMenosUnaMinuscula();
            ChkContineAlMenosUnSimbolo.Checked = ContieneAlMenosUnSimbolo();
        }

        private bool ContieneAlmenosOchoDigitos()
        {
            return TxtClave.TextLength >= 8;
        }

        private bool ContieneAlMenosUnaMayuscula()
        {
            return TxtClave.Text.Any(c => char.IsUpper(c));
        }

        private bool ContieneAlMenosUnaMinuscula()
        {
            return TxtClave.Text.Any(c => char.IsLower(c));
        }
        private bool ContieneAlMenosUnSimbolo()
        {
            return TxtClave.Text.Any(c => !char.IsDigit(c) && !char.IsLetter(c));
        }

        private void TxtConfirmar_Validating(object sender, CancelEventArgs e)
        {
            TxtConfirmar.Text = TxtConfirmar.Text.Trim();
            if (actual != null || string.IsNullOrEmpty(TxtConfirmar.Text) == false)
            {
                if (TxtConfirmar.Text.Equals(TxtConfirmar.Text))
                {
                    ErrNotificador.SetError(TxtConfirmar, "");
                }
                else
                {
                    ErrNotificador.SetError(TxtConfirmar, "Las claves no son iguales");
                    e.Cancel = true;
                }
            }
            else
            {
                ErrNotificador.SetError(TxtConfirmar, "Vuelva a ingresar la clave");
                e.Cancel = true;
            }
        }

        private void CheckBoxClave_Validating(object sender, CancelEventArgs e)
        {
            if (actual != null || ((CheckBox)sender).Checked)
            {
                ErrNotificador.SetError(((CheckBox)sender), "");
            }
            else
            {
                ErrNotificador.SetError(((CheckBox)sender), "Cumpla esta condición");
                e.Cancel = true;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarAvanzada_Click(object sender, EventArgs e)
        {
            FrmBuscarPersonal frm = new FrmBuscarPersonal();
            this.personal = frm.Buscar();

            if (this.personal != null)
            {
                this.MostrarBusqueda();
            }
            else
            {
                this.TxtPersonal.Text = "";
            }
        }

        private void MostrarBusqueda()
        {
            TxtNombrePersonal.Text = personal.NombreCompleto;
            TxtPersonal.Text = personal.NumeroDocumento;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPersonal.Text) == false)
            {
                RNPersonal rn;
                try
                {
                    rn = new RNPersonal();
                    personal = rn.Leer(TxtPersonal.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo obtener al personal", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (personal != null)
                {
                    this.MostrarBusqueda();
                }
                else
                {
                    MessageBox.Show("Personal no registrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ErrNotificador.SetError(BtnBuscar, "");
            }
            else
            {
                ErrNotificador.SetError(BtnBuscar, "Ingrese número de documento a buscar");
            }
        }

        private void BtnDarDeBaja_Click(object sender, EventArgs e)
        {
            var rpta = MessageBox.Show("¿Está seguro que deseas darle de baja?", "Salir",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1);

            if (rpta == DialogResult.Yes)
            {
                Usuario usuario = (Usuario)this.DgvListado.CurrentRow.DataBoundItem;
                if (usuario.Personal.Nombres.Equals("Administrador"))
                {
                    MessageBox.Show("No se le puede dar de baja al administrador", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        RNUsuario rn = new RNUsuario();
                        rn.DarDeBaja(usuario.Codigo);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                BtnListar.PerformClick();
            }
        }

        private void CboTipoUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (CboTipoUsuario.SelectedIndex == 0)
            {
                ErrNotificador.SetError(CboTipoUsuario, "");
            }
            else
            {
                ErrNotificador.SetError(CboTipoUsuario, "Debe hacer una selección");
                e.Cancel = true;
            }
        }
    }
}
