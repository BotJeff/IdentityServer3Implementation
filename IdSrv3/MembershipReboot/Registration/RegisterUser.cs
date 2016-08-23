using System;
using IdSrv3.Email;
using IdSrv3.Entities;
using IdSrv3.Extensions;
using IdSrv3.Models;

namespace IdSrv3.MembershipReboot.Registration
{
    public class RegisterUser : IRegisterUser
    {
        private IdentityServerEntities ISE = new IdentityServerEntities();

        public void Register(LocalRegistrationModel model)
        {
            var userAccount = new UserAccount
            {
                FirstName                   = model.First,
                LastName                    = model.Last,
                Age                         = 0,
                ID                          = Guid.NewGuid(),
                Tenant                      = "default",
                Username                    = model.Username,
                Created                     = DateTime.Now,
                LastUpdated                 = DateTime.Now,
                IsAccountClosed             = false,
                AccountClosed               = null,
                IsLoginAllowed              = true,
                LastLogin                   = null,
                LastFailedLogin             = null,
                PasswordChanged             = null,
                RequiresPasswordReset       = false,
                Email                       = model.Email,
                IsAccountVerified           = false,
                LastFailedPasswordReset     = null,
                FailedPasswordResetCount    = 0,
                MobileCode                  = null,
                MobileCodeSent              = null,
                MobilePhoneNumber           = null,
                MobilePhoneNumberChanged    = null,
                AccountTwoFactorAuthMode    = 0,
                CurrentTwoFactorAuthStatus  = 0,
                VerificationKey             = null,
                VerificationPurpose         = null,
                VerificationKeySent         = null,
                VerificationStorage         = model.Email,
                HashedPassword              = model.Password.HashPasswordByYearIterations(),
            };

            ISE.UserAccounts.Add(userAccount);
            ISE.SaveChanges();

            var emailContent = new RegisteredUserEmailContent(userAccount);
            var emailNotification = new EmailNotification(emailContent);

            emailNotification.SendMessage();
        }
    }
}