using AutoMapper;
using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class MediaRepository<TMedia, TMediaModel> : GenericRepository<Guid, TMedia, DataContext>, IMediaRepository<TMedia, TMediaModel>
        where TMediaModel : MediaModel
        where TMedia : Media
    {
        public MediaRepository(
            DataContext context,
            ILogger logger,
            IMapper mapper
        ) : base(context, logger, mapper)
        { }

        public async Task<IEnumerable<TMediaModel>> GetAllDetailsAsync()
        {
            // Give the tables some aliases
            var MediaSources = _context.Set<MediaSource>();
            var InGenres = _context.Set<MediaInGenre>();
            var Providers = _context.Set<Provider>();
            var Genres = _context.Set<Genre>();
            var Medias = _dbSet;

            // Get medias along with their genres and sources
            var query = Medias
                .ToList()
                .Select(media =>
                {
                    var mediaModel = _mapper.Map<TMediaModel>(media);

                    mediaModel.Genres = (from inGenre in InGenres
                                         where inGenre.MediaId == media.Id
                                         join genre in Genres on inGenre.GenreId equals genre.Id
                                         select genre.Name);

                    mediaModel.Sources = (from mediaSource in MediaSources
                                          where mediaSource.MediaId == media.Id
                                          join provider in Providers on mediaSource.ProviderId equals provider.Id
                                          group mediaSource by provider.Id into grouping
                                          select new MediaSourcesModel
                                          {
                                              Provider = (from provider in Providers
                                                          where provider.Id == grouping.Key
                                                          select _mapper.Map<ProviderModel>(provider)).First(),
                                              Urls = from mediaSource in grouping
                                                     select mediaSource.Url
                                          });

                    return mediaModel;
                });

            // Return the result
            return await Task.FromResult(query);
        }

        public async Task<TMediaModel> GetByIdWithDetailsAsync(Guid id)
        {
            // Give the tables some aliases
            var MediaSources = _context.Set<MediaSource>();
            var InGenres = _context.Set<MediaInGenre>();
            var Providers = _context.Set<Provider>();
            var Genres = _context.Set<Genre>();
            var Medias = _dbSet;

            // Get model by id
            var mediaModel = (from media in Medias
                              where media.Id == id
                              select _mapper.Map<TMediaModel>(media)).FirstOrDefault();

            // Get its genres
            mediaModel.Genres = (from inGenre in InGenres
                                 where inGenre.MediaId == id
                                 join genre in Genres on inGenre.GenreId equals genre.Id
                                 select genre.Name);

            // Get its sources
            mediaModel.Sources = (from mediaSource in MediaSources
                                  where mediaSource.MediaId == id
                                  join provider in Providers on mediaSource.ProviderId equals provider.Id
                                  group mediaSource by provider.Id into grouping
                                  select new MediaSourcesModel
                                  {
                                      Provider = (from provider in Providers
                                                  where provider.Id == grouping.Key
                                                  select _mapper.Map<ProviderModel>(provider)).First(),
                                      Urls = from mediaSource in grouping
                                             select mediaSource.Url
                                  });

            // Return the result
            return await Task.FromResult(mediaModel);
        }
    }
}
