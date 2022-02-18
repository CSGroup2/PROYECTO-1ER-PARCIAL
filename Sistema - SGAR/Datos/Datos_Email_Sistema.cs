using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos {
    class Datos_Email_Sistema : Datos_Email_Servidor {
        public Datos_Email_Sistema () {
            senderMail = "sistemasoportelosrapidos@outlook.es";
            password = "soportesystem123";
            host = "smtp.office365.com";

            port = 587;
            ssl = true;
            inicializarClienteSmtp ();
        }
    }
}
