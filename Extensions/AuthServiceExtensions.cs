using AutoMapper;
using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Implementations;
using KixPlay_Backend.Services.Interfaces;
using KixPlay_Backend.Settings.Application;
using KixPlay_Backend.Settings.Secrets;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace KixPlay_Backend.Extensions
{
    public static class AuthServiceExtensions
    {
        public static void AddAuthServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Retrieve settings from config files
            ReadAuthSettings(
                services,
                configuration,
                out SecretsSettings secretsSettings,
                out JwtSettings jwtSettings
            );

            // Build service provider scope to use mapper dependency
            var serviceProvider = services.BuildServiceProvider();
            var mapper = serviceProvider.GetRequiredService<IMapper>();

            // Configure Jwt Authentication & Authorization
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(jwtOptions =>
                {
                    // Use public settings to configure the validation
                    jwtOptions.TokenValidationParameters = mapper
                        .Map<JwtSettings, TokenValidationParameters>(jwtSettings);

                    // Add the secret key for issuer signature validation
                    var tokenKey = secretsSettings.Authentication.Jwt.TokenKey;
                    var tokenKeyBytes = Encoding.UTF8.GetBytes(tokenKey);
                    var key = new SymmetricSecurityKey(tokenKeyBytes);
                    jwtOptions.TokenValidationParameters.IssuerSigningKey = key;
                });

            // Add and configure the Identity Service
            services
                .AddIdentityCore<User>(identityOptions =>
                {
                    identityOptions.User.RequireUniqueEmail = true;
                    // identityOptions.SignIn.RequireConfirmedEmail = true;
                })
                .AddRoles<Role>()
                .AddRoleManager<RoleManager<Role>>()
                .AddSignInManager<SignInManager<User>>()
                .AddRoleValidator<RoleValidator<Role>>()
                .AddEntityFrameworkStores<DataContext>();

            // Use Jwt to generate tokens for authentication & authorization
            services.AddScoped<ITokenService, TokenService>();
        }

        private static void ReadAuthSettings(IServiceCollection services, IConfiguration configuration, out SecretsSettings secretsSettings, out JwtSettings jwtSettings)
        {
            // https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows
            var secretsSettingsSection = configuration.GetSection(SecretsSettings.SECTION_NAME);
            secretsSettings = secretsSettingsSection.Get<SecretsSettings>();
            services.Configure<SecretsSettings>(secretsSettingsSection);

            // Retrieve JwtSettings from appsettings
            var jwtSettingsSection = configuration.GetSection(JwtSettings.SECTION_NAME);
            jwtSettings = jwtSettingsSection.Get<JwtSettings>();
            services.Configure<JwtSettings>(jwtSettingsSection);
        }
    }
}
