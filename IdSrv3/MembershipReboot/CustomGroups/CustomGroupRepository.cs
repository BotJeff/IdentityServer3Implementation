using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrockAllen.MembershipReboot.Ef;
using IdSrv3.MembershipRoot.CustomDatabases;

namespace IdSrv3.MembershipRoot.CustomGroups
{
    public class CustomGroupRepository : DbContextGroupRepository<CustomDatabase, CustomGroup>
    {
        public CustomGroupRepository(CustomDatabase ctx): base(ctx){}
    }
}