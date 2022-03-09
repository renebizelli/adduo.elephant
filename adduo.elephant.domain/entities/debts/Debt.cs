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
        public virtual Category Category { get; set; } 
        public virtual int CategoryId { get; set; }
        public DebtStatuses Status { get; private set; }
        public DateTime CreatedAt { get; set; }

        public virtual List<SpreadSheetItem> SpreadSheetItems { get; private set; } = new List<SpreadSheetItem>();

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
    }
}
