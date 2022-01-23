using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models.Abstractions;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IMediaRepository<TMedia, TMediaModel> : IGenericRepository<Guid, TMedia>
        where TMediaModel : IMediaDetailsModel
        where TMedia : Media
    {
        Task<IEnumerable<TMediaModel>> GetAllDetailsAsync();

        Task<TMediaModel> GetByIdWithDetailsAsync(Guid id);
    }
}
