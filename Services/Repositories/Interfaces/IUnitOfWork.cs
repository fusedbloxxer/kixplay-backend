namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRoleRepository UserRoleRepository { get; }

        IMovieRepository MovieRepository { get; }

        IWatchRepository WatchRepository { get; }

        IUserRepository UserRepository { get; }

        IRoleRepository RoleRepository { get; }

        Task CompleteAsync();

        void Dispose();
    }
}
