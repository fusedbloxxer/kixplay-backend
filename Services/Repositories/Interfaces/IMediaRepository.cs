using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IMediaRepository<TMedia> : IGenericRepository<Guid, TMedia>
        where TMedia : Media
    {
    }
}
