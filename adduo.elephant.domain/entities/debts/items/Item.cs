using System;

namespace adduo.elephant.domain.entities.debts.items
{
    public abstract class Item : Debt
    {
        public int DueDay { get; private set; }
        public virtual InCome InCome { get; private set; }
        public int InComeId { get; private set; }

        public Item() : base()
        {

        }

        public Item(Guid id, string name, int dueDay, int inComeId) : base(id, name)
        {
            DueDay = dueDay;
            InComeId = inComeId;
        }
    }
}
