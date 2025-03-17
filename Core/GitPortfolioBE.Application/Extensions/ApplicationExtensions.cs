using GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Rules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GitPortfolioBE.Application.Extensions;

public static class ApplicationExtension
{
    public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

        services.AddTransient<AuthenticationRules>();

    }
}