using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdSrv3.MembershipRoot.CustomUsers;
using IdSrv3.MembershipRoot.CustomDatabases;
using IdSrv3.MembershipRoot.CustomConfiguration;
using BrockAllen.MembershipReboot;
using IdSrv3.App_Start;

namespace IdSrv3.MembershipReboot.UserService
{
    public static class UserAccountService
    {
        public static CustomUserAccountService GetCustomUserAccountService()
        {
            var customDB = new CustomDatabase(AppSettings.Settings.ConnString);
            var userRepo = new CustomUserRepository(customDB);

            return new CustomUserAccountService(MembershipRebootConfig.Config, userRepo);
        }
    }
}