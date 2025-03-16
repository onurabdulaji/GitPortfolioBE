using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.AppUserIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.AppUserRepo;

public class AppUserWriteRepository : WriteRepository<AppUser>, IAppUserWriteRepository
{
    public AppUserWriteRepository(AppDbContext context) : base(context)
    {
    }
}