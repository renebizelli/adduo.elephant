namespace adduo.elephant.domain.entities
{
    public abstract class EntityItem<T> : Entity<T>
    {
        public string Name { get; protected set; }
    }
}
