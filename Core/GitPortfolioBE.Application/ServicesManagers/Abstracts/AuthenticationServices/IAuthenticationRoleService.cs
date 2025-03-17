using GitPortfolioBE.Domain.Entities;

namespace GitPortfolioBE.Application.ServicesManagers.Abstracts.AuthenticationServices;

public interface IAuthenticationRoleService
{
    Task<IList<string>> GetUserRolesAsync(AppUser user);
}
