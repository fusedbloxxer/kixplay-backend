using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IWatchRepository : IGenericRepository<Guid, TrackedMedia>
    {
        public Task<IEnumerable<TMediaModel>> GetWatchListAsync<TMedia, TMediaModel>(Guid userId, IEnumerable<TrackedMedia.WatchStatus> statuses)
            where TMediaModel : MediaModel
            where TMedia : Media;
    }
}
