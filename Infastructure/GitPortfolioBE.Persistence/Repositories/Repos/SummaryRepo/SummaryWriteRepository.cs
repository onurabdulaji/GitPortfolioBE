using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.SummaryIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.SummaryRepo;

public class SummaryWriteRepository : WriteRepository<Summary>, ISummaryWriteRepository
{
    public SummaryWriteRepository(AppDbContext context) : base(context)
    {
    }
}
