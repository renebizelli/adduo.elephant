using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class Monthly : Item
    {
        public Monthly()
        {

        }

        public Monthly(Guid id, string name, decimal amount) : base(id, name, amount)
        { }
    }
}
