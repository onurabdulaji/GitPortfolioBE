using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;
public class EducationConfiguration : BaseConfiguration<Education>
{
    public override void Configure(EntityTypeBuilder<Education> builder)
    {
        base.Configure(builder);
    }
}