namespace KixPlay_Backend.Data.Abstractions
{
    public class BaseEntity : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastUpdatedAt { get; set; }
    }
}
