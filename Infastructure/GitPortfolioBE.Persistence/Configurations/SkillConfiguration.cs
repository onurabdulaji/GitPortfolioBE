using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class SkillConfiguration : BaseConfiguration<Skill>
{
    public override void Configure(EntityTypeBuilder<Skill> builder)
    {
        base.Configure(builder);
    }
}
