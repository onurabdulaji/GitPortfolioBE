using MediatR;
using System.ComponentModel;

namespace GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Commands.AuthenticationLogin;

public class LoginRequest : IRequest<LoginResponse>
{
    public string Email { get; set; }
    [DefaultValue("Admin123!@#")]
    public string Password { get; set; }
}
