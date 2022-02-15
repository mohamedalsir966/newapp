using Domin.Resources;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domin.Validators
{
    public class SaveCategoryResourceValidator : AbstractValidator<SaveCategoryResource>
    {
        public SaveCategoryResourceValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("name from alisr is required");
        }
    }
}
