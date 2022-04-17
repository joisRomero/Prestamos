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
    public partial class FrmConfiguracion : Form
    {
        Configuracion configuracion;
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        public Configuracion ObtenerConfiguracion(Configuracion cfg)
        {
            if (cfg.EsVisibleMenuPreterminado == true)
            {
                this.CboBarraMenu.SelectedIndex = 0;
            }
            else
            {
                this.CboBarraMenu.SelectedIndex = 1;
            }

            this.ChkAgregarBarraHerramienta.Checked = cfg.AgregarBarraHerramientas;

            this.ShowDialog();
            return configuracion;
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            configuracion = new Configuracion();
            if (CboBarraMenu.SelectedIndex == 0)
            {
                this.CambiarVisibilidadMenu(true);
                configuracion.AgregarBarraHerramientas = this.ChkAgregarBarraHerramienta.Checked;
            }
            else
            {
                this.CambiarVisibilidadMenu(false);
                configuracion.AgregarBarraHerramientas = false;
            }

            this.Visible = false;
        }

        private void CambiarVisibilidadMenu(bool valor)
        {
            configuracion.EsVisibleMenuPreterminado = valor;
            configuracion.EsVisibleMnuRibbon = !valor;
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.configuracion = null;
            this.Visible = false;
        }

        private void CboBarraMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChkAgregarBarraHerramienta.Enabled = true;
            if (CboBarraMenu.SelectedIndex == 1)
            {
                this.ChkAgregarBarraHerramienta.Enabled = false;
            }
        }
    }
}
