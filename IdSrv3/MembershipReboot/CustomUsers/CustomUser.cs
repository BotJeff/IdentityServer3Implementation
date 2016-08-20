using System.ComponentModel.DataAnnotations;
using BrockAllen.MembershipReboot.Relational;

namespace IdSrv3.MembershipReboot.CustomUsers
{
    public class CustomUser : RelationalUserAccount
    {
        [Display(Name = "First Name")]
        public virtual string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public virtual string LastName { get; set; }

        public virtual int? Age { get; set; }

        /*
         * NOTE: This class extends RelationalUserAccount, in essense it represents
         * a "UserAccount" class such as the one found in IdentityServerEntities.
         */
    }
}