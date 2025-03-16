using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ServiceIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.ServiceRepo;

public class ServiceWriteRepository : WriteRepository<Service>, IServiceWriteRepository
{
    public ServiceWriteRepository(AppDbContext context) : base(context)
    {
    }
}