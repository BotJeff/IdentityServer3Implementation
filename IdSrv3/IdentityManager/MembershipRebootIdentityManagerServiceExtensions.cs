using IdentityManager.Configuration;
using IdentityManager;
using IdSrv3.MembershipReboot.CustomDatabases;
using IdSrv3.MembershipReboot.CustomGroups;
using IdSrv3.MembershipReboot.CustomUsers;

using BrockAllen.MembershipReboot;
using IdSrv3.App_Start;

namespace IdSrv3.IdentityManager
{
    public static class MembershipRebootIdentityManagerServiceExtensions
    {
        public static void Configure(this IdentityManagerServiceFactory factory, string connectionString)
        {
            factory.IdentityManagerService = new Registration<IIdentityManagerService, CustomIdentityManagerService>();

            factory.Register(new Registration<CustomUserAccountService>());
            factory.Register(new Registration<CustomGroupService>());
            factory.Register(new Registration<CustomUserRepository>());
            factory.Register(new Registration<CustomGroupRepository>());
            factory.Register(new Registration<CustomDatabase>(resolver=> new CustomDatabase(connectionString)));
            factory.Register(new Registration<MembershipRebootConfiguration<CustomUser>>(MembershipRebootConfig.Config));
        }
    }
}