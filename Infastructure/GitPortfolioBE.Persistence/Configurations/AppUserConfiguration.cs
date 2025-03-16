using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class AppUserConfiguration :  BaseConfiguration<AppUser>
{
    public override void Configure(EntityTypeBuilder<AppUser> builder)
    {
        base.Configure(builder);
        // Primary Key olarak IEntity içindeki Id'yi kullanıyoruz
        builder.HasKey(x => x.ID);

        // IdentityUser içindeki varsayılan Id özelliğini görmezden geliyoruz
        builder.Ignore(x => x.Id);

        builder.Property(u => u.RefreshToken)
              .IsRequired(false);

        builder.Property(u => u.RefreshTokenExpiryTime)
               .IsRequired(false);
    }
}
