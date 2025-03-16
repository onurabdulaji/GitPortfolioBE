using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class AboutConfiguration : BaseConfiguration<About>
{
    public override void Configure(EntityTypeBuilder<About> builder)
    {
        base.Configure(builder);
    }
}