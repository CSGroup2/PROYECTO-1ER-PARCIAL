using FontAwesome.Sharp;
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
    public partial class Frm_Conductor_Registrar : Form {

        Btn_Comportamiento cbtn = new Btn_Comportamiento ();

        public Frm_Conductor_Registrar () {
            InitializeComponent ();
        }

        private void FrmConductorReg_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (200, 255, 255, 255);
        }

        private void textBox7_TextChanged (object sender, EventArgs e) {

        }

        private void btnlimpiar_Click (object sender, EventArgs e) {

        }

        #region Efecto boton limpiar
        private void btnlimpiar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnlimpiar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion


        #region Efecto boton cancelar
        private void btncancelar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btncancelar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        #endregion

        #region Efecto boton guardar
        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        private void btnguardar_MouseMove_1 (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }
        #endregion

    }
}
