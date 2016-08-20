using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer3.Core.Extensions;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services.Default;
using IdSrv3.Crypto.IdSrv3Crypto;
using IdSrv3.Entities;

namespace IdSrv3.MembershipReboot.UserService
{
    public class LocalRegistrationUserService : UserServiceBase
    {
        public class CustomUser
        {
            //Retaining this class for the examples. Otherwise it's not needed in Production.
            public Guid Subject { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public List<Claim> Claims { get; set; }
        }

        public static List<CustomUser> Users = new List<CustomUser>();

        private IdentityServerEntities ISE = new IdentityServerEntities();

        public override Task AuthenticateLocalAsync(LocalAuthenticationContext context)
        {
            if(context == null || string.IsNullOrEmpty(context.Password))
                return Task.FromResult(0);

            UserAccount user = ISE.UserAccounts.SingleOrDefault(u => u.Username == context.UserName);
            if(user.RequiresPasswordReset)
            {
                var userAccountService = UserAccountService.GetCustomUserAccountService();
                userAccountService.ResetPassword(user.ID);
            }

            if(IsVerifiedPassword(context, user))
                context.AuthenticateResult = new AuthenticateResult(user.ID.ToString(), user.Username);

            return Task.FromResult(0);
        }

        private static bool IsVerifiedPassword(LocalAuthenticationContext context, UserAccount user)
        {
            var crypto = new DefaultCrypto();
            return crypto.VerifyHashedPassword(user.HashedPassword, context.Password);
        }

        public override Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            string subject = context.Subject.GetSubjectId();
            UserAccount user = ISE.UserAccounts.SingleOrDefault(u => u.ID.ToString() == subject);

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