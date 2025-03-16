using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ServiceIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.ServiceRepo;

public class ServiceReadRepository : ReadRepository<Service>, IServiceReadRepository
{
    public ServiceReadRepository(AppDbContext context) : base(context)
    {
    }
}
