using GitPortfolioBE.Domain.Entities;

namespace GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Rules;

public class AuthenticationRules
{
    // Kullanıcıya ait email veya şifre doğrulaması yapılır.
    public Task ValidateEmailAndPassword(AppUser? appUser, bool isPasswordValid)
    {
        if (appUser == null || !isPasswordValid)
        {
            throw new UnauthorizedAccessException("Login failed: Invalid email or password.");
        }
        return Task.CompletedTask;
    }
}
