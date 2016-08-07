using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrockAllen.MembershipReboot;
using IdSrv3.MembershipRoot.CustomUsers;
using System.Security.Claims;


namespace IdSrv3.MembershipRoot.CustomConfiguration
{
    public class CustomClaimsMapper : ICommandHandler<MapClaimsFromAccount<CustomUser>>
    {
        public void Handle(MapClaimsFromAccount<CustomUser> cmd)
        {
            cmd.MappedClaims = new System.Security.Claims.Claim[]
            {
                new System.Security.Claims.Claim(ClaimTypes.Email, cmd.Account.Email),
                new System.Security.Claims.Claim(ClaimTypes.NameIdentifier, cmd.Account.Username),
            };
        }
    }
}