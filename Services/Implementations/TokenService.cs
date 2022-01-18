using AutoMapper;
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
        // Services
        private readonly IMapper _mapper;
        private readonly ILogger<TokenService> _logger;
        private readonly UserManager<User> _userManager;

        // Configs
        private readonly JwtSettings _jwtSettings;
        private readonly SymmetricSecurityKey _key;
        private readonly TokenValidationParameters _validationParameters;

        public TokenService(
            IOptions<JwtSettings> jwtSettings,
            IOptions<SecretsSettings> secrets,
            UserManager<User> userManager,
            ILogger<TokenService> logger,
            IMapper mapper
        )
        {
            _mapper = mapper;

            _userManager = userManager;
            _logger = logger;
            _jwtSettings = jwtSettings.Value;

            _key = CreateSecurityKey(secrets.Value);

            _validationParameters = CreateValidationParams(_jwtSettings, _key, _mapper);
        }

        public async Task<string> CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
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

        public async Task<bool> IsTokenValid(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return await Task.FromResult(false);

            var jwtTokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var _ = jwtTokenHandler.ValidateToken(token, _validationParameters, out SecurityToken securityToken);

                var jwtToken = (JwtSecurityToken)securityToken;

                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError("The token {token} is invalid: {exception}", token, ex);
                return await Task.FromResult(false);
            }
        }

        private static TokenValidationParameters CreateValidationParams(JwtSettings _jwtSettings, SymmetricSecurityKey key, IMapper mapper)
        {
            var tokenValidationParams = mapper.Map<TokenValidationParameters>(_jwtSettings);

            tokenValidationParams.IssuerSigningKey = key;

            return tokenValidationParams;
        }

        private static SymmetricSecurityKey CreateSecurityKey(SecretsSettings secrets)
        {
            string tokenKey = secrets.Authentication.Jwt.TokenKey;

            byte[] tokenKeyBytes = Encoding.UTF8.GetBytes(tokenKey);

            var key = new SymmetricSecurityKey(tokenKeyBytes);

            return key;
        }
    }
}
