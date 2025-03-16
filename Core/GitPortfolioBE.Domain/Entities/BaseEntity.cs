using GitPortfolioBE.Domain.Interfaces;

namespace GitPortfolioBE.Domain.Entities;

public class BaseEntity : IEntity
{
    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
    }
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
