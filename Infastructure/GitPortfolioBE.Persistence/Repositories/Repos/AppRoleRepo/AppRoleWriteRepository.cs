using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.AppRoleIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.AppRoleRepo;

public class AppRoleWriteRepository : WriteRepository<AppRole>, IAppRoleWriteRepository
{
    public AppRoleWriteRepository(AppDbContext context) : base(context)
    {
    }
}