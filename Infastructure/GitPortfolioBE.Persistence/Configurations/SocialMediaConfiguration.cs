using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class SocialMediaConfiguration : BaseConfiguration<SocialMedia>
{
    public override void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.EntityId);
    }
}
