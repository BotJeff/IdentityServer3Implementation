using IdSrv3.MembershipReboot.CustomGroups;
using IdSrv3.MembershipReboot.CustomUsers;
using IdentityManager.MembershipReboot;

namespace IdSrv3.IdentityManager
{
    public class CustomIdentityManagerService : MembershipRebootIdentityManagerService<CustomUser, CustomGroup>
    {
        public CustomIdentityManagerService(CustomUserAccountService userSvc, CustomGroupService groupSvc)
            : base(userSvc, groupSvc)
        {
            //Custom code here.
        }
    }
}