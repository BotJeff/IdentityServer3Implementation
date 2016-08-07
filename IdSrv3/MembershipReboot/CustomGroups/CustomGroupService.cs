using BrockAllen.MembershipReboot;
using BrockAllen.MembershipReboot.Ef;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IdSrv3.MembershipRoot.CustomConfiguration;
using IdSrv3.MembershipRoot.CustomDatabases;
using IdSrv3.App_Start;
using IdSrv3.MembershipRoot.CustomUsers;

namespace IdSrv3.MembershipRoot.CustomGroups
{
    public class CustomGroupService : GroupService<CustomGroup>
    {
        public CustomGroupService(CustomGroupRepository repo, MembershipRebootConfiguration<CustomUser> config)
            : base(config.DefaultTenant, repo)
        {
        }
    }
}