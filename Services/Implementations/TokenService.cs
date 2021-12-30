using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Interfaces;
using KixPlay_Backend.Settings.Application;
using KixPlay_Backend.Settings.Secrets;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KixPlay_Backend.Services.Implementations
{
    public class TokenService : ITokenService
    {
        private readonly JwtSettings _jwtSettings;

        private readonly SymmetricSecurityKey _key;
        
        private readonly UserManager<User> _userManager;

        public TokenService(
            IOptions<JwtSettings> jwtSettings,
            IOptions<SecretsSettings> secrets,
            UserManager<User> userManager
        ) {
            string tokenKey = secrets.Value.Authentication.Jwt.TokenKey;

            byte[] tokenKeyBytes = Encoding.UTF8.GetBytes(tokenKey);

            _key = new SymmetricSecurityKey(tokenKeyBytes);

            _jwtSettings = jwtSettings.Value;
            
            _userManager = userManager;
        }

        public async Task<string> CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId, user.Id),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
            };

            var roles = await _userManager.GetRolesAsync(user);

            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = creds,
                Issuer = _jwtSettings.ValidIssuer,
                Audience = _jwtSettings.ValidAudience,
                Expires = DateTime.Now.AddDays(7),
                IssuedAt = DateTime.Now,
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
