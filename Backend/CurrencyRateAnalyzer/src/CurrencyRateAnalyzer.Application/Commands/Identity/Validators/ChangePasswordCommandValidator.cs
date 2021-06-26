using CurrencyRateAnalyzer.Application.Interfaces.Repositories.Identity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Commands.Identity.Validators
{
    class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
    {
        private readonly IUserRepository _userRepository;
        public ChangePasswordCommandValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(v => v.UserId)
                .NotNull().WithMessage("UserId should not be null.")
                .NotEmpty().WithMessage("UserId is required.")
                .Must(UserIdExist).WithMessage("The specified userId doesnt exist.");

            RuleFor(v => v.CurrentPassword)
                .NotNull().WithMessage("Password should not be null.")
                .NotEmpty().WithMessage("Password is required.")
                .MaximumLength(50).WithMessage("Password Length should be < 50.")
                .MinimumLength(7).WithMessage("Password Length should be > 7.");

            RuleFor(v => v.NewPassword)
               .NotNull().WithMessage("Password should not be null.")
                .NotEmpty().WithMessage("Password is required.")
                .MaximumLength(50).WithMessage("Password Length should be < 50.")
                .MinimumLength(7).WithMessage("Password Length should be > 7.");
        }

        protected bool UserIdExist(Guid userId)
        {
            return _userRepository.GetAsync(userId) == null ? false : true;
        }
    }
}
