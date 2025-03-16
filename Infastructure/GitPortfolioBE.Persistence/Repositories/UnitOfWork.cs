using GitPortfolioBE.Domain.Interfaces.IRepositories;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.AboutIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.AppRoleIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.AppUserIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ContactIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.EducationIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.FormIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.HeroIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ProjectIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ResumeIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.ServiceIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.SkilIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.SocialMediaIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.StatIRepo;
using GitPortfolioBE.Domain.Interfaces.IRepositories.IRepo.SummaryIRepo;
using GitPortfolioBE.Persistence.Context;
using GitPortfolioBE.Persistence.Repositories.Repos.AboutRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.AppRoleRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.AppUserRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.ContactRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.EducationRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.FormRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.HeroRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.ProjectRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.ResumeRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.ServiceRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.SkillRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.SocialMediaRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.StatRepo;
using GitPortfolioBE.Persistence.Repositories.Repos.SummaryRepo;

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

    // About spesifik repository'ler
    public IAboutReadRepository AboutReadRepository => new AboutReadRepository(_context);
    public IAboutWriteRepository AboutWriteRepository => new AboutWriteRepository(_context);

    public IAppRoleReadRepository AppRoleReadRepository =>  new AppRoleReadRepository(_context);

    public IAppRoleWriteRepository AppRoleWriteRepository =>  new AppRoleWriteRepository(_context);

    public IAppUserReadRepository AppUserReadRepository =>  new AppUserReadRepository(_context);

    public IAppUserWriteRepository AppUserWriteRepository =>  new AppUserWriteRepository(_context);

    public IContactReadRepository ContactReadRepository =>  new ContactReadRepository(_context);

    public IContactWriteRepository ContactWriteRepository =>  new ContactWriteRepository(_context);

    public IEducationReadRepository EducationReadRepository =>  new EducationReadRepository(_context);

    public IEducationWriteRepository EducationWriteRepository =>  new EducationWriteRepository(_context);

    public IFormReadRepository FormReadRepository =>  new FormReadRepository(_context);

    public IFormWriteRepository FormWriteRepository =>  new FormWriteRepository(_context);

    public IHeroReadRepository HeroReadRepository =>  new HeroReadRepository(_context);

    public IHeroWriteRepository HeroWriteRepository =>  new HeroWriteRepository(_context);

    public IProjectReadRepository ProjectReadRepository =>  new ProjectReadRepository(_context);

    public IProjectWriteRepository ProjectWriteRepository =>  new ProjectWriteRepository(_context);

    public IResumeReadRepository ResumeReadRepository =>  new ResumeReadRepository(_context);

    public IResumeWriteRepository ResumeWriteRepository =>  new ResumeWriteRepository(_context);

    public IServiceReadRepository ServiceReadRepository =>  new ServiceReadRepository(_context);

    public IServiceWriteRepository ServiceWriteRepository =>  new ServiceWriteRepository(_context);

    public ISkillReadRepository SkillReadRepository =>  new SkillReadRepository(_context);

    public ISkillWriteRepository SkillWriteRepository =>  new SkillWriteRepository(_context);

    public ISocialMediaReadRepository SocialMediaReadRepository =>  new SocialMediaReadRepository(_context);

    public ISocialMediaWriteRepository SocialMediaWriteRepository =>  new SocialMediaWriteRepository(_context);

    public IStatReadRepository StatReadRepository =>  new StatReadRepository(_context);

    public IStatWriteRepository StatWriteRepository =>  new StatWriteRepository(_context);

    public ISummaryReadRepository SummaryReadRepository =>  new SummaryReadRepository(_context);

    public ISummaryWriteRepository SummaryWriteRepository =>  new SummaryWriteRepository(_context);
}
