using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.FormIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.FormRepo;

public class FormWriteRepository : WriteRepository<Form>, IFormWriteRepository
{
    public FormWriteRepository(AppDbContext context) : base(context)
    {
    }
}
