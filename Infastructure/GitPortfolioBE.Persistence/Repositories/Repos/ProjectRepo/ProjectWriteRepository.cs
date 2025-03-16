using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ProjectIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.ProjectRepo;

public class ProjectWriteRepository : WriteRepository<Project>, IProjectWriteRepository
{
    public ProjectWriteRepository(AppDbContext context) : base(context)
    {
    }
}