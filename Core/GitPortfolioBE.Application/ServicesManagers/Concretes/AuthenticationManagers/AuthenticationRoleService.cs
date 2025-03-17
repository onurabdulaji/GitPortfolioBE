using GitPortfolioBE.Application.ServicesManagers.Abstracts.AuthenticationServices;
using GitPortfolioBE.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace GitPortfolioBE.Application.ServicesManagers.Concretes.AuthenticationManagers;

public class AuthenticationRoleService : IAuthenticationRoleService
{
    private readonly UserManager<AppUser> _userManager;

    public AuthenticationRoleService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IList<string>> GetUserRolesAsync(AppUser user)
    {
        return await _userManager.GetRolesAsync(user);
    }
}
