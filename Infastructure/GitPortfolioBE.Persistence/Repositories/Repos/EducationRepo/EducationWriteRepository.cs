using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.EducationIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.EducationRepo;

public class EducationWriteRepository : WriteRepository<Education>, IEducationWriteRepository
{
    public EducationWriteRepository(AppDbContext context) : base(context)
    {
    }
}
