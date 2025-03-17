using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class AppUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
    {
        var adminUserId = Guid.Parse("D90B3A5E-1C5D-4B29-89E2-6E3D5E1B5A7A");
        var adminRoleId = Guid.Parse("A23D4F76-45C8-4A9F-B8C9-2E78D5EBD4F8");

        builder.HasData(new IdentityUserRole<Guid>
        {
            UserId = adminUserId,
            RoleId = adminRoleId
        });

    }
}
