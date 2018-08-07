using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MailUtil
    {
        public void SendMail(string sender, string password, string receiver, string smtp, int port,
            bool ssl, Order order)
        {
            if (String.IsNullOrWhiteSpace(sender))
                throw new ArgumentNullException("sender", "MailUtil.SendMail: sender cannot be empty or null.");

            if (String.IsNullOrWhiteSpace(receiver))
                throw new ArgumentNullException("receiver", "MailUtil.SendMail: receiver cannot be empty or null.");

            if (String.IsNullOrWhiteSpace(smtp))
                throw new ArgumentNullException("smtp", "MailUtil.SendMail: smtp cannot be empty or null.");

            if (order == null)
                throw new ArgumentNullException("order", "MailUtil.SendMail: order cannot be null.");

            try
            {
                SmtpClient client = new SmtpClient(smtp, port);
                client.EnableSsl = ssl;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(sender, password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                
                using (MailMessage mail = new MailMessage(sender, receiver))
                {
                    mail.Subject = "Restaurant order";
                    mail.Body = order.ToString();

                    client.Send(mail);
                }
            }
            catch (Exception exc)
            {
                throw new Exception(String.Format("MailUtil.SendMail: {0}", exc.Message), exc);
            }
        }
    }
}
