using CapaControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRecuperarContraseña : Form
    {
        public FrmRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnrecuperar_Click(object sender, EventArgs e)
        {
            Adm_Login user = new Adm_Login();
            string resultado = user.recuperarcontraseña(txtuserrequesting.Text);
            lblmensaje.Text = resultado;
        }
    }
}
