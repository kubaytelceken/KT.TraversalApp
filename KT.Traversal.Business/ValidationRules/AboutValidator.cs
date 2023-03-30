using FluentValidation;
using KT.Traversal.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.Business.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Description field cannot be empty!");
            RuleFor(x=>x.Image).NotEmpty().WithMessage("Please choose an image!");
            RuleFor(x=>x.Description).MinimumLength(50).WithMessage("Please enter a description of at least 50 characters!");
            
        }
    }
}
