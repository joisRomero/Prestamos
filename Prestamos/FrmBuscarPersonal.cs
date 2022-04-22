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
    public partial class FrmBuscarPersonal : Form
    {
        private Personal Encontrado;
        private List<Personal> encontrados;
        public FrmBuscarPersonal()
        {
            InitializeComponent();
        }

        public Personal Buscar()
        {
            this.ShowDialog();
            return this.Encontrado;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                Encontrado = (Personal)this.DgvListado.CurrentRow.DataBoundItem;
                this.Close();
            } 
            else
            {
                MessageBox.Show("Debe seleccionar a un personal", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSeleccionar.PerformClick();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Encontrado = null;
            this.Visible = false;
        }

        private void LlenarTabla()
        {
            this.DgvListado.DataSource = null;
            if (this.encontrados != null && this.encontrados.Count > 0)
            {
                this.DgvListado.AutoGenerateColumns = false;
                this.DgvListado.DataSource = this.encontrados;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RNPersonal rn;
            try
            {
                rn = new RNPersonal();
                encontrados = rn.ListarExistentes();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener la lista del personal", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.LlenarTabla();
        }
    }
}
