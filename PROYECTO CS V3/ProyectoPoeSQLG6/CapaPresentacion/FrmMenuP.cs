using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun; 
namespace CapaPresentacion
{
    public partial class FrmMenuP : Form
    {
        private static FrmMenuP _Instancia;
        public static FrmMenuP GetInstancia()
        {

            if (_Instancia == null)
            {
                _Instancia = new FrmMenuP();
            }
            else
            {
                _Instancia = null;
                GetInstancia();
            }
            return _Instancia;
        }

        public FrmMenuP()
        {
            InitializeComponent();
        }
        private void btncerrarcesion_Click(object sender, EventArgs e)
        {
           
        }

        private void ocultaropciones()
        {
            this.btncliente.Enabled = false;
            this.btntrabajador.Enabled = false;
            this.btncatalogo.Enabled = false;
            this.btnventa.Enabled = false;
            //this.btnconfig.Visible = false;
        }

        private void permisos()
        {
            /*if (ClsCacheUsuario.Cargo == "Administrador")
            {
                this.ocultaropciones();
                this.btntrabajador.Enabled = true;
                this.btncatalogo.Enabled = true;
                this.btnventa.Enabled = true; 
            }
            else if (ClsCacheUsuario.Cargo == "Vendedor")
            {
                this.ocultaropciones();
                this.btncliente.Enabled = true;
                this.btncatalogo.Enabled = true;
                this.btnventa.Enabled = true;
            }
            else
            {
                this.ocultaropciones();
                this.btntrabajador.Enabled = true;
                this.btnconfig.Visible = true;
                this.lblconfig.Visible = true;
            }*/

        }


        private void regresar(Object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FrmMenuP_Load(object sender, EventArgs e)
        {
            this.cargardatos();
            this.permisos(); 
        }

        private void cargardatos()
        {
            lblapellidos.Text = ClsCacheUsuario.Apellidos;
            lblnombres.Text = ClsCacheUsuario.Nombres;
            // lblcargo.Text = ClsCacheUsuario.Cargo;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            FrmClienteCRUD frm = new FrmClienteCRUD();
            frm.Show();
            frm.FormClosed += regresar;*/
        }

        private void btntrabajador_Click(object sender, EventArgs e)
        {   /*
            this.Hide();
            FrmEmpleadoCRUD frm = new FrmEmpleadoCRUD();
            frm.Show();
            frm.FormClosed += regresar;*/
        }

        private void btncerrarcesion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar cesion?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btncatalogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*FrmModuloCatalogo frm = new FrmModuloCatalogo();
            frm.Show();
            frm.FormClosed += regresar;*/
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            FrmVenta frm = new FrmVenta();
            frm.Show();
            frm.FormClosed += regresar;
            */
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            FrmGenero frm = new FrmGenero();
            frm.Show();
            frm.FormClosed += regresar;*/
        }
    }
}
