﻿using System.Linq;
using IdSrv3DataMigrationTool.EntityFrameworkModels.IdSrv3Models;
using IdSrv3DataMigrationTool.Migrations.Interfaces;

namespace IdSrv3DataMigrationTool.Migrations.Classes
{
    class MigrateUsers : Migrate, IMigrateUsers
    {
        public void MapUsers()
        {
            var memberships = idSrv2Entities.Memberships.ToDictionary(x => x.UserId); 
            
            foreach (var user in idSrv2Entities.Users)
            {
                idSrv3Entities.UserAccounts.Add( new UserAccount
                {
                    //move to it's own mapper class.
                    FirstName                   = string.Empty,
                    LastName                    = string.Empty,
                    Age                         = 0,
                    ID                          = user.UserId,
                    Tenant                      = "default",
                    Username                    = user.UserName,
                    Created                     = memberships[user.UserId].CreateDate,        
                    LastUpdated                 = user.LastActivityDate,
                    IsAccountClosed             = false,
                    AccountClosed               = null,
                    IsLoginAllowed              = true,
                    LastLogin                   = user.LastActivityDate,
                    LastFailedLogin             = memberships[user.UserId].LastLockoutDate,
                    FailedLoginCount            = memberships[user.UserId].FailedPasswordAttemptCount,
                    PasswordChanged             = memberships[user.UserId].LastPasswordChangedDate,
                    RequiresPasswordReset       = memberships[user.UserId].IsLockedOut,
                    IsAccountVerified           = memberships[user.UserId].IsApproved,
                    LastFailedPasswordReset     = memberships[user.UserId].LastLockoutDate,
                    FailedPasswordResetCount    = memberships[user.UserId].FailedPasswordAnswerAttemptCount,
                    MobileCode                  = string.Empty,
                    MobileCodeSent              = null,
                    MobilePhoneNumber           = string.Empty,
                    MobilePhoneNumberChanged    = null,
                    AccountTwoFactorAuthMode    = 0,
                    CurrentTwoFactorAuthStatus  = 0,
                    VerificationKey             = string.Empty,
                    VerificationPurpose         = 0,
                    VerificationKeySent         = null,
                    VerificationStorage         = memberships[user.UserId].Email,                
                    Email                       = memberships[user.UserId].Email,
                    HashedPassword              = memberships[user.UserId].Password
                });
            }
            idSrv3Entities.SaveChanges();
        }
    }
}
