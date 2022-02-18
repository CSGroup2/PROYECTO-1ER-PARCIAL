using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control {
    public class Adm_Login {

        /*
            Aplicar el patron de diseño Singleton:
            1. Crear 1 atributo estático y privado de la misma clase.
            2. Cambiar el constructor de public a private.
            3.1. Crear un getter del atributo estático del tipo de la clase.
            3.2.Verificar si atributo es null, si es así, crearlo.
        */

        private static Adm_Login adm = null;    // 1.
        List<Usuario_Cache> lista = null;
        Validacion v = null;
        Usuario_Cache usuarioCache = null;

        public List<Usuario_Cache> Lista { get => lista; set => lista = value; }
        public Usuario_Cache UsuarioCache { get => usuarioCache; set => usuarioCache = value; }

        // Constructor: Adm_Login
        private Adm_Login () {                  // 2.
            lista = new List<Usuario_Cache> ();
            usuarioCache = new Usuario_Cache ();
            v = new Validacion ();
        }

        // Getter: GetAdm
        public static Adm_Login GetAdm () {     // 3.1.
            if (adm == null) {                  //3.2
                adm = new Adm_Login ();
            }
            return adm;
        }



        /*--------------------------Frm_Login-----------------------------------------*/

        

        Datos_Login datosLogin = new Datos_Login ();

        public bool LoginUser (String usuario, String contra) {
            usuarioCache = datosLogin.LoginUser (usuario, contra);

            if (usuarioCache is null) {
                return false;
            }else {
                return true;

            }
        }

        public string RecuperarPassword (string userrequesting) {
            return datosLogin.RecuperarPassword (userrequesting);
        }

        /*--------------------------Frm_Login_Saludo-----------------------------------------*/
        public void SaludoInicial (Label lblnombres) {
            lblnombres.Text = usuarioCache.Nombres + " " + usuarioCache.Apellidos;
        }

        public string TipoUsuario () {
            return usuarioCache.Tipo;
        }

        /*--------------------------Frm_Menu-----------------------------------------*/

        public void CargarDatos (Label lblapellido, Label lblnombres, Label lbltipo) {
            lblapellido.Text = usuarioCache.Apellidos;
            lblnombres.Text = usuarioCache.Nombres;
            lbltipo.Text = usuarioCache.Tipo;
        }

        public int IdUsuario () {
            return usuarioCache.Id_tipo;
        }
    }
}
