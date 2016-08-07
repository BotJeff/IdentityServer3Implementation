using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrockAllen.MembershipReboot;
using IdSrv3.MembershipRoot.CustomConfiguration;

namespace IdSrv3.MembershipRoot.CustomUsers
{
    public class CustomUserAccountService : UserAccountService<CustomUser>
    {
        public CustomUserAccountService(MembershipRebootConfiguration<CustomUser> config, CustomUserRepository repo)
            : base(config, repo)
        {

        }
    }
}