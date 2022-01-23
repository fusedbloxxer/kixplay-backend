namespace KixPlay_Backend.Models.Implementations
{
    public class MediaSourcesModel : BaseModel
    {
        public ProviderModel Provider { get; set; }

        public IEnumerable<MediaSourceModel> Sources { get; set; }
    }
}
