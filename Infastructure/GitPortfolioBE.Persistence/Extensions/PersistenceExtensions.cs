using GitPortfolioBE.Domain.Entities;
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
using GitPortfolioBE.Persistence.Repositories;
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
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GitPortfolioBE.Persistence.Extensions;

public static class PersistenceExtensions
{
    public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddIdentity<AppUser, AppRole>(options =>
        {
            options.SignIn.RequireConfirmedAccount = true;
        })
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders();


        services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
        services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        // Spesifik Repository'ler

        services.AddScoped<IAboutReadRepository, AboutReadRepository>();
        services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();

        services.AddScoped<IAppRoleReadRepository, AppRoleReadRepository>();
        services.AddScoped<IAppRoleWriteRepository, AppRoleWriteRepository>();

        services.AddScoped<IAppUserReadRepository, AppUserReadRepository>();
        services.AddScoped<IAppUserWriteRepository, AppUserWriteRepository>();

        services.AddScoped<IContactReadRepository, ContactReadRepository>();
        services.AddScoped<IContactWriteRepository, ContactWriteRepository>();

        services.AddScoped<IEducationReadRepository, EducationReadRepository>();
        services.AddScoped<IEducationWriteRepository, EducationWriteRepository>();

        services.AddScoped<IFormReadRepository, FormReadRepository>();
        services.AddScoped<IFormWriteRepository, FormWriteRepository>();

        services.AddScoped<IHeroReadRepository, HeroReadRepository>();
        services.AddScoped<IHeroWriteRepository, HeroWriteRepository>();

        services.AddScoped<IProjectReadRepository, ProjectReadRepository>();
        services.AddScoped<IProjectWriteRepository, ProjectWriteRepository>();

        services.AddScoped<IResumeReadRepository, ResumeReadRepository>();
        services.AddScoped<IResumeWriteRepository, ResumeWriteRepository>();

        services.AddScoped<IServiceReadRepository, ServiceReadRepository>();
        services.AddScoped<IServiceWriteRepository, ServiceWriteRepository>();

        services.AddScoped<ISkillReadRepository, SkillReadRepository>();
        services.AddScoped<ISkillWriteRepository, SkillWriteRepository>();

        services.AddScoped<ISocialMediaReadRepository, SocialMediaReadRepository>();
        services.AddScoped<ISocialMediaWriteRepository, SocialMediaWriteRepository>();

        services.AddScoped<IStatReadRepository, StatReadRepository>();
        services.AddScoped<IStatWriteRepository, StatWriteRepository>();

        services.AddScoped<ISummaryReadRepository, SummaryReadRepository>();
        services.AddScoped<ISummaryWriteRepository, SummaryWriteRepository>();

        services.AddScoped<RoleManager<AppRole>>();
        services.AddScoped<UserManager<AppUser>>();
    }
}
