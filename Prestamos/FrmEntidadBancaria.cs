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
    public partial class FrmEntidadBancaria : Form
    {
        private EntidadBancaria actual;
        //private static FrmEntidadBancaria Instancia;
        public FrmEntidadBancaria()
        {
            InitializeComponent();
        }

        private void HabilitarControles(bool estado)
        {
            this.GbEntidadBancaria.Enabled = estado;
            this.GbListadoEntidadesB.Enabled = !estado;
            if (estado == true)
            {
                this.TxtNombre.Focus();
            }
            else
            {
                this.BtnListarEntidadesB.Focus();
            }
        }

        private void LimpiarControles()
        {
            this.TxtNombre.Text = "";
            this.TxtSiglas.Text = "";
            this.ChkVigente.Checked = true;
        }

        private void BorrarErrores()
        {
            this.ErrNotificador.SetError(this.TxtNombre, "");
            this.ErrNotificador.SetError(this.TxtSiglas, "");
        }
        private void BtnCancelarEntidadB_Click(object sender, EventArgs e)
        {
            this.HabilitarControles(false);
            this.BorrarErrores();
            this.LimpiarControles();
        }

        private void BtnNuevaEntidadB_Click(object sender, EventArgs e)
        {
            this.HabilitarControles(true);
            this.actual = null;
            this.LimpiarControles();
        }

        private void BtnCerrarEntidadB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptarEntidadB_Click(object sender, EventArgs e)
        {
            EntidadBancaria eb;
            RNEntidadBancaria rn;

            if(this.ValidateChildren() == true)
            {
                eb = this.CrearEntidad();
                rn = new RNEntidadBancaria();
                try
                {
                    if(this.actual == null)
                    {
                        rn.Registrar(eb);
                    }
                    else
                    {
                        rn.Actualizar(eb);
                    }
                    this.HabilitarControles(false);
                    this.BtnListarEntidadesB.PerformClick();
                    this.LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar la entidad bancaria", this.Text);
                }
            }
        }

        private EntidadBancaria CrearEntidad()
        {
            EntidadBancaria eb = new EntidadBancaria()
            {
                Nombre = this.TxtNombre.Text,
                Siglas = this.TxtSiglas.Text,
                Vigente = this.ChkVigente.Checked
            };
            if(this.actual != null)
            {
                eb.Codigo = this.actual.Codigo;
            }
            return eb;
        }

        private void BtnListarEntidadesB_Click(object sender, EventArgs e)
        {
            RNEntidadBancaria rn = new RNEntidadBancaria();
            List<EntidadBancaria> entidadesB;

            this.DgvListado.DataSource = null;

            try
            {
                entidadesB = rn.Listar();
                if(entidadesB.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = entidadesB;
                    this.DarFormatoFila(entidadesB);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener las entidades bancarias", this.Text);
            }
        }

        private void DarFormatoFila(List<EntidadBancaria> entidadesB)
        {
            for(int i = 0; i < entidadesB.Count; i++)
            {
                if(entidadesB[i].Vigente == false)
                {
                    DgvListado.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    DgvListado.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
        }

        private void BtnModificarEntidad_Click(object sender, EventArgs e)
        {
            if(this.DgvListado.CurrentRow != null)
            {
                this.actual = (EntidadBancaria)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una entidad bancaria", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            RNEntidadBancaria rn = new RNEntidadBancaria();

            try
            {
                this.actual = rn.Leer(this.actual.Codigo);
                if(this.actual != null)
                {
                    this.TxtNombre.Text = this.actual.Nombre;
                    this.TxtSiglas.Text = this.actual.Siglas;
                    this.ChkVigente.Checked = this.actual.Vigente;
                    this.HabilitarControles(true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener la entidad bancaria solicitada", this.Text);
            }
        }
        private void Control_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNombre.Text = this.TxtNombre.Text.Trim();
            this.TxtSiglas.Text = this.TxtSiglas.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNombre.Text) == false)
            {
                this.ErrNotificador.SetError(this.TxtNombre, "");
                if (ValidaNombreEntidadB() == true)
                {
                    this.ErrNotificador.SetError(this.TxtNombre, "Entidad bancaria ya registrada");
                    e.Cancel = true;
                }
                if(string.IsNullOrEmpty(this.TxtSiglas.Text) == false)
                {
                    this.ErrNotificador.SetError(this.TxtSiglas, "");
                }
                else
                {
                    this.ErrNotificador.SetError(this.TxtSiglas, "Debe llenar este campo");
                    e.Cancel = true;
                }
            }
            else
            {
                this.ErrNotificador.SetError(this.TxtNombre, "Debe llenar este campo");
                e.Cancel = true;
            }
        }

        private bool ValidaNombreEntidadB()
        {
            bool band;

            if(actual == null)
            {
                RNEntidadBancaria rn = new RNEntidadBancaria();
                EntidadBancaria eb = new EntidadBancaria()
                {
                    Nombre = TxtNombre.Text,
                };
                band = rn.ExisteEntidadB(eb);
            }
            else
            {
                List<string> nombres = new List<string>();
                for(int i = 0; i<DgvListado.RowCount; i++)
                {
                    nombres.Add(DgvListado.Rows[i].Cells["cdEntidadesB"].ToString());
                }
                band = nombres.Any(n =>
                {
                    if (actual.Nombre.Equals(n))
                    {
                        return false;
                    }
                    return this.TxtNombre.Text.Equals(n);
                });
            }
            return band;
        }

        private void BtnDarDeBajaEntidad_Click(object sender, EventArgs e)
        {
            var rpta = MessageBox.Show("¿Está seguro que desea darle de baja?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(rpta == DialogResult.Yes)
            {
                RNEntidadBancaria rn = new RNEntidadBancaria();
                EntidadBancaria eb = (EntidadBancaria)this.DgvListado.CurrentRow.DataBoundItem;
                rn.DarDeBaja(eb.Codigo);
                BtnListarEntidadesB.PerformClick();
            }
        }
    }
}