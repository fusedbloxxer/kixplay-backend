using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public partial class RelatedMedia : BaseEntity
    {
        public Relation Relationship { get; set; }

        public Guid? MediaFromId { get; set; }

        public Media MediaFrom { get; set; }

        public Guid? MediaToId { get; set; }

        public Media MediaTo { get; set; }
    }

    public partial class RelatedMedia : BaseEntity
    {
        public enum Relation
        {
            Alternate,
            OVA,
        }
    }
}
