using IdSrv3.App_Start;
using IdSrv3.AppSettings;
using IdSrv3.MembershipReboot.CustomDatabases;
using IdSrv3.MembershipReboot.CustomUsers;

namespace IdSrv3.MembershipReboot.UserService
{
    public static class UserAccountService
    {
        public static CustomUserAccountService GetCustomUserAccountService()
        {
            var customDB = new CustomDatabase(Settings.ConnString);
            var userRepo = new CustomUserRepository(customDB);

            return new CustomUserAccountService(MembershipRebootConfig.Config, userRepo);
        }
    }
}