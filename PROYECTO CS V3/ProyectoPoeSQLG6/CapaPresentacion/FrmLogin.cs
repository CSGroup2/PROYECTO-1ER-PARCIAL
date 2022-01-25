using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControl;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Libreria", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Libreria", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnacceder_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text!= string.Empty || txtcontra.Text != string.Empty)
            {
                Adm_Login login = new Adm_Login();
                bool respuesta = login.loginuser(txtusuario.Text, txtcontra.Text);
                if (respuesta)
                {
                    this.Hide();
                    FrmSaludoLogin saludo = new FrmSaludoLogin();
                    saludo.ShowDialog();
                    FrmMenuPr frmmenu = new FrmMenuPr();
                    frmmenu.Show();
                    frmmenu.FormClosed += cerrarcesion;
                    //this.Hide();
                }
                else
                {
                    MensajeError("Usuario o contraseñas incorrectas \n Intentelo otra vez"); 
                }
            }
            else
            {
                MensajeOk("Ingrese por favor los datos necesarios"); 
            }
        }

        private void cerrarcesion(Object sender, FormClosedEventArgs e)
        {
            txtusuario.Clear();
            txtcontra.Clear();
            this.Show();
            txtusuario.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lklblrecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperarcontraseña = new FrmRecuperarContraseña();
            recuperarcontraseña.ShowDialog();
        }
    }
}
