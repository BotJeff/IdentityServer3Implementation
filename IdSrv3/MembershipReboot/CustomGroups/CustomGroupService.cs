using BrockAllen.MembershipReboot;
using IdSrv3.MembershipRoot.CustomUsers;

namespace IdSrv3.MembershipReboot.CustomGroups
{
    public class CustomGroupService : GroupService<CustomGroup>
    {
        public CustomGroupService(CustomGroupRepository repo, MembershipRebootConfiguration<CustomUser> config)
            : base(config.DefaultTenant, repo)
        {
        }
    }
}