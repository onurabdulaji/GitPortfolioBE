using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ResumeIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.ResumeRepo;

public class ResumeReadRepository : ReadRepository<Resume>, IResumeReadRepository
{
    public ResumeReadRepository(AppDbContext context) : base(context)
    {
    }
}
