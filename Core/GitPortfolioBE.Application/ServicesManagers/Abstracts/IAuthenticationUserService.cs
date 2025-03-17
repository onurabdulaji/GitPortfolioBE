using GitPortfolioBE.Domain.Entities;

namespace GitPortfolioBE.Application.ServicesManagers.Abstracts;

public interface IAuthenticationUserService
{
    Task<AppUser> GetUserByEmailAsync(string email);
    Task<bool> ValidatePasswordAsync(AppUser user, string password);
}
