using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using IdSrv3.Attributes;
using IdSrv3.AppSettings;

namespace IdSrv3.Models
{
    public class PasswordResetWithKeyModel
    {
        [Required]
        [DataType(DataType.Password)]
        [ConfigRegularExpression("PasswordRegex",
            ErrorMessage = "Password must meet requirements.")]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New password")]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
    }
}