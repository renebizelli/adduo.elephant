using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class RecurrentValue : Entity<int>
    {
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public virtual Recurrent Recurrent { get; set; }
        public virtual Guid RecurrentId { get; set; }

        public RecurrentValue()
        {

        }

        public RecurrentValue(string description, decimal value)
        {
            CreatedAt = DateTime.Now;
            Description = description;
            Amount = value;
        }

        public RecurrentValue(string description, decimal value, Guid recurrentId) : this(description, value)
        {
            RecurrentId = recurrentId;
        }

    }
}
