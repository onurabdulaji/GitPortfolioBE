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

namespace GitPortfolioBE.Domain.Interfaces.IRepositories;

public interface IUnitOfWork : IDisposable , IAsyncDisposable
{
    IReadRepository<T> GetReadRepository<T>() where T : class,IEntity;
    IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntity;
    Task<int> SaveAsync();
    // About Spesifik repository'ler
    IAboutReadRepository AboutReadRepository { get; }
    IAboutWriteRepository AboutWriteRepository { get; }
    // AppRole Spesifik repository'ler
    IAppRoleReadRepository AppRoleReadRepository { get; }
    IAppRoleWriteRepository AppRoleWriteRepository { get; }
    // AppUser Spesifik repository'ler
    IAppUserReadRepository AppUserReadRepository { get; }
    IAppUserWriteRepository AppUserWriteRepository { get; }
    // Contact Spesifik repository'ler
    IContactReadRepository ContactReadRepository { get; }
    IContactWriteRepository ContactWriteRepository { get; }
    // Education Spesifik repository'ler
    IEducationReadRepository EducationReadRepository { get; }
    IEducationWriteRepository EducationWriteRepository { get; }
    // Form Spesifik repository'ler
    IFormReadRepository FormReadRepository { get; }
    IFormWriteRepository FormWriteRepository { get; }
    // Hero Spesifik repository'ler
    IHeroReadRepository HeroReadRepository { get; }
    IHeroWriteRepository HeroWriteRepository { get; }
    // Project Spesifik repository'ler
    IProjectReadRepository ProjectReadRepository { get; }
    IProjectWriteRepository ProjectWriteRepository { get; }
    // Resume Spesifik repository'ler
    IResumeReadRepository ResumeReadRepository { get; }
    IResumeWriteRepository ResumeWriteRepository { get; }
    // Service Spesifik repository'ler
    IServiceReadRepository ServiceReadRepository { get; }
    IServiceWriteRepository ServiceWriteRepository { get; }
    // Skill Spesifik repository'ler
    ISkillReadRepository SkillReadRepository { get; }
    ISkillWriteRepository SkillWriteRepository { get; }
    // SocialMedia Spesifik repository'ler
    ISocialMediaReadRepository SocialMediaReadRepository { get; }
    ISocialMediaWriteRepository SocialMediaWriteRepository { get; }
    // Stat Spesifik repository'ler
    IStatReadRepository StatReadRepository { get; }
    IStatWriteRepository StatWriteRepository { get; }
    // Summary Spesifik repository'ler
    ISummaryReadRepository SummaryReadRepository { get; }
    ISummaryWriteRepository SummaryWriteRepository { get; }


}
