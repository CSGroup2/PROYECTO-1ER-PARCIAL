using CapaPresentacion.Comportamiento;
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
    public partial class FrmAmbulanciaReg : Form
    {
        ComportamientoBotones cbtn = new ComportamientoBotones();

        public FrmAmbulanciaReg()
        {
            InitializeComponent();
        }

        private void FrmAmbulanciaReg_Load(object sender, EventArgs e)
        {
            this.pncontenido.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        #region Efecto boton guardar
        private void btnguardar_MouseMove(object sender, MouseEventArgs e)
        {
            cbtn.activaboton(sender);
        }

        private void btnguardar_MouseLeave(object sender, EventArgs e)
        {
            cbtn.desactivaboton(sender);
        }
        #endregion

        #region Efecto boton cancelar
        private void btncancelar_MouseMove(object sender, MouseEventArgs e)
        {
            cbtn.activaboton(sender);
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            cbtn.desactivaboton(sender);
        }
        #endregion

        #region Efecto boton limpiar
        private void btnlimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            cbtn.activaboton(sender);
        }

        private void btnlimpiar_MouseLeave(object sender, EventArgs e)
        {
            cbtn.desactivaboton(sender);
        }
        #endregion
    }
}
