using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.SummaryIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.SummaryRepo;

public class SummaryReadRepository : ReadRepository<Summary>, ISummaryReadRepository
{
    public SummaryReadRepository(AppDbContext context) : base(context)
    {
    }
}
