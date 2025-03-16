﻿using GitPortfolioBE.Domain.Entities;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.EducationIRepo;
using GitPortfolioBE.Persistence.Context;

namespace GitPortfolioBE.Persistence.Repositories.Repos.EducationRepo;

public class EducationReadRepository : ReadRepository<Education>, IEducationReadRepository
{
    public EducationReadRepository(AppDbContext context) : base(context)
    {
    }
}
