namespace GitPortfolioBE.Domain.Interfaces;

public interface IEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
