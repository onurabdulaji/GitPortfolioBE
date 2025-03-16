using GitPortfolioBE.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GitPortfolioBE.Persistence.Context;

public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Form> Forms { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Stat> Stats { get; set; }
    public DbSet<Summary> Summaries { get; set; }
}
