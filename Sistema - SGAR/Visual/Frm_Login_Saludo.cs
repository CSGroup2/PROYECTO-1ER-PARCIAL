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
    public partial class Frm_Login_Saludo : Form {
        Adm_Login amdLogin = Adm_Login.GetAdm ();

        //int contador =0; 
        public Frm_Login_Saludo () {
            InitializeComponent ();
        }

        private void entrada_Tick (object sender, EventArgs e) {
            if (this.Opacity < 1) {
                this.Opacity += 0.05;
            }
            contador.Value += 1;
            if (contador.Value == 100) {
                entrada.Stop ();
                salida.Start ();
            }
        }

        private void salida_Tick (object sender, EventArgs e) {
            this.Opacity -= 0.1;
            if (this.Opacity == 0) {
                salida.Stop ();
                this.Close ();
            }
        }

        private void panel1_Paint (object sender, PaintEventArgs e) {

        }

        private void FrmSaludoLogin_Load (object sender, EventArgs e) {
            amdLogin.SaludoInicial (lblnombres); // shows username on welcome screen
            this.Opacity = 0.0;
            entrada.Start ();
        }
    }
}
