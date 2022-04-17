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
            this.TxtDNI.Text = "";
            this.TxtDireccion.Text = "";
            this.TxtCorreoPersonal.Text = "";
            this.TxtCorreoLaboral.Text = "";
            this.TxtCelular.Text = "";
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
            this.ErrNotificador.SetError(this.TxtDNI, "");
            this.ErrNotificador.SetError(this.TxtDireccion, "");
            this.ErrNotificador.SetError(this.TxtCorreoPersonal, "");
            this.ErrNotificador.SetError(this.TxtCorreoLaboral, "");
            this.ErrNotificador.SetError(this.TxtCelular, "");
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
                DNI = this.TxtDNI.Text,
                Direccion = this.TxtDireccion.Text,
                CorreoPersonal = this.TxtCorreoPersonal.Text,
                CorreoLaboral = this.TxtCorreoLaboral.Text,
                Celular = this.TxtCelular.Text,
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
                MessageBox.Show("Debe seleccionar una empresa", this.Text);
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
                    this.TxtDNI.Text = this.actual.DNI;
                    this.TxtDireccion.Text = this.actual.Direccion;
                    this.TxtCorreoPersonal.Text = this.actual.CorreoPersonal;
                    this.TxtCorreoLaboral.Text = this.actual.CorreoLaboral;
                    this.TxtCelular.Text = this.actual.Celular;
                    this.ChkVigente.Checked = this.actual.Vigente;
                    this.HabilitarControles(true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener al personal solicitado", this.Text); ;
            }
        }


        private void Controles_Validating(object sender, CancelEventArgs e)
        {
            ((Control)sender).Text = ((Control)sender).Text.Trim();
            if (string.IsNullOrEmpty(((Control)sender).Text) == false)
            {
                ErrNotificador.SetError((Control)sender, "");
                if (((Control)sender).Name.Equals("TxtCorreoPersonal") ||
                    ((Control)sender).Name.Equals("TxtCorreoLaboral"))
                {
                    ValidarCorreo(((Control)sender), e);
                }
                if (((Control)sender).Name.Equals("TxtDNI"))
                {
                    ValidarLongitudDNI(e);
                    ValidarRepeticionDNI(e);
                }
            }
            else
            {
                ErrNotificador.SetError((Control)sender, "Debe llenar este campo");
                e.Cancel = true;
            }
        }

        private void ValidarRepeticionDNI(CancelEventArgs e)
        {
            if (ExisteDNIEnLaLista() == true)
            {
                this.ErrNotificador.SetError(this.TxtDNI, "DNI ya registrado");
                e.Cancel = true;
            }
        }

        private void ValidarLongitudDNI(CancelEventArgs e)
        {
            if (TxtDNI.TextLength < 8)
            {
                this.ErrNotificador.SetError(this.TxtDNI, "El DNI debe contener 8 caracteres");
                e.Cancel = true;
            }
        }

        private bool ExisteDNIEnLaLista()
        {
            bool band;

            if (actual == null)
            {
                RNPersonal rn = new RNPersonal();
                band = rn.ExistePersonal(TxtDNI.Text);
            }
            else
            {
                List<string> listaDNI = new List<string>();
                for (int i = 0; i < DgvListado.RowCount; i++)
                {
                    listaDNI.Add(DgvListado.Rows[i].Cells["cdDNI"].ToString());
                }
                band = listaDNI.Any(n =>
                {
                    if (actual.DNI.Equals(n))
                    {
                        return false;
                    }
                    return this.TxtDNI.Text.Equals(n);
                });
            }
            return band;
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

        private void CelularDNI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnDarDeBaja_Click(object sender, EventArgs e)
        {
            var rpta = MessageBox.Show("¿Está seguro que deseas darle de baja?", "Salir",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1);

            if (rpta == DialogResult.Yes)
            {
                RNPersonal rn = new RNPersonal();
                Personal personal= (Personal)this.DgvListado.CurrentRow.DataBoundItem;
                rn.DarDeBaja(personal.Codigo);
                BtnListar.PerformClick();
            }
        }
    }
}
