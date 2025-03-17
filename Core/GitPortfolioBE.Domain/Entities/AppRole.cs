using GitPortfolioBE.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GitPortfolioBE.Domain.Entities;

public class AppRole : IdentityRole<Guid>, IEntity
{
    public AppRole() { }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public Guid EntityId { get => Id; set => Id = value; }
}
