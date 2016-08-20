using System.Web;
using IdSrv3.Entities;

namespace IdSrv3.Email
{
    public class RegisteredUserEmailNotification : EmailNotificationTemplateMethod
    {
        private UserAccount account;
        protected override UserAccount Account { get { return account; } }

        public RegisteredUserEmailNotification(UserAccount account)
        {
            this.account = account;
        }

        protected override string Body()
        {
            string body = LoadTemplate(GetType().Name + "_Body");

            body = body.Replace("{Username}", Account.Username);
            body = body.Replace("{CreatedDate}", Account.Created.ToString());
            body = body.Replace("{Firstname}", Account.FirstName);
            body = body.Replace("{Lastname}", Account.LastName);
            body = body.Replace("{Email}", Account.Email);

            var baseUrl = HttpContext.Current.Request.Url.Scheme
                + "://" + HttpContext.Current.Request.Url.Authority;

            body = body.Replace("{IdentityManager}", baseUrl + "/admin/#/users/list");
            body += AppSettings.Settings.EmailSig;

            return body;
        }

        protected override string Subject()
        {
            return LoadTemplate(GetType().Name + "_Subject");
        }
    }
}