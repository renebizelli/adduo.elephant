namespace adduo.elephant.domain.dtos
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        protected Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
