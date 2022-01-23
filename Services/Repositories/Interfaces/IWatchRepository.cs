using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models.Abstractions;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IWatchRepository : IGenericRepository<Guid, TrackedMedia>
    {
        public Task<IEnumerable<TMediaWatch>> GetWatchListAsync<TMedia, TMediaWatch>(Guid userId, IEnumerable<TrackedMedia.WatchStatus> statuses)
            where TMediaWatch : IMediaWatchStatusModel
            where TMedia : Media;

        public Task<TrackedMedia> FindAsync(Guid userId, Guid mediaId);
    }
}
