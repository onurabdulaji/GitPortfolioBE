﻿using GitPortfolioBE.Application.Interfaces.IServices.Tokens;
using GitPortfolioBE.Infastructure.Managers.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace GitPortfolioBE.Infastructure.Extensions;

public static class InfastructureExtension
{
    public static void AddInfastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<TokenSettings>(configuration.GetSection("JWT"));
        services.AddTransient<ITokenService, TokenService>();

        services.AddAuthentication(opt =>
        {
            opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opt =>
        {
            opt.SaveToken = true;
            opt.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"])),
                ValidateLifetime = false,
                ValidIssuer = configuration["JWT:Issuer"],
                ValidAudience = configuration["JWT:Audience"],
                ClockSkew = TimeSpan.Zero
            };
        });
    }
}
