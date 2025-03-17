using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class FormConfiguration : BaseConfiguration<Form>
{
    public override void Configure(EntityTypeBuilder<Form> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.EntityId);
    }
}
