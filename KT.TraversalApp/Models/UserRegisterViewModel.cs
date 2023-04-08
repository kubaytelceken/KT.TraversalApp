using System.ComponentModel.DataAnnotations;

namespace KT.TraversalApp.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Enter your username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter your mail")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Enter your phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Enter your password")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Enter your password")]
        [Compare("Password",ErrorMessage = "passwords are not the same")]
        public string ConfirmPassword { get; set; }
    }
}
