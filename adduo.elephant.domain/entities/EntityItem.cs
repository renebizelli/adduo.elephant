namespace adduo.elephant.domain.entities
{
    public abstract class EntityItem<T> : Entity<T>
    {
        public string Name { get; protected set; }

        public EntityItem()
        {

        }

        public EntityItem(T id, string name) : base(id)
        {
            Name = name;
        }

        public EntityItem(T id) : base(id)
        {
        }

    }
}
