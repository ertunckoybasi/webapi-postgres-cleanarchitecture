using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeature.Commands.CreateEmployee
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(v => v.Name)
                .MaximumLength(50)
                .NotEmpty();
            
            RuleFor(v => v.Email)
               .MaximumLength(150)
               .NotEmpty();

            RuleFor(v => v.IdentityNo)
               .NotNull()
               .Length(11)
               .NotEmpty();

        }
    }
}
