using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.SkilIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.SkillRepo;

public class SkillWriteRepository : WriteRepository<Skill>, ISkillWriteRepository
{
    public SkillWriteRepository(AppDbContext context) : base(context)
    {
    }
}