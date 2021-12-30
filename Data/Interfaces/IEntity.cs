﻿namespace KixPlay_Backend.Data.Interfaces
{
    public interface IEntity<TKey> where TKey : IEquatable<TKey>
    {
        public TKey Id { get; set; }
    }
}
