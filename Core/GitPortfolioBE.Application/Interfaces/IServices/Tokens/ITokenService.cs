using GitPortfolioBE.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace GitPortfolioBE.Application.Interfaces.IServices.Tokens;

public interface ITokenService
{
    Task<JwtSecurityToken> CreateToken(AppUser user, IList<string> roles);
    string GenerateRefreshToken();
    ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
}
