using System;

namespace adduo.elephant.domain.entities
{
    public abstract class Entity<T>
    {
        public Entity()
        {

        }
        protected Entity(T id)
        {
            Id = id;
        }

        public T Id { get; protected set; }
    }
}
