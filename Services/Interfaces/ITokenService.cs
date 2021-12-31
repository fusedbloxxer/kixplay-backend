using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(User user);

        Task<bool> IsTokenValid(string token);
    }
}
