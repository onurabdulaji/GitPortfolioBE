using FluentValidation;
using GitPortfolioBE.Application.ServicesManagers.Abstracts.AuthenticationServices;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Commands.AuthenticationLogin;

public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
{
    private readonly IAuthenticationUserService _authenticationUserService;
    private readonly ILogger<LoginHandler> _logger;
    private readonly IValidator<LoginRequest> _validator;

    public LoginHandler(IAuthenticationUserService authenticationUserService, ILogger<LoginHandler> logger, IValidator<LoginRequest> validator)
    {
        _authenticationUserService = authenticationUserService;
        _logger = logger;
        _validator = validator;
    }

    public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (!validationResult.IsValid)
        {
            _logger.LogWarning("Login validation failed for email: {Email}", request.Email);
            throw new ValidationException(validationResult.Errors);
        }

        // Doğrudan giriş işlemi
        var loginResponse = await _authenticationUserService.LoginUserAsync(request.Email, request.Password);

        _logger.LogInformation("User {Email} successfully logged in.", request.Email);
        return loginResponse;
    }
}
