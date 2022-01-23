namespace KixPlay_Backend.Models
{
    public class MediaSourcesModel : BaseModel
    {
        public ProviderModel Provider { get; set; }

        public IEnumerable<string> Urls { get; set; }
    }
}
