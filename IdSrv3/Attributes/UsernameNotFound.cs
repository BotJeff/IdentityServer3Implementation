using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IdSrv3.Attributes
{
    public class UsernameNotFound : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return false;

            using (var ISE = new Entities.IdentityServerEntities())
                return ISE.UserAccounts.Any(user => user.Username == value.ToString());          
        }
    }
}