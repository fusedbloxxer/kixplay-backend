using KixPlay_Backend.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Data.Seeders
{
    public static class DatabaseSeeder
    {
        public static async Task Seed(UserManager<User> userManager)
        {
            if (await userManager.Users.AnyAsync())
                return;
        }
    }
}
