using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public class Source : BaseEntity
    {
        public ICollection<Medium> Mediums { get; set; }
    }
}
