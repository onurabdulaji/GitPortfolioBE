using GitPortfolioBE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class ServiceConfiguration : BaseConfiguration<Service>
{
    public override void Configure(EntityTypeBuilder<Service> builder)
    {
        base.Configure(builder);
    }
}
