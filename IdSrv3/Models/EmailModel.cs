using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using IdSrv3.Attributes;

namespace IdSrv3.Models
{
    public class EmailModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [EmailAddressNotFound(ErrorMessage = "Email address was not found.")]            
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}