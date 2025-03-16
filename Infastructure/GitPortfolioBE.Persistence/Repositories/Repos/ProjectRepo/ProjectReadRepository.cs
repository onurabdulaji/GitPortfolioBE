using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ProjectIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.ProjectRepo;

public class ProjectReadRepository : ReadRepository<Project>, IProjectReadRepository
{
    public ProjectReadRepository(AppDbContext context) : base(context)
    {
    }
}
