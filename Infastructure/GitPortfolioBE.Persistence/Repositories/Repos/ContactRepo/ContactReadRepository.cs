using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ContactIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.ContactRepo;

public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
{
    public ContactReadRepository(AppDbContext context) : base(context)
    {
    }
}

