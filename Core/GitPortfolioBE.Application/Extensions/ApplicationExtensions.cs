using FluentValidation;
using GitPortfolioBE.Application.Behaviours;
using GitPortfolioBE.Application.Features.MVerticalSlice.Authentication.Commands.AuthenticationLogin;
using GitPortfolioBE.Application.ServicesManagers.Abstracts.AuthenticationServices;
using GitPortfolioBE.Application.ServicesManagers.Concretes.AuthenticationManagers;
using MediatR;
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

        services.AddTransient<IAuthenticationUserService, AuthenticationUserService>();
        services.AddTransient<IAuthenticationRoleService, AuthenticationRoleService>();

        services.AddValidatorsFromAssembly(assembly);

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

    }
}