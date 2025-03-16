using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.HeroIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.HeroRepo;

public class HeroReadRepository : ReadRepository<Hero>, IHeroReadRepository
{
    public HeroReadRepository(AppDbContext context) : base(context)
    {
    }
}
