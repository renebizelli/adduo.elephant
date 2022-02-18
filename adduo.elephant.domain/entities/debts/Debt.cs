using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts
{
    public enum DebtStatuses : byte
    {
        Active,
        Inactive
    }

    public abstract class Debt : EntityItem<Guid>
    {
        public virtual List<Tag> Tags { get; set; } = new List<Tag>();
        public DebtStatuses Status { get; private set; }
        public DateTime CreatedAt { get; set; }
        public Debt()
        {

        }

        public Debt(Guid id, string name) : base(id, name)
        {
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
