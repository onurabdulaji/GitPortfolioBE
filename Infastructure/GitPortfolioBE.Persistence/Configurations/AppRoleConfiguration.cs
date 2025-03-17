using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class AppRoleConfiguration : BaseConfiguration<AppRole>
{
    public override void Configure(EntityTypeBuilder<AppRole> builder)
    {
        base.Configure(builder);

        var adminRoleId = Guid.Parse("A23D4F76-45C8-4A9F-B8C9-2E78D5EBD4F8");

        builder.HasData(new AppRole
        {
            Id = adminRoleId, // Aynı ID kullanılmalı
            Name = "Admin",
            NormalizedName = "ADMIN",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        });
    }
}
