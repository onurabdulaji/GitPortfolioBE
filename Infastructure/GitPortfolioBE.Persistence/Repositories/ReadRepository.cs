using GitPortfolioBE.Domain.Interfaces.IRepositories;
using GitPortfolioBE.Domain.Interfaces;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : class, IEntity
{
    private readonly AppDbContext _context;
    public ReadRepository(AppDbContext context)
    {
        _context = context;
    }
}
