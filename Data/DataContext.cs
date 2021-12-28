using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }
    }
}
