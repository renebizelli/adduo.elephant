using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class RecurrentValue : Entity<int>
    {
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }

        public virtual Recurrent Recurrent { get; set; }
        public virtual Guid RecurrentId { get; set; }
    }
}
