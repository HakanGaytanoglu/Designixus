using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace designixus.Models.ContactForm
{
    public class Newsletter
    {

        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("hello@designixus.com", "Bir Mesajınız Var");
            var toAddress = new MailAddress("hello@designixus.com");
            const string subject = "Designixus New Subscriber!";
            using (var smtp = new SmtpClient
            {
                Host = "mail.designixus.com",
                Port = 587,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "")
                //trololol kısmı e-posta adresinin şifresi
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }


    }
}