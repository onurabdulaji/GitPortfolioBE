using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ResumeIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.ResumeRepo;

public class ResumeWriteRepository : WriteRepository<Resume>, IResumeWriteRepository
{
    public ResumeWriteRepository(AppDbContext context) : base(context)
    {
    }
}