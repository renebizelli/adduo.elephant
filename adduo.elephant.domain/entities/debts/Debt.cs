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
        public decimal Value { get; protected set; }
        public virtual ICollection<Tag> Tags { get; private set; }
        public DebtStatuses Status { get; private set; }

        public void Activate()
        {
            Status = DebtStatuses.Active;
        }
    }
}
