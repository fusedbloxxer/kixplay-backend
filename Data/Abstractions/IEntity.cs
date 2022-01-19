namespace KixPlay_Backend.Data.Abstractions
{
    public interface IEntity<TKey> where TKey : IEquatable<TKey>
    {
        public TKey Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastUpdatedAt { get; set; }
    }
}
