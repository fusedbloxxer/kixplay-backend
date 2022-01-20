using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IWatchRepository : IGenericRepository<Guid, TrackedMedia>
    {
        public Task<IEnumerable<TMedia>> GetWatchListAsync<TMedia>(Guid userId, IEnumerable<TrackedMedia.WatchStatus> statuses)
            where TMedia : Media;
    }
}
