using System;

namespace adduo.elephant.domain.entities.debts.items
{
    public class Yearly : ItemAmount
    {
        public int DueMonth { get; private set; }

        public Yearly()  
        {

        }

        public Yearly(Guid id, string name, decimal amount, int dueDay, int inComeId, int dueMonth) : base(id, name, amount, dueDay, inComeId)
        {
            DueMonth = dueMonth;
        }
    }
}
