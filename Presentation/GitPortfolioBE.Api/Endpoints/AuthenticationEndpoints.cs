using GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Commands.AuthenticationLogin;
using MediatR;

namespace GitPortfolioBE.Api.Endpoints;

public class AuthenticationEndpoints
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/auth/login", async (LoginRequest command, ISender sender) =>
        {
            var response = await sender.Send(command);
            return Results.Ok(response);
        });
    }
}
