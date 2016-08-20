using BrockAllen.MembershipReboot.Ef;
using IdSrv3.MembershipReboot.CustomDatabases;

namespace IdSrv3.MembershipReboot.CustomGroups
{
    public class CustomGroupRepository : DbContextGroupRepository<CustomDatabase, CustomGroup>
    {
        public CustomGroupRepository(CustomDatabase ctx) : base(ctx)
        {
        }
    }
}