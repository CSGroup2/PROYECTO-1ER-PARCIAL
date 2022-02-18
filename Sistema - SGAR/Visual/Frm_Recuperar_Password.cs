using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Recuperar_Password : Form {
        Adm_Login admLogin = Adm_Login.GetAdm ();
        public Frm_Recuperar_Password () {
            InitializeComponent ();
        }

        private void btnrecuperar_Click (object sender, EventArgs e) {
            //Adm_Login user = new Adm_Login ();
            string resultado = admLogin.RecuperarPassword (txtuserrequesting.Text);
            lblmensaje.Text = resultado;
        }
    }
}
