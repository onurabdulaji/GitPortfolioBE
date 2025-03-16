using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class ResumeConfiguration : BaseConfiguration<Resume>
{
    public override void Configure(EntityTypeBuilder<Resume> builder)
    {
        base.Configure(builder);
    }
}
