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
    public partial class FrmBuscarPersonal : Form
    {
        private Personal actual;
        public ITransferirInformacion interfaz;
        public FrmBuscarPersonal(ITransferirInformacion interfaz)
        {
            this.interfaz = interfaz;
            InitializeComponent();
        }

        private void FrmBuscarPersonal_Load(object sender, EventArgs e)
        {
            this.BtnListar.PerformClick();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            List<Personal> encontradas = this.BuscarPeronal();
            this.DgvListado.DataSource = null;
            if (encontradas.Count > 0)
            {
                this.DgvListado.AutoGenerateColumns = false;
                this.DgvListado.DataSource = encontradas;
            }
        }

        private List<Personal> BuscarPeronal()
        {
            var encontradas = (from p in Program.Personal
                               where p.Nombres.StartsWith(this.TxtPersonal.Text)
                               select p).ToList();
            return encontradas;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                actual = (Personal)this.DgvListado.CurrentRow.DataBoundItem;
                interfaz.TransferirPersonal(actual);
                this.Close();
            } 
            else
            {
                MessageBox.Show("Debe seleccionar a un personal", this.Text);
                this.DgvListado.Focus();
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            BtnSeleccionar.PerformClick();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSeleccionar.PerformClick();
        }


        private void TxtPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnListar.PerformClick();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
