using GitPortfolioBE.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        
    }
}
