using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
