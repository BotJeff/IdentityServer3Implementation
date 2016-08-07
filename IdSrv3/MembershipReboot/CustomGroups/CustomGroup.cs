using BrockAllen.MembershipReboot;
using BrockAllen.MembershipReboot.Ef;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdSrv3.MembershipRoot.CustomGroups
{
    public class CustomGroup : RelationalGroup
    {
        public virtual string Description { get; set; }
    }
}