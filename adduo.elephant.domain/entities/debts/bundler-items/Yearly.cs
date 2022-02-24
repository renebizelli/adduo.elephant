using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class Yearly : Item
    {
        public int DueMonth { get; private set; }

        public Yearly()
        {

        }

        public Yearly(Guid id, string name, decimal amount, int dueMonth, Guid bundlerMonthlyId) : base(id, name, amount, bundlerMonthlyId)
        {
            DueMonth = dueMonth;
        }

    }
}
