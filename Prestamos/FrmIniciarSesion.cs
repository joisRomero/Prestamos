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
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
            if (string.IsNullOrEmpty(((TextBox)sender).Text) == false)
            {
                ErrNotificador.SetError((TextBox)sender, "");
            }
            else
            {
                ErrNotificador.SetError((TextBox)sender, "Llene este campo");
                e.Cancel = true;
            }
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            bool band;
            if (ValidateChildren() == true)
            {
                try
                {
                    RNUsuario rn = new RNUsuario();
                    band = rn.Login(TxtNombreDeUsuario.Text, Utilidades.Encriptar(TxtClave.Text));
                    if (band == true)
                    {
                        IniciarPrincipal();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Clave incorrectas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void IniciarPrincipal()
        {
            try
            {
                RNUsuario rn = new RNUsuario();
                Sesion.Usuario = rn.Leer(TxtNombreDeUsuario.Text);
                FrmPrincipal frm = new FrmPrincipal();
                this.Hide();
                frm.Show();
                frm.FormClosed += (s, args) => this.Show();
                this.TxtNombreDeUsuario.Text = "";
                this.TxtClave.Text = "";
            
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}