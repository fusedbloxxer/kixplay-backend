using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Implementations;
using KixPlay_Backend.Services.Interfaces;
using KixPlay_Backend.Settings.Secrets;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// My Services
// Retrieve secrets information using Secret Manager:
// https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows
var secretsSettingsSection = builder.Configuration.GetSection(SecretsSettings.SECTION_NAME);

// Bind the settings to resolve other dependencies
var secretsSettings = secretsSettingsSection.Get<SecretsSettings>();

// Add the secrets settings section to the DI
builder.Services.Configure<SecretsSettings>(secretsSettingsSection);

// Configure the connection to the database by specifying the connection string
builder.Services.AddDbContext<DataContext>(contextOptions =>
{
    contextOptions.UseSqlServer(
        builder.Configuration.GetConnectionString("KixPlayDatabaseConnection")
    );
});

// Configure Jwt Authentication & Authorization
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(jwtOptions =>
    {
        var tokenKey = secretsSettings.Authentication.Jwt.TokenKey;

        var tokenKeyBytes = Encoding.UTF8.GetBytes(tokenKey);

        jwtOptions.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            IssuerSigningKey = new SymmetricSecurityKey(tokenKeyBytes),
            ValidateIssuerSigningKey = true,
            ValidateAudience = false,
            ValidateIssuer = false,
        };
    });

// Add and configure the Identity Service
builder.Services
    .AddIdentityCore<User>(identityOptions =>
    {
        // TODO: Adjust identity options
        identityOptions.Password.RequireNonAlphanumeric = false;
    })
    .AddRoles<Role>()
    .AddRoleManager<RoleManager<Role>>()
    .AddSignInManager<SignInManager<User>>()
    .AddRoleValidator<RoleValidator<Role>>()
    .AddEntityFrameworkStores<DataContext>();

// Use Jwt to generate tokens for authentication & authorization
builder.Services.AddScoped<ITokenService, TokenService>();

// Build the application using the configured services
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
