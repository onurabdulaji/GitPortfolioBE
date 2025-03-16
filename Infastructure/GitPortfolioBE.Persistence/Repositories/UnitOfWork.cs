using GitPortfolioBE.Domain.Interfaces.IRepositories;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    IReadRepository<T> IUnitOfWork.GetReadRepository<T>()
    {
        return new ReadRepository<T>(_context);
    }

    IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()
    {
        return new WriteRepository<T>(_context);
    }
}
