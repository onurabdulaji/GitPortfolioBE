using GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Rules;
using GitPortfolioBE.Application.Interfaces.IServices.Tokens;
using GitPortfolioBE.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;

namespace GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Commands.AuthenticationLogin;

public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ITokenService _tokenService; 
    private readonly ILogger<LoginHandler> _logger;
    private readonly AuthenticationRules _authenticationRules;

    public LoginHandler(UserManager<AppUser> userManager, ITokenService tokenService, ILogger<LoginHandler> logger, AuthenticationRules authenticationRules)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _logger = logger;
        _authenticationRules = authenticationRules;
    }

    public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null)
        {
            _logger.LogWarning("User not found");
            throw new UnauthorizedAccessException("Invalid email or password");
        }

        var result = await _userManager.CheckPasswordAsync(user, request.Password);

        // Use AuthenticationRules to validate email and password
        await _authenticationRules.ValidateEmailAndPassword(user, result);

        var roles = await _userManager.GetRolesAsync(user);
        var token = await _tokenService.CreateToken(user, roles.ToList());

        return new LoginResponse
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            RefreshToken = user.RefreshToken,
            Expiration = token.ValidTo
        };
    }
}
