using AutoMapper;
using KixPlay_Backend.Data;
using KixPlay_Backend.Services.Repositories.Interfaces;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DataContext _context;

        public IUserRepository UserRepository { get; }

        public IRoleRepository RoleRepository { get; }

        public IMovieRepository MovieRepository { get; }

        public IWatchRepository WatchRepository { get; }

        public IUserRoleRepository UserRoleRepository { get; }

        public UnitOfWork(
            IUserRoleRepository userRoleRepository,
            IRoleRepository roleRepository,
            IUserRepository userRepository,
            ILogger<UnitOfWork> logger,
            DataContext context,
            IMapper mapper
        ) {
            // Retain single context
            _context = context;

            // Create repositories
            MovieRepository = new MovieRepository(_context, logger, mapper);
            WatchRepository = new WatchRepository(_context, logger, mapper);

            // Group self-managed repositories
            UserRoleRepository = userRoleRepository;
            RoleRepository = roleRepository;
            UserRepository = userRepository;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
