using System.IO;
using System.Net.Mail;
using IdSrv3.AppSettings;
using IdSrv3.Entities;

namespace IdSrv3.Email
{
    public abstract class EmailNotificationTemplateMethod
    {
        protected abstract UserAccount Account { get; }
        public virtual void SendEmail()
        {
            MailMessage message = GetMailMessage();
            SmtpClient client = new SmtpClient();
            client.Send(message);
        }
        public virtual MailMessage GetMailMessage()
        {
            string body = Body();
            string subject = Subject();
            MailMessage message = new MailMessage
            {
                Subject     = subject,
                Body        = body,
                IsBodyHtml  = true,
                From        = new MailAddress(Settings.FromEmail),
            };
            message.To.Add(Settings.ToEmail);
            message.To.Add(Settings.CcEmail);
            message.To.Add(Settings.BccEmail);

            return message;
        }

        protected const string TemplatePath = "IdSrv3.Email.EmailTemplates.{0}.txt";

        protected string LoadTemplate(string name)
        {
            name = string.Format(TemplatePath, name);

            var assembly = typeof(EmailNotificationTemplateMethod).Assembly;
            using(var stream = assembly.GetManifestResourceStream(name))
            {
                if(stream == null) return null;
                using(var streamReader = new StreamReader(stream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        protected abstract string Body();

        protected abstract string Subject();
    }
}