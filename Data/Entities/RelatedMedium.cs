using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public class RelatedMedium : BaseEntity
    {
        public Medium First { get; set; }

        public Medium Second { get; set; }
    }
}
