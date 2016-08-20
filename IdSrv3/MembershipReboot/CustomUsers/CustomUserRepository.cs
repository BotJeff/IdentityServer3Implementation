using BrockAllen.MembershipReboot;
using BrockAllen.MembershipReboot.Ef;
using IdSrv3.MembershipReboot.CustomDatabases;

namespace IdSrv3.MembershipReboot.CustomUsers
{
    public class CustomUserRepository : DbContextUserAccountRepository<CustomDatabase, CustomUser>, IUserAccountRepository<CustomUser>
    {
        public CustomUserRepository(CustomDatabase ctx) : base(ctx)
        {
        }
    }
}