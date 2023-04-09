using System.ComponentModel.DataAnnotations;

namespace KT.TraversalApp.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Enter your username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Enter your password")]
        public string Password { get; set; }
    }
}
