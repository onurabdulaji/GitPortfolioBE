using GitPortfolioBE.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitPortfolioBE.Persistence.Configurations;

public class AppUserConfiguration :  BaseConfiguration<AppUser>
{
    public override void Configure(EntityTypeBuilder<AppUser> builder)
    {
        base.Configure(builder);
        var adminUserId = Guid.Parse("D90B3A5E-1C5D-4B29-89E2-6E3D5E1B5A7A"); ; // Kullanıcı için ID oluştur
        var hasher = new PasswordHasher<AppUser>();

        AppUser adminUser = new()
        {
            Id = adminUserId, // IdentityUser<Guid> içindeki Id kullanılıyor
            UserFullName = "Onur Abdulaji",
            UserName = "OnurAbdulaji",
            NormalizedUserName = "ONURABDULAJI",
            Email = "onurabdulaji@gmail.com",
            NormalizedEmail = "ONURABDULAJI@GMAIL.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
        };

        // Şifreyi hashleyerek ekliyoruz
        adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin123!@#");

        builder.HasData(adminUser);
    }
}
