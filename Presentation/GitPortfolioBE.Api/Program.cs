using GitPortfolioBE.Api.Endpoints;
using GitPortfolioBE.Application.Extensions;
using GitPortfolioBE.Infastructure.Extensions;
using GitPortfolioBE.Persistence.Extensions;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddInfastructureLayer(builder.Configuration);
builder.Services.AddApplicationLayer(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen
(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Web Portfolio", Version = "v1", Description = "Web Portfolio swagger client." });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "'Bearer' yaz�p bo�luk b�rakt�ktan sonra Token'� Girebilirsiniz \r\n\r\n �rne�in: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\""
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
{
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }

});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
var authEndpoints = new AuthenticationEndpoints();
authEndpoints.AddRoutes(app);
app.UseAuthorization();

app.MapControllers();

app.Run();
