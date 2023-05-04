using FluentValidation;
using KT.Traversal.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.Business.ValidationRules
{
    public class GuideValidator :AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter guide name");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter guide description");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please load guide image");
        }
    }
}
