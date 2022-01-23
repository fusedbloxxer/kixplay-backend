using static KixPlay_Backend.Data.Entities.Provider;

namespace KixPlay_Backend.Models.Implementations
{
    public class ProviderModel : BaseModel
    {
        public Guid Id { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ThumbnailUrl { get; set; }

        public Reliability? Reliable { get; set; }
    }
}
