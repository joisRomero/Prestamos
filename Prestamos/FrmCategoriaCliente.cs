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
    public partial class FrmCategoriaCliente : Form
    {
        private CategoriaCliente actual;
        private static FrmCategoriaCliente Instancia;
        private FrmCategoriaCliente()
        {
            InitializeComponent();
        }

        public static FrmCategoriaCliente LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmCategoriaCliente();
                }
                return Instancia;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
            actual = null;
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            NudInteres.Value = 0;
            ChkVigente.Checked = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
            LimpiarControles();
            LimpiarErrores();
        }

        private void LimpiarErrores()
        {
            ErrNotificador.SetError(TxtNombre, "");
            ErrNotificador.SetError(TxtDescripcion, "");
        }

        private void HabilitarControles(bool estado)
        {
            GbCategoria.Enabled = estado;
            GbListado.Enabled = !estado;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            RNCategoriaCliente rn;
            CategoriaCliente categoria;
            if (ValidateChildren() == true)
            {
                categoria = this.CrearEntidad();
                rn = new RNCategoriaCliente();

                try
                {
                    if (this.actual == null)
                    {
                        rn.Registrar(categoria);
                    }
                    else
                    {
                        rn.Actualizar(categoria);
                    }
                    HabilitarControles(false);
                    BtnListar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text);
                }
                LimpiarControles();
            }
        }

        private CategoriaCliente CrearEntidad()
        {
            CategoriaCliente cat = new CategoriaCliente()
            {
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                Interes = (double)NudInteres.Value,
                Vigente = ChkVigente.Checked
            };
            if (this.actual != null)
            {
                cat.Codigo = this.actual.Codigo;
            }
            return cat;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNCategoriaCliente rn = new RNCategoriaCliente();
            List<CategoriaCliente> categorias;

            DgvListado.DataSource = null;

            try
            {
                categorias = rn.Listar();
                if (categorias.Count > 0)
                {
                    DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = categorias;
                    this.DarFormatoFila(categorias);
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                MessageBox.Show("No se pudo obtener las categorías", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DarFormatoFila(List<CategoriaCliente> categorias)
        {
            for (int i = 0; i < categorias.Count; i++)
            {
                if (categorias[i].Vigente == false)
                {
                    DgvListado.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    DgvListado.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvListado.CurrentRow != null)
            {
                actual = (CategoriaCliente)DgvListado.CurrentRow.DataBoundItem;
                PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            RNCategoriaCliente rn = new RNCategoriaCliente();

            try
            {
                this.actual = rn.Leer(this.actual.Codigo);
                if (this.actual != null)
                {
                    this.TxtNombre.Text = this.actual.Nombre;
                    this.TxtDescripcion.Text = this.actual.Descripcion;
                    this.NudInteres.Value = (Decimal)this.actual.Interes;
                    this.ChkVigente.Checked = this.actual.Vigente;
                    this.HabilitarControles(true);
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar la categoría solicitada", this.Text);
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                MessageBox.Show("No se pudo obtener la categoría solicitada", this.Text);
            }
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNombre.Text = this.TxtNombre.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNombre.Text) == false)
            {
                this.ErrNotificador.SetError(this.TxtNombre, "");

                if (ValidaNombreCategoria() == true)
                {
                    this.ErrNotificador.SetError(this.TxtNombre, "Nombre ya registrado");
                    e.Cancel = true;
                }
            }
            else
            {
                this.ErrNotificador.SetError(this.TxtNombre, "Debe llenar este campo");
                e.Cancel = true;
            }
        }

        private bool ValidaNombreCategoria()
        {
            bool band;
            if (actual == null)
            {
                RNCategoriaCliente rn = new RNCategoriaCliente();
                band = rn.ExisteCategoriaCliente(TxtNombre.Text);
            } 
            else
            {
                List<string> nombres = new List<string>();
                for (int i = 0; i < DgvListado.RowCount; i++)
                {
                    nombres.Add(DgvListado.Rows[i].Cells["cdNombre"].ToString());
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

        private void BtnDarDeBaja_Click(object sender, EventArgs e)
        {
            var rpta = MessageBox.Show("¿Está seguro que deseas darle de baja?", this.Text,
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1);

            if (rpta == DialogResult.Yes)
            {
                RNCategoriaCliente rn = new RNCategoriaCliente();
                CategoriaCliente categoria = (CategoriaCliente)this.DgvListado.CurrentRow.DataBoundItem;
                rn.DarDeBaja(categoria.Codigo);
                BtnListar.PerformClick();
            }
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
