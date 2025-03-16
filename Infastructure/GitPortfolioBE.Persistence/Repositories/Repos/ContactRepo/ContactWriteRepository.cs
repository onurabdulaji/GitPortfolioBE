using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ContactIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.ContactRepo;

public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
{
    public ContactWriteRepository(AppDbContext context) : base(context)
    {
    }
}

