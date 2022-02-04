using System;

namespace adduo.elephant.domain.entities
{
    public abstract class Entity<T>
    {
        public T Id { get; protected set; }
    }
}
