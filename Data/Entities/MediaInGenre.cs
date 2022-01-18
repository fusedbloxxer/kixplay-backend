using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public class MediaInGenre : BaseEntity
    {
        public Guid GenreId { get; set; }

        public Genre Genre { get; set; }

        public Guid MediaId { get; set; }

        public Media Media { get; set; }
    }
}
