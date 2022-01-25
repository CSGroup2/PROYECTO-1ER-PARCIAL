using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.ServiciosCorreo
{
    class SistemaSoporteEmail : ServidorMaestroCorreo
    {
        public SistemaSoporteEmail()
        {
            senderMail = "sistemasoportelosrapidos@outlook.es";
            password = "soportesystem123";
            host = "smtp.office365.com";
            
            port = 587;
            ssl = true;
            inicializarClienteSmtp();
        }
    }
}
