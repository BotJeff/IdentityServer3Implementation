using BrockAllen.MembershipReboot.Ef;
using IdSrv3.MembershipRoot.CustomDatabases;
using BrockAllen.MembershipReboot;

namespace IdSrv3.MembershipRoot.CustomUsers
{
    public class CustomUserRepository : DbContextUserAccountRepository<CustomDatabase, CustomUser>, IUserAccountRepository<CustomUser>
    {
        public CustomUserRepository(CustomDatabase ctx) : base(ctx) { }
    }
}