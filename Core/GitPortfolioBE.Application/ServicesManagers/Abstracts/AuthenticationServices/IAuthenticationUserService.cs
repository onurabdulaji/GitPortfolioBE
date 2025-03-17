using GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Commands.AuthenticationLogin;
using GitPortfolioBE.Domain.Entities;

namespace GitPortfolioBE.Application.ServicesManagers.Abstracts.AuthenticationServices;

public interface IAuthenticationUserService
{
    Task<AppUser> GetUserByEmailAsync(string email);
    Task<bool> ValidatePasswordAsync(AppUser user, string password);
    Task<LoginResponse> LoginUserAsync(string email, string password);
}
