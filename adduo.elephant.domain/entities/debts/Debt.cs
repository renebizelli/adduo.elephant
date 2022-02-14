using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts
{
    public enum DebtStatuses : byte
    {
        Active,
        Inactive
    }

    public class Debt : EntityItem<Guid>
    {
        public decimal Amount { get; set; }
        public virtual List<Tag> Tags { get; set; } = new List<Tag>();
        public DebtStatuses Status { get; private set; }

        public DateTime CreatedAt { get; set; }

        public Debt() : base()
        {

        }

        public Debt(Guid id, string name, decimal amount) : base(id, name)
        {
            Amount = amount;

            Activate();
        }

        public void Activate()
        {
            Status = DebtStatuses.Active;
        }

        public void AddTag(int tagId)
        {
            Tags.Add(new Tag(tagId));
        }
    }
}
