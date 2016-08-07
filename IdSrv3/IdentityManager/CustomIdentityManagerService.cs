using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdSrv3.MembershipRoot.CustomGroups;
using IdSrv3.MembershipRoot.CustomUsers;
using IdentityManager.MembershipReboot;

namespace IdSrv3.IdentityManager
{
    public class CustomIdentityManagerService : MembershipRebootIdentityManagerService<CustomUser, CustomGroup>
    {
        public CustomIdentityManagerService(CustomUserAccountService userSvc, CustomGroupService groupSvc)
            : base(userSvc, groupSvc)
        {
        }
    }
}