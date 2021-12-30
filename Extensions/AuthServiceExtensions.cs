using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Implementations;
using KixPlay_Backend.Services.Interfaces;
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
            // Retrieve secrets information using Secret Manager:
            // https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows
            var secretsSettingsSection = configuration.GetSection(SecretsSettings.SECTION_NAME);
            var secretsSettings = secretsSettingsSection.Get<SecretsSettings>();
            services.Configure<SecretsSettings>(secretsSettingsSection);

            // Configure Jwt Authentication & Authorization
            services
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
            services
                .AddIdentityCore<User>(identityOptions =>
                {
                    identityOptions.User.RequireUniqueEmail = true;
                    identityOptions.SignIn.RequireConfirmedEmail = true;
                })
                .AddRoles<Role>()
                .AddRoleManager<RoleManager<Role>>()
                .AddSignInManager<SignInManager<User>>()
                .AddRoleValidator<RoleValidator<Role>>()
                .AddEntityFrameworkStores<DataContext>();

            // Use Jwt to generate tokens for authentication & authorization
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}
