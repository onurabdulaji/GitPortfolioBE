using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class StatConfiguration : BaseConfiguration<Stat>
{
    public override void Configure(EntityTypeBuilder<Stat> builder)
    {
        base.Configure(builder);
    }
}
