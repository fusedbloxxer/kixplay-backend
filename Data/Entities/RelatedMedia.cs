using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public partial class RelatedMedia : BaseEntity
    {
        public Relation Relationship { get; set; }

        public Media Previous { get; set; }

        public Media Next { get; set; }
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
