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
    public partial class Frm_Cliente_Registrar : Form {
        Adm_Login admLogin = Adm_Login.GetAdm ();

        Btn_Comportamiento cbtn = new Btn_Comportamiento ();

        public Frm_Cliente_Registrar () {
            InitializeComponent ();
        }

        private void FrmClienteReg_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (200, 255, 255, 255);

        }

        #region Efectos boton Guardar
        private void btnguardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efectos boton Cancelar
        private void btncancelar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btncancelar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efectos boton limpiar
        private void btnlimpiar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnlimpiar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion
    }
}
