using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.AppUserIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.AppUserRepo;

public class AppUserReadRepository : ReadRepository<AppUser>, IAppUserReadRepository
{
    public AppUserReadRepository(AppDbContext context) : base(context)
    {
    }
}
