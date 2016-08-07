using BrockAllen.MembershipReboot;
using System;
using IdSrv3.MembershipRoot.CustomUsers;
using IdSrv3.Extensions;
using IdentityServer3.Core;
using Ninject;
using IdSrv3.MembershipRoot.CustomConfiguration;
using IdSrv3.AppSettings;
using BrockAllen.MembershipReboot.WebHost;

namespace IdSrv3.App_Start
{
    public class MembershipRebootConfig
    {
        public static readonly MembershipRebootConfiguration<CustomUser> Config;
        
        static MembershipRebootConfig()
        {
            var settings = SecuritySettings.Instance;
            settings.MultiTenant = false;

            Config = new MembershipRebootConfiguration<CustomUser>(settings);
            Config.PasswordHashingIterationCount = DateTime.Now.Year.GetIterationsFromYear();
            Config.RequireAccountVerification = false;
            Config.UsernamesUniqueAcrossTenants = true;
            Config.EmailIsUnique = true;
            Config.AddEventHandler(new DebuggerEventHandler<CustomUser>());
            Config.AddCommandHandler(new CustomClaimsMapper());
            Config.AddEventHandler(GetEmailEventHandler());


            //TODO: Implement the following security features.
            //Config.AddEventHandler(new AuthenticationAuditEventHandler());
            //Config.AddEventHandler(new NotifyAccountOwnerWhenTooManyFailedLoginAttempts());

            //Config.AddValidationHandler(new PasswordChanging());
            //Config.AddEventHandler(new PasswordChanged());
            //Config.AddCommandHandler(new CustomValidationMessages());
        }

        private static EmailAccountEventsHandler<CustomUser> GetEmailEventHandler()
        {
            /*
             * HttpContext.Current.Request.Url
             * 
             * DOES NOT EXIST DURING APP START.
             * Set URL from site config.
             * 
             * AppDomain.CurrentDomain.BaseDirectory??
             */
            var appinfo = new ApplicationInformation
            {
                ApplicationName         = "Identity Server",
                CancelVerificationUrl   = null,
                ConfirmChangeEmailUrl   = null,
                ConfirmPasswordResetUrl = Settings.BaseUrl + "/identity/passwordresetwithkey" + "?key=",
                EmailSignature          = "<br/><br/><strong>Email Signature</strong>",
                LoginUrl                = null
            };

            var delivery  = new SmtpMessageDelivery(true);
            var formatter = new EmailMessageFormatter<CustomUser>(appinfo);

            return new EmailAccountEventsHandler<CustomUser>(formatter, delivery);
        }
    }
}