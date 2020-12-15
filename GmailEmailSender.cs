using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace EmailSender
{
    public class GmailEmailSender : EmailSender, IEmailSender
    {
        SmtpClient SmtpClient;
        public GmailEmailSender(GmailClientInfo ClientInfo) : base(ClientInfo)
        {
            SmtpClient = new SmtpClient(ClientInfo.SMTPServerHost, ClientInfo.SMTPServerPort);
            SmtpClient.Credentials = new NetworkCredential(ClientInfo.GmailUserEmail, ClientInfo.GmailUserPassword);
            SmtpClient.EnableSsl = true;
        }
        public EmailSendResult SendEmail(EmailMessage Message)
        {
            try
            {
                MailMessage mail = new MailMessage();

                if (Message.TO != null)
                {
                    foreach (string email in Message.TO)
                    {
                        mail.To.Add(email);
                    }
                }
                if (Message.CC != null)
                {
                    foreach (string email in Message.CC)
                    {
                        mail.CC.Add(email);
                    }
                }

                mail.From = new MailAddress(ClientInfo.GmailUserEmail);
                mail.Body = Message.Body;
                mail.Subject = Message.Subject;
                mail.IsBodyHtml = Message.IsBodyHtml;


                SmtpClient.Send(mail);
                return new EmailSendResult() { Error = null, IsMessageDelivered = true };
            }
            catch (Exception ex)
            {
                return new EmailSendResult() { Error = ex, IsMessageDelivered = false };
            }

        }
    }
}
