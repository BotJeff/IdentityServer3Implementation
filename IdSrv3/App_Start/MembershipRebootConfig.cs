using System;
using System.Collections.Generic;
using BrockAllen.MembershipReboot;
using IdSrv3.AppSettings;
using IdSrv3.Extensions;
using IdSrv3.MembershipReboot.CustomConfiguration;
using IdSrv3.MembershipReboot.CustomUsers;

namespace IdSrv3.App_Start
{
    public class MembershipRebootConfig
    {
        public static readonly MembershipRebootConfiguration<CustomUser> Config;

        static MembershipRebootConfig()
        {
            /**
             * MembershipReboot Configuration. Keep in App_Start folder so
             * NinjectWebCommon.cs can be properly configured.
             */

            var settings = SecuritySettings.Instance;
            settings.MultiTenant = false;

            Config = new MembershipRebootConfiguration<CustomUser>(settings)
            {
                PasswordHashingIterationCount = DateTime.Now.Year.GetIterationsFromYear(),
                RequireAccountVerification = false,
                UsernamesUniqueAcrossTenants = true,
                EmailIsUnique = true,
            };
            Config.AddEventHandler(new DebuggerEventHandler<CustomUser>());
            Config.AddCommandHandler(new CustomClaimsMapper());
            Config.AddEventHandler(GetEmailEventHandler());

            //TODO: Implement the following security features if needed.
            //Config.AddEventHandler(new AuthenticationAuditEventHandler());
            //Config.AddEventHandler(new NotifyAccountOwnerWhenTooManyFailedLoginAttempts());
            //Config.AddValidationHandler(new PasswordChanging());
            //Config.AddEventHandler(new PasswordChanged());
            //Config.AddCommandHandler(new CustomValidationMessages());
        }

        private static EmailAccountEventsHandler<CustomUser> GetEmailEventHandler()
        {
            var appinfo = new Models.AspNetApplicationInformation(
                "OSCid",
                Settings.EmailSig,
                "/identity/login",
                "/identity/changeemail",
                "/identity/cancelverification" + "?key=",
                "/identity/passwordresetwithkey" + "?key=");

            var delivery  = new SmtpMessageDelivery(true);
            var formatter = new EmailMessageFormatter<CustomUser>(appinfo);

            return new EmailAccountEventsHandler<CustomUser>(formatter, delivery);
        }
    }
}