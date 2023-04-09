using Microsoft.AspNetCore.Identity;

namespace KT.TraversalApp.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordToShort",
                Description = $"password must be a minimum of {length} characters"
            };
        }
    }
}
