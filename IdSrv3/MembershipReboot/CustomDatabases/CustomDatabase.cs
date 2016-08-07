using BrockAllen.MembershipReboot.Ef;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IdSrv3.MembershipRoot.CustomGroups;
using IdSrv3.MembershipRoot.CustomUsers;

namespace IdSrv3.MembershipRoot.CustomDatabases
{
    public class CustomDatabase : MembershipRebootDbContext<CustomUser, CustomGroup>
    {
        /*
         * 
         */
        public CustomDatabase(string connString) : base (connString){}
    }
}