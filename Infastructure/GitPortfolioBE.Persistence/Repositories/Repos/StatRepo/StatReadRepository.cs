using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.StatIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.StatRepo;

public class StatReadRepository : ReadRepository<Stat>, IStatReadRepository
{
    public StatReadRepository(AppDbContext context) : base(context)
    {
    }
}
