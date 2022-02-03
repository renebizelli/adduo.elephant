namespace adduo.elephant.domain.entities
{
    public abstract class EntityItem<T> : Entity<T>
    {
        public string Name { get; private set; }

        public EntityItem() : base()
        {

        }

        protected EntityItem(T id, string name) : base(id)
        {
            Name = name;
        }

    }
}
