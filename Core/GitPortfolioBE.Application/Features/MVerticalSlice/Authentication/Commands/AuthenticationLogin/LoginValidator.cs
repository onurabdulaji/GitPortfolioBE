using FluentValidation;

namespace GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Commands.AuthenticationLogin;

public class LoginValidator : AbstractValidator<LoginRequest>
{
    public LoginValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Email is not valid");
        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required");
    }
}
