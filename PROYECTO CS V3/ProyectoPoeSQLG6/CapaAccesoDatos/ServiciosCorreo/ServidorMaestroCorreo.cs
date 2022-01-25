using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace CapaAccesoDatos.ServiciosCorreo
{
    public abstract class ServidorMaestroCorreo
    {
        private SmtpClient smtpClient;

        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void inicializarClienteSmtp()
        {
            smtpClient = new SmtpClient();
            //smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
        }
        /*se definio el receptor como una lista ya que pueden haber casos en los que requiera enviar mas de un 
         correo de forma simultanea*/
        public void enviarcorreo(string asunto, string cuerpo, List<string> receptor)
        {
            var mailMassage = new MailMessage(); 
            try{
                mailMassage.From = new MailAddress(senderMail);
                foreach(string correo in receptor)
                {
                    mailMassage.To.Add(correo);
                }
                mailMassage.Subject = asunto;
                mailMassage.Body = cuerpo;
                mailMassage.Priority = MailPriority.Normal;

                smtpClient.Send(mailMassage);
            }
            catch (Exception ex) {
                //MessageBox.Show("ocurrio un error "+ ex.Message);
                MessageBox.Show("ocurrio un error " + ex.ToString());
            }
            finally {
                mailMassage.Dispose();
                smtpClient.Dispose();
            }
        }

    }
}
