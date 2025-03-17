using GitPortfolioBE.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GitPortfolioBE.Domain.Entities;

public class AppUser : IdentityUser<Guid>, IEntity
{
    public string? UserFullName { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }
    public AppUser()
    {
        CreatedDate = DateTime.UtcNow;
    }
    public Guid EntityId { get => Id; set => Id = value; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
