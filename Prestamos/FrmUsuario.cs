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

namespace Prestamos
{
    public partial class FrmUsuario : Form, ITransferirInformacion
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
            this.TxtClave.Text = "";
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
        }

        public void TransferirPersonal(Personal personal)
        {
            this.personal = personal;
            this.LLenarTxtPersonal();
        }

        private void LLenarTxtPersonal()
        {
            //this.TxtPersonal.Text = personal.DNI;
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            if (this.ValidateChildren() == true)
            {
                if (this.actual == null)
                {
                    usuario = new Usuario();
                    Program.Usuarios.Add(usuario);
                }
                else
                {
                    usuario = this.actual;
                }
                usuario.Personal = this.personal;
                usuario.Nombre = this.TxtNombre.Text;
                usuario.Clave = this.TxtClave.Text;
                usuario.Vigente = this.ChkVigente.Checked;
                this.HabilitarControles(false);
                this.BtnListar.PerformClick();
                this.LimpiarControles();
            }
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
            //return actual == null
            //    ? Program.Usuarios.Any(u => u.Personal.DNI.Equals(this.TxtPersonal.Text))
            //    : Program.Usuarios.Any(u =>
            //    {
            //        if (actual.Personal.DNI.Equals(u.Personal.DNI))
            //        {
            //            return false;
            //        }
            //        return u.Personal.DNI.Equals(this.TxtPersonal.Text);
            //    });
            return true;
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNombre.Text = TxtNombre.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNombre.Text) == false)
            {
                ErrNotificador.SetError(TxtNombre, "");
                if (this.EstaRegistradoElNombre() == true)
                {
                    ErrNotificador.SetError(TxtNombre, "Nombre ya registrado");
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
            return actual == null
                ? Program.Usuarios.Any(u => TxtNombre.Text.Equals(u.Nombre))
                : Program.Usuarios.Any(u =>
                {
                    if (actual.Nombre.Equals(u.Nombre))
                    {
                        return false;
                    }
                    return TxtNombre.Text.Equals(u.Nombre);
                });
        }

        private void TxtPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = this.SoloNumeros(e);
        }

        private bool SoloNumeros(KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            this.DgvListado.DataSource = null;
            if (Program.Usuarios.Count > 0)
            {
                this.DgvListado.AutoGenerateColumns = false;
                this.DgvListado.DataSource = Program.Usuarios;
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
            //this.TxtPersonal.Text = actual.Personal.DNI;
            this.TxtNombre.Text = actual.Nombre;
            this.TxtClave.Text = actual.Clave;
            this.ChkVigente.Checked = actual.Vigente;
            this.HabilitarControles(true);
        }

        private void TxtClave_Validating(object sender, CancelEventArgs e)
        {
            this.TxtClave.Text = this.TxtClave.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtClave.Text) == false &&
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
            if (string.IsNullOrEmpty(TxtConfirmar.Text) == false)
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
            if (((CheckBox)sender).Checked)
            {
                ErrNotificador.SetError(((CheckBox)sender), "");
            }
            else
            {
                ErrNotificador.SetError(((CheckBox)sender), "Cumpla esta condición");
                e.Cancel = true;
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            BtnListar.PerformClick();
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
            TxtNombre.Text = personal.NombreCompleto;
        }
    }
}
