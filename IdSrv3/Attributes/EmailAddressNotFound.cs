﻿using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace IdSrv3.Attributes
{
    public class EmailAddressNotFound : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return false;

            using(var ISE = new Entities.IdentityServerEntities())
                return ISE.UserAccounts.Any(user => user.Email == value.ToString());
        }
    }
}