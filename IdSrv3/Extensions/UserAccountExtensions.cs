using IdSrv3.Crypto.IdSrv3Crypto;
using IdSrv3.Entities;
using IdSrv3.MembershipReboot.CustomUsers;

namespace IdSrv3.Extensions
{
    public static class UserAccountExtensions
    {
        public static bool VerifyPassword(this UserAccount user, string pass)
        {
            var crypto = new DefaultCrypto();
            return crypto.VerifyHashedPassword(user.HashedPassword, pass);
        }

        public static bool VerifyPassword(this CustomUser user, string pass)
        {
            var crypto = new DefaultCrypto();
            return crypto.VerifyHashedPassword(user.HashedPassword, pass);
        }
    }
}