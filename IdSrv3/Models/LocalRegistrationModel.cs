using System.ComponentModel.DataAnnotations;
using IdSrv3.AppSettings;
using IdSrv3.Attributes;

namespace IdSrv3.Models
{
    public class LocalRegistrationModel
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

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string First { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string Last { get; set; }

        [Required(ErrorMessage = "Email is required (we promise not to spam you!)")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }
}