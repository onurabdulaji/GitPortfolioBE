using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.AppRoleIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.AppRoleRepo;

public class AppRoleReadRepository : ReadRepository<AppRole>, IAppRoleReadRepository
{
    public AppRoleReadRepository(AppDbContext context) : base(context)
    {
    }
}
