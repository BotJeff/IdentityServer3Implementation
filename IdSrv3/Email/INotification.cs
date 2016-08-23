using System.Net.Mail;

namespace IdSrv3.Email
{
    public interface INotification
    {
        void SendMessage();

        MailMessage GetMessage();
    }
}