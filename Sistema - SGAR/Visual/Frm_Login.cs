using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Visual {
    public partial class Frm_Login : Form {
        Adm_Login admLogin = Adm_Login.GetAdm ();

        public Frm_Login () {
            InitializeComponent ();
        }

        private void MensajeError (string mensaje) {
            MessageBox.Show (mensaje, "Sistema de Libreria", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk (string mensaje) {
            MessageBox.Show (mensaje, "Sistema de Libreria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnacceder_Click (object sender, EventArgs e) {
            if (txtusuario.Text != string.Empty || txtcontra.Text != string.Empty) {
                //Adm_Login login = new Adm_Login ();
                bool respuesta = admLogin.LoginUser (txtusuario.Text, txtcontra.Text);
                if (respuesta) {
                    this.Hide ();
                    Frm_Login_Saludo saludo = new Frm_Login_Saludo ();
                    saludo.ShowDialog ();
                    Frm_Menu frmmenu = new Frm_Menu ();
                    frmmenu.Show ();
                    frmmenu.FormClosed += CerrarSesion;
                    //this.Hide();
                } else {
                    MensajeError ("Usuario o contraseñas incorrectas \n Intentelo otra vez");
                }
            } else {
                MensajeOk ("Ingrese por favor los datos necesarios");
            }
        }

        private void CerrarSesion (Object sender, FormClosedEventArgs e) {
            txtusuario.Clear ();
            txtcontra.Clear ();
            this.Show ();
            txtusuario.Focus ();
        }

        private void FrmLogin_Load (object sender, EventArgs e) {

        }

        private void lklblrecuperar_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e) {
            Frm_Recuperar_Password frmRecuperarPassword = new Frm_Recuperar_Password ();
            frmRecuperarPassword.ShowDialog ();
        }
    }
}
