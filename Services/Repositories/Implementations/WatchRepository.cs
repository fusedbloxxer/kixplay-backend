using AutoMapper;
using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Mappers.Helpers;
using KixPlay_Backend.Models.Abstractions;
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

        public async Task<TrackedMedia> FindAsync(Guid userId, Guid mediaId)
        {
            var TrackedMedias = _dbSet;

            var query = from trackedMedia in TrackedMedias
                        where trackedMedia.UserId == userId && trackedMedia.MediaId == mediaId
                        select trackedMedia;

            query = query
                .Include(trackedMedia => trackedMedia.Media)
                .Include(trackedMedia => trackedMedia.User);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TMediaWatch>> GetWatchListAsync<TMedia, TMediaWatch>(Guid userId, IEnumerable<TrackedMedia.WatchStatus> statuses)
            where TMediaWatch : IMediaWatchStatusModel
            where TMedia : Media
        {
            // Give tables an alias
            var TrackedMedias = _context.Set<TrackedMedia>();
            var Medias = _context.Set<TMedia>();

            // Get the movies watched by a user
            // Along with their status
            var query = from tm in TrackedMedias
                        where tm.UserId == userId && statuses.Contains(tm.Status)
                        join media in Medias on tm.MediaId equals media.Id
                        orderby tm.LastUpdatedAt descending, tm.CreatedAt descending
                        select new MediaWithStatusHelper<TMedia>
                        {
                            Media = media,
                            WatchingStatus = tm.Status,
                        };

            // Transform to corresponding output
            var mediaModels = query.Select(x => _mapper.Map<TMediaWatch>(x)).ToList();

            // Perform the query and return the result
            return await Task.FromResult(mediaModels);
        }
    }
}
