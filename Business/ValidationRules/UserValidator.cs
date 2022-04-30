using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).MinimumLength(3).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(3).NotEmpty();
            RuleFor(u => u.Email).MinimumLength(3).EmailAddress();
            RuleFor(u => u.Password).MinimumLength(10).NotEmpty();
        }
    }
}
