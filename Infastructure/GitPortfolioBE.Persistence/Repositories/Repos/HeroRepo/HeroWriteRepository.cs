using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.HeroIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.HeroRepo;

public class HeroWriteRepository : WriteRepository<Hero>, IHeroWriteRepository
{
    public HeroWriteRepository(AppDbContext context) : base(context)
    {
    }
}