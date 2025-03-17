namespace GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Commands.AuthenticationLogin;

public class LoginResponse
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public DateTime Expiration { get; set; }
}
