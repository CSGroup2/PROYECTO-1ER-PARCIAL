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
    public partial class Frm_Cliente_Consultar : Form {
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();
        public Frm_Cliente_Consultar () {
            InitializeComponent ();
        }

        private void FrmClienteConsul_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (140, 255, 255, 255);
        }

        #region Efecto boton consultar
        private void btnconsultar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnconsultar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton mostrar todos
        private void btnmostrartodos_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnmostrartodos_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton guardar
        private void btnguardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        #endregion

        #region Efecto boton imprimir
        private void btnimprimir_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnimprimir_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion
    }
}
