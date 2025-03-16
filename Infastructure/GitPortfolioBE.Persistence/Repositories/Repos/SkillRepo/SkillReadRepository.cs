using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.SkilIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.SkillRepo;

public class SkillReadRepository : ReadRepository<Skill>, ISkillReadRepository
{
    public SkillReadRepository(AppDbContext context) : base(context)
    {
    }
}
