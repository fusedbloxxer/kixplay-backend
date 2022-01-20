using AutoMapper;
using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class WatchRepository : GenericRepository<Guid, TrackedMedia, DataContext>, IWatchRepository
    {
        public WatchRepository(
            DataContext context,
            ILogger logger,
            IMapper mapper
        ) : base(context, logger, mapper)
        { }

        public async Task<IEnumerable<TMedia>> GetWatchListAsync<TMedia>(Guid userId, IEnumerable<TrackedMedia.WatchStatus> statuses) where TMedia : Media
        {
            // TODO: Write with LINQ
            var trackedMedias = _context.Set<TrackedMedia>();

            IEnumerable<TrackedMedia> filteredTrackedMedias = await trackedMedias.ToListAsync();

            filteredTrackedMedias = filteredTrackedMedias
                .Where(trackedMedia => statuses.AsQueryable().Contains(trackedMedia.Status))
                .Where(trackedMedia => trackedMedia.UserId == userId);

            var medias = await _context.Set<TMedia>().ToListAsync();

            var filteredMedias = medias.Where(media => filteredTrackedMedias.Any(trackedMedia => trackedMedia.MediaId == media.Id));

            return filteredMedias;
        }
    }
}
