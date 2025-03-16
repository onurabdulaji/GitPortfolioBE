namespace GitPortfolioBE.Domain.Interfaces.IRepositories;

public interface IUnitOfWork : IDisposable , IAsyncDisposable
{
    IReadRepository<T> GetReadRepository<T>() where T : class,IEntity;
    IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntity;
    Task<int> SaveAsync();
}
