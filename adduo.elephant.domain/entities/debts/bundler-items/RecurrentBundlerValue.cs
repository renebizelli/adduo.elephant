using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class RecurrentBundlerValue : Entity<int>
    {
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public virtual RecurrentBundler Recurrent { get; set; }
        public virtual Guid RecurrentId { get; set; }

        public RecurrentBundlerValue()
        {

        }

        public RecurrentBundlerValue(string description, decimal value)
        {
            CreatedAt = DateTime.Now;
            Description = description;
            Amount = value;
        }

        public RecurrentBundlerValue(string description, decimal value, Guid recurrentId) : this(description, value)
        {
            RecurrentId = recurrentId;
        }

    }
}
