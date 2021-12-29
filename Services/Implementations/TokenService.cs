using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Interfaces;
using KixPlay_Backend.Settings.Secrets;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KixPlay_Backend.Services.Implementations
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _key;

        public TokenService(IOptions<SecretsSettings> secrets)
        {
            string tokenKey = secrets.Value.Authentication.Jwt.TokenKey;

            byte[] tokenKeyBytes = Encoding.UTF8.GetBytes(tokenKey);

            _key = new SymmetricSecurityKey(tokenKeyBytes);
        }

        public async Task<string> CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId, user.Id)
            };

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
