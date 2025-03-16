using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class RoleConfiguration : BaseConfiguration<AppRole>
{
    public override void Configure(EntityTypeBuilder<AppRole> builder)
    {
        base.Configure(builder);
    }
}
