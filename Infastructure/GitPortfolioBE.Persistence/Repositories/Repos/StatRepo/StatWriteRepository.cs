using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.StatIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.StatRepo;

public class StatWriteRepository : WriteRepository<Stat>, IStatWriteRepository
{
    public StatWriteRepository(AppDbContext context) : base(context)
    {
    }
}
