using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IMediaRepository<TMedia, TMediaModel> : IGenericRepository<Guid, TMedia>
        where TMediaModel : MediaModel
        where TMedia : Media
    {
        Task<IEnumerable<TMediaModel>> GetAllDetailsAsync();

        Task<TMediaModel> GetByIdWithDetailsAsync(Guid id);
    }
}
