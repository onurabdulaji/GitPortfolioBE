using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class SummaryConfiguration : BaseConfiguration<Summary>
{
    public override void Configure(EntityTypeBuilder<Summary> builder)
    {
        base.Configure(builder);
    }
}