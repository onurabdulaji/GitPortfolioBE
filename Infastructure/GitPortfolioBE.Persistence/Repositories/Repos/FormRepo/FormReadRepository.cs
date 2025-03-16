using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.FormIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.FormRepo;

public class FormReadRepository : ReadRepository<Form>, IFormReadRepository
{
    public FormReadRepository(AppDbContext context) : base(context)
    {
    }
}
