using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControl
{
    public class Adm_Login
    {

        ClsBDLogin BDLogin = new ClsBDLogin();

        public bool loginuser(String usuario, String contra)
        {
            return BDLogin.login(usuario, contra);
        }

        public string recuperarcontraseña(string userrequesting)
        {
            return BDLogin.recuperarcontraseña(userrequesting);
        }
    }
}
