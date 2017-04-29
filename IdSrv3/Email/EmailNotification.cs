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
            MailMessage message = CreateMessage();
            SmtpClient client = new SmtpClient();
            client.Send(message);
        }

        public virtual MailMessage CreateMessage()
        {
            string body = content.Body();
            string subject = content.Subject();
            MailMessage message = InitMailMessage(body, subject);
            AddEmailFields(message);

            return message;
        }

        private static MailMessage InitMailMessage(string body, string subject)
        {
            return new MailMessage
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
                From = new MailAddress(Settings.FromEmail),
            };
        }

        private static void AddEmailFields(MailMessage message)
        {
            message.To.Add(Settings.ToEmail);
            if(Settings.CcEmail != null) message.CC.Add(Settings.CcEmail);
            if(Settings.BccEmail != null) message.Bcc.Add(Settings.BccEmail);
        }
    }
}