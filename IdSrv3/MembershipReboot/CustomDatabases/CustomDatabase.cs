using BrockAllen.MembershipReboot.Ef;
using IdSrv3.MembershipReboot.CustomGroups;
using IdSrv3.MembershipReboot.CustomUsers;

namespace IdSrv3.MembershipReboot.CustomDatabases
{
    public class CustomDatabase : MembershipRebootDbContext<CustomUser, CustomGroup>
    {
        public CustomDatabase(string connString) : base(connString)
        {
            //Additional customization here.
        }
    }
}