using BrockAllen.MembershipReboot;
using IdSrv3.MembershipReboot.CustomUsers;
using System.Security.Claims;


namespace IdSrv3.MembershipReboot.CustomConfiguration
{
    public class CustomClaimsMapper : ICommandHandler<MapClaimsFromAccount<CustomUser>>
    {
        public void Handle(MapClaimsFromAccount<CustomUser> cmd)
        {
            cmd.MappedClaims = new Claim[]
            {
                new Claim(ClaimTypes.Email, cmd.Account.Email),
                new Claim(ClaimTypes.NameIdentifier, cmd.Account.Username)
            };
        }
    }
}