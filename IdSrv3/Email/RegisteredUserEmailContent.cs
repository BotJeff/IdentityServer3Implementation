﻿using System.Web;
using IdSrv3.Entities;

namespace IdSrv3.Email
{
    public class RegisteredUserEmailContent : IEmailContent
    {
        public UserAccount Account { get; private set; }

        public RegisteredUserEmailContent(UserAccount account)
        {
            Account = account;
        }

        public string Body()
        {
            string body = EmailHelper.LoadTemplate(GetType().Name + "_Body");
            body = PopulateBodyWithAccount(body);

            string baseUrl = GetBaseUrl();

            body = body.Replace("{IdentityManager}", baseUrl + "/admin/#/users/list");
            body += AppSettings.Settings.EmailSig;

            return body;
        }

        private string PopulateBodyWithAccount(string body)
        {
            body = body.Replace("{Username}", Account.Username);
            body = body.Replace("{CreatedDate}", Account.Created.ToString());
            body = body.Replace("{Firstname}", Account.FirstName);
            body = body.Replace("{Lastname}", Account.LastName);
            body = body.Replace("{Email}", Account.Email);
            return body;
        }

        private string GetBaseUrl()
        {
            try
            {
                return HttpContext.Current.Request.Url.Scheme
                       + "://" + HttpContext.Current.Request.Url.Authority;
            }
            catch
            {
                return AppSettings.Settings.BaseUrl;
            }
        }

        public string Subject()
        {
            return EmailHelper.LoadTemplate(GetType().Name + "_Subject");
        }
    }
}