using GitPortfolioBE.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GitPortfolioBE.Domain.Entities;

public class AppUser : IdentityUser<Guid>, IEntity
{
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }
    public AppUser()
    {
        CreatedDate = DateTime.UtcNow;
    }
    public Guid ID { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
