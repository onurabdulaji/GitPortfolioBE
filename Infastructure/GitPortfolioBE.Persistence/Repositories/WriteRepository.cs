using GitPortfolioBE.Domain.Interfaces;
using GitPortfolioBE.Domain.Interfaces.IRepositories;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntity
{
    private readonly AppDbContext _context;
    public WriteRepository(AppDbContext context)
    {
        _context = context;
    }
}
