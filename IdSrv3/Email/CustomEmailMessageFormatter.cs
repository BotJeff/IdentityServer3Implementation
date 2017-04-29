using System;
using System.IO;
using BrockAllen.MembershipReboot;
using IdSrv3.MembershipReboot.CustomUsers;

namespace IdSrv3.Email
{
    public class CustomEmailMessageFormatter : EmailMessageFormatter<CustomUser>
    {
        public CustomEmailMessageFormatter(ApplicationInformation appInfo) : base(appInfo)
        {
        }

        protected override string LoadSubjectTemplate(UserAccountEvent<CustomUser> evt)
        {
            return EmailHelper.LoadTemplate(CleanGenericName(evt.GetType()) + "_Subject");
        }

        protected override string LoadBodyTemplate(UserAccountEvent<CustomUser> evt)
        {
            return EmailHelper.LoadTemplate(CleanGenericName(evt.GetType()) + "_Body");
        }

        private string CleanGenericName(Type type)
        {
            var name = type.Name;
            var idx = name.IndexOf('`');
            if(idx > 0)
            {
                name = name.Substring(0, idx);
            }
            return name;
        }
    }
}