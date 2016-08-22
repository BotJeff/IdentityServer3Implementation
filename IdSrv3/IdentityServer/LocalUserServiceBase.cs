using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer3.Core.Extensions;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services.Default;
using IdSrv3.Entities;
using IdSrv3.Extensions;

namespace IdSrv3.MembershipReboot.UserService
{
    public class LocalUserServiceBase : UserServiceBase
    {
        public override Task AuthenticateLocalAsync(LocalAuthenticationContext context)
        {
            if(context == null || string.IsNullOrEmpty(context.Password))
                return Task.FromResult(0);

            var userService = UserAccountService.GetCustomUserAccountService();
            var user = userService.GetByUsername(context.UserName);

            if(user.RequiresPasswordReset)
            {
                userService.ResetPassword(user.ID);
            }

            if(user.VerifyPassword(context.Password))
            {
                context.AuthenticateResult
                    = new AuthenticateResult(user.ID.ToString(), user.Username);
            }

            return Task.FromResult(0);
        }

        public override Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            string subject = context.Subject.GetSubjectId();
            UserAccount user;
            using(var ISE = new IdentityServerEntities())
            {
                user = ISE.UserAccounts.SingleOrDefault(u => u.ID.ToString() == subject);
            }

            if(user != null)
            {
                var userClaims = user.UserClaims.Where(u => context.RequestedClaimTypes.Contains(u.Type));

                List<Claim> claims = new List<Claim>();
                foreach(var claim in userClaims)
                {
                    claims.Add(new Claim(claim.Type, claim.Value));
                }
                context.IssuedClaims = claims;
            }
            return Task.FromResult(0);
        }
    }
}