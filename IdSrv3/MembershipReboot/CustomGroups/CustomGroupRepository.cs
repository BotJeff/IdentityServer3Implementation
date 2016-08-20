using BrockAllen.MembershipReboot.Ef;
using IdSrv3.MembershipRoot.CustomDatabases;

namespace IdSrv3.MembershipReboot.CustomGroups
{
    public class CustomGroupRepository : DbContextGroupRepository<CustomDatabase, CustomGroup>
    {
        public CustomGroupRepository(CustomDatabase ctx) : base(ctx)
        {
        }
    }
}