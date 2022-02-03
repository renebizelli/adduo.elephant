using System;

namespace adduo.elephant.domain.entities
{
    public abstract class Entity<T>
    {
        public T Id { get; private set; }

        public Entity()
        {

        }

        protected Entity(T id)
        {
            Id = id;
        }
    }
}
