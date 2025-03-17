using GitPortfolioBE.Application.Interfaces.IServices.Tokens;
using GitPortfolioBE.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace GitPortfolioBE.Infastructure.Managers.Tokens;

public class TokenService : ITokenService
{
    private readonly UserManager<AppUser> userManager;
    private readonly TokenSettings tokenSettings;

    public TokenService(UserManager<AppUser> userManager, IOptions<TokenSettings> tokenSettings)
    {
        this.userManager = userManager;
        this.tokenSettings = tokenSettings.Value;  // IOptions ile gelen değer burada alınır
    }

    public async Task<JwtSecurityToken> CreateToken(AppUser user, IList<string> roles)
    {
        var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email)
            };
        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSettings.Secret));

        var token = new JwtSecurityToken(
            issuer: tokenSettings.Issuer,
            audience: tokenSettings.Audience,
            expires: DateTime.UtcNow.AddMinutes(tokenSettings.TokenValidityInMunitues),
            claims: claims,
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
            );

        await userManager.AddClaimsAsync(user, claims);

        return token;
    }

    public string GenerateRefreshToken()
    {
        var randomNumber = new byte[64];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }

    public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token)
    {
        // Token Validation Parameters
        TokenValidationParameters tokenValidationParameters = new()
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSettings.Secret)),
            ValidateLifetime = false, // Expired token'ı da doğrulamak istiyoruz
            ClockSkew = TimeSpan.Zero // Token'da herhangi bir zaman farkını dikkate almamak için
        };

        JwtSecurityTokenHandler tokenHandler = new();

        try
        {
            // Token'ı validate et
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);

            // Token doğrulandıysa ve doğru algoritma kullanıldıysa, principal döndür
            if (securityToken is JwtSecurityToken jwtSecurityToken
                && jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                return principal;
            }

            throw new SecurityTokenException("Geçersiz token veya algoritma.");
        }
        catch (SecurityTokenException ex)
        {
            // Token doğrulama hatası varsa buradaki hata mesajı daha açıklayıcı olabilir
            throw new SecurityTokenException("Token doğrulama hatası: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Diğer hatalar için genel hata mesajı
            throw new Exception("Token işleme sırasında beklenmedik bir hata oluştu: " + ex.Message);
        }
    }
}
