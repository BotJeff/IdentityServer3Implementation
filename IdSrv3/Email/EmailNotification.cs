using System.Net.Mail;
using IdSrv3.AppSettings;

namespace IdSrv3.Email
{
    public class EmailNotification : INotification
    {
        private IEmailContent content;

        public EmailNotification(IEmailContent content)
        {
            this.content = content;
        }

        public virtual void SendMessage()
        {
            MailMessage message = GetMessage();
            SmtpClient client = new SmtpClient();
            client.Send(message);
        }

        public virtual MailMessage GetMessage()
        {
            string body = content.Body();
            string subject = content.Subject();
            MailMessage message = new MailMessage
            {
                Subject     = subject,
                Body        = body,
                IsBodyHtml  = true,
                From        = new MailAddress(Settings.FromEmail),
            };
            message.To.Add(Settings.ToEmail);
            if(Settings.CcEmail != null) message.CC.Add(Settings.CcEmail);
            if(Settings.BccEmail != null) message.Bcc.Add(Settings.BccEmail);

            return message;
        }
    }
}