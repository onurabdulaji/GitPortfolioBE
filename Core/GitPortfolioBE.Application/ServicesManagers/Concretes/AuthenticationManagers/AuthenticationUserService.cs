using GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Commands.AuthenticationLogin;
using GitPortfolioBE.Application.Interfaces.IServices.Tokens;
using GitPortfolioBE.Application.ServicesManagers.Abstracts.AuthenticationServices;
using GitPortfolioBE.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;

namespace GitPortfolioBE.Application.ServicesManagers.Concretes.AuthenticationManagers;

public class AuthenticationUserService : IAuthenticationUserService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ITokenService _tokenService;

    public AuthenticationUserService(UserManager<AppUser> userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    public async Task<AppUser> GetUserByEmailAsync(string email)
    {
        return await _userManager.FindByEmailAsync(email);
    }

    public async Task<LoginResponse> LoginUserAsync(string email, string password)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
            throw new UnauthorizedAccessException("Invalid email or password");

        var isPasswordValid = await _userManager.CheckPasswordAsync(user, password);
        if (!isPasswordValid)
            throw new UnauthorizedAccessException("Invalid email or password");

        var roles = await _userManager.GetRolesAsync(user);
        var token = await _tokenService.CreateToken(user, roles.ToList());

        return new LoginResponse
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            RefreshToken = user.RefreshToken,
            Expiration = token.ValidTo
        };
    }

    public async Task<bool> ValidatePasswordAsync(AppUser user, string password)
    {
        return await _userManager.CheckPasswordAsync(user, password);
    }
}
