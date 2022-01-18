using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Medium> Medias { get; set; }
    }
}
