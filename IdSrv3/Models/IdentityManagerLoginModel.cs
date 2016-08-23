using System.ComponentModel.DataAnnotations;
using IdSrv3.Attributes;

namespace IdSrv3.Models
{
    public class IdentityManagerLoginModel
    {
        [Required(ErrorMessage = "You forgot to enter a user name.")]
        [ConfigRegularExpression("UsernameRegex", ErrorMessage =
                "Username must be between 6-18 characters"
                + " and may not contain special characters or spaces.")]
        [UniqueUsername(ErrorMessage = "That user name is already taken.")]
        [Display(Name = "User name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You forgot to enter a password.")]
        [DataType(DataType.Password)]
        [ConfigRegularExpression("PasswordRegex",
            ErrorMessage = "Password must meet requirements.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}