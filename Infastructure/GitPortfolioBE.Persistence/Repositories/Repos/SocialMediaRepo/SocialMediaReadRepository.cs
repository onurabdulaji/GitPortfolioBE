using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.SocialMediaIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.SocialMediaRepo;

public class SocialMediaReadRepository : ReadRepository<SocialMedia>, ISocialMediaReadRepository
{
    public SocialMediaReadRepository(AppDbContext context) : base(context)
    {
    }
}
