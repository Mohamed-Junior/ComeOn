using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Mailling
    {

        private string[] adresses;
        private string subject;
        private string message;
        private string join;

        public string[]  Propadresses
        {
            get { return adresses; }
            set { adresses = value; }
        }
        public string Propsubject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Propmessage
        {
            get { return message; }
            set { message = value; }
        }
        public string Propjoin
        {
            get { return join; }
            set { join = value; }
        }
        public void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                //ajouter les destinataires
                foreach (string adress in adresses)
                {
                    mail.To.Add(adress);
                }

                mail.Subject = subject;
                mail.Body = message;
                //définir l'expéditeur
                mail.From = new MailAddress("no-replay@mon-site.fr", "Webmaster & News");


                // Attach a document.  
                mail.Attachments.Add(new Attachment(join));

                //définir les paramètres smtp pour l'envoi
                SmtpClient smtpServer = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 465,
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("montestcka@gmail.com", "mot de passe ")
                };
                //envoi du mail
                smtpServer.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

         
    }
}
}
