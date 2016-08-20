using BrockAllen.MembershipReboot;

namespace IdSrv3.MembershipReboot.CustomUsers
{
    public class CustomUserAccountService : UserAccountService<CustomUser>
    {
        public CustomUserAccountService(MembershipRebootConfiguration<CustomUser> config, CustomUserRepository repo)
            : base(config, repo)
        {
        }
    }
}