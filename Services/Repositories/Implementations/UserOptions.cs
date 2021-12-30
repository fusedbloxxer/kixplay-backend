using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class UserOptions
    {
        public IEnumerable<Role> Roles { get; set; }

        public string Password { get; set; }
    }
}
