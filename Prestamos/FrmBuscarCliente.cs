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
    public partial class FrmBuscarCliente : Form
    {
        private ICliente Encontrado;
        private List<ICliente> encontrados;

        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        public ICliente Buscar(int tipo)
        {
            this.CboTipoCliente.SelectedIndex = tipo;
            this.ShowDialog();

            return this.Encontrado;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Encontrado = null;
            this.Visible = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (this.CboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar el tipo de cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.CboTipoCliente.Focus();
            } else if (this.CboTipoCliente.SelectedIndex == 0)
            {
                this.BuscarPersonas(this.TxtNombre.Text);
            } else
            {
                this.BuscarEmpresas(this.TxtNombre.Text);
            }

            this.LlenarTabla();
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

        private void BuscarPersonas(string nombreCompleto)
        {
            RNClientePersona rn;
            this.encontrados = new List<ICliente>();

            try
            {
                rn = new RNClientePersona();
                List<ClientePersona> encontradas = rn.Listar(nombreCompleto);
                foreach (var item in encontradas)
                {
                    encontrados.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener la lista de clientes", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarEmpresas(string razonSocial)
        {
            RNClienteEmpresa rn;
            this.encontrados = new List<ICliente>();

            try
            {
                rn = new RNClienteEmpresa();
                List<ClienteEmpresa> encontradas = rn.Listar(razonSocial);
                foreach (var item in encontradas)
                {
                    encontrados.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener la lista de clientes", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.Encontrado = (ICliente)this.DgvListado.CurrentRow.DataBoundItem;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }
    }
}
