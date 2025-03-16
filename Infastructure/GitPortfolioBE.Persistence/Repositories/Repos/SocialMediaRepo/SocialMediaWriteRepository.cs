using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.SocialMediaIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.SocialMediaRepo;

public class SocialMediaWriteRepository : WriteRepository<SocialMedia>, ISocialMediaWriteRepository
{
    public SocialMediaWriteRepository(AppDbContext context) : base(context)
    {
    }
}