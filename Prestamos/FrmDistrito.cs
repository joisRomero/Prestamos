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
    public partial class FrmDistrito : Form
    {
        private Distrito actual;
        private static FrmDistrito Instancia;
        private FrmDistrito()
        {
            InitializeComponent();
        }

        public static FrmDistrito LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmDistrito();
                }
                return Instancia;
            }
        }
        private void HabilitarControles(bool estado)
        {
            this.GbDistrito.Enabled = estado;
            this.GbListadoDistritos.Enabled = !estado;
            if (estado == true)
            {
                this.TxtNombre.Focus();
            }
            else
            {
                this.BtnListarDistritos.Focus();
            }
        }
        private void LimpiarControles()
        {
            this.TxtNombre.Text = "";
            this.TxtProvincia.Text = "";
            this.TxtDepartamento.Text = "";
            this.ChkVigente.Checked = true;
        }

        private void BtnCancelarDistrito_Click(object sender, EventArgs e)
        {
            this.HabilitarControles(false);
            this.BorrarErrores();
            this.LimpiarControles();
        }
        private void BorrarErrores()
        {
            this.ErrNotificador.SetError(this.TxtNombre, "");
        }
        private void BtnNuevoDistrito_Click(object sender, EventArgs e)
        {
            this.HabilitarControles(true);
            this.actual = null;
            this.LimpiarControles();
        }

        private void BtnAceptarDistrito_Click(object sender, EventArgs e)
        {
            Distrito dis;
            RNDistrito rn;

            if (this.ValidateChildren() == true)
            {
                dis = this.CrearEntidad();
                rn = new RNDistrito();
                try
                {
                    if (this.actual == null)
                    {
                        rn.Registrar(dis);
                    }
                    else
                    {
                        rn.Actualizar(dis);
                    }
                    this.HabilitarControles(false);
                    this.BtnListarDistritos.PerformClick();
                    this.LimpiarControles();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar el distrito", this.Text);
                }
            }
        }

        private Distrito CrearEntidad()
        {
            Distrito dis = new Distrito()
            {
                DistritoNombre = this.TxtNombre.Text,
                Provincia = this.TxtProvincia.Text,
                Departamento = this.TxtDepartamento.Text,
                Vigente = this.ChkVigente.Checked
            };
            if (this.actual != null)
            {
                dis.Codigo = this.actual.Codigo;
            }
            return dis;
        }

        private void BtnListarDistritos_Click(object sender, EventArgs e)
        {
            RNDistrito rn = new RNDistrito();
            List<Distrito> distritos;

            this.DgvListado.DataSource = null;

            try
            {
                distritos = rn.Listar();
                if (distritos.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = distritos;
                    this.DarFormatoFila(distritos);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener los distritos", this.Text);
            }
        }

        private void DarFormatoFila(List<Distrito> distritos)
        {
            for (int i = 0; i < distritos.Count; i++)
            {
                if (distritos[i].Vigente == false)
                {
                    DgvListado.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    DgvListado.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
        }

        private void BtnModificarDistrito_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.actual = (Distrito)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un distrito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DgvListado.Focus();
            }
        }
        private void PresentarDatos()
        {
            RNDistrito rn = new RNDistrito();

            try
            {
                this.actual = rn.Leer(this.actual.Codigo);
                if (this.actual != null)
                {
                    this.TxtNombre.Text = this.actual.DistritoNombre;
                    this.TxtProvincia.Text = this.actual.Provincia;
                    this.TxtDepartamento.Text = this.actual.Departamento;
                    this.ChkVigente.Checked = this.actual.Vigente;
                    this.HabilitarControles(true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el distrito solicitado", this.Text); ;
            }
        }

        private void BtnCerrarDistrito_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNombre.Text = this.TxtNombre.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNombre.Text) == false)
            {
                this.ErrNotificador.SetError(this.TxtNombre, "");

                if (ValidaNombreDistrito() == true)
                {
                    this.ErrNotificador.SetError(this.TxtNombre, "Distrito ya registrado");
                    e.Cancel = true;
                }
            }
            else
            {
                this.ErrNotificador.SetError(this.TxtNombre, "Debe llenar este campo");
                e.Cancel = true;
            }
        }

        private bool ValidaNombreDistrito()
        {
            bool band;

            if (actual == null)
            {
                RNDistrito rn = new RNDistrito();
                Distrito dis = new Distrito()
                {
                    DistritoNombre = TxtNombre.Text,
                    Departamento = TxtDepartamento.Text,
                    Provincia = TxtProvincia.Text
                };
                band = rn.ExisteDistrito(dis);
            }
            else
            {
                List<string> nombres = new List<string>();
                for (int i = 0; i < DgvListado.RowCount; i++)
                {
                    nombres.Add(DgvListado.Rows[i].Cells["cdDistrito"].ToString());
                }

                band = nombres.Any(n =>
                {
                    if (actual.DistritoNombre.Equals(n))
                    {
                        return false;
                    }
                    return this.TxtNombre.Text.Equals(n);
                });
            }
            return band;
        }

        private void BtnDarDeBajaDistrito_Click(object sender, EventArgs e)
        {
            var rpta = MessageBox.Show("¿Está seguro que desea darle de baja?", this.Text,
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1);

            if (rpta == DialogResult.Yes)
            {
                RNDistrito rn = new RNDistrito();
                Distrito distrito = (Distrito)this.DgvListado.CurrentRow.DataBoundItem;
                rn.DarDeBaja(distrito.Codigo);
                BtnListarDistritos.PerformClick();
            }
        }

        private void GbListadoDistritos_Enter(object sender, EventArgs e)
        {

        }
    }
}
