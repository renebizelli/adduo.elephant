using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class YearlyBundler : ItemAmountBundler
    {
        public int DueMonth { get; private set; }

        public YearlyBundler()
        {

        }

        public YearlyBundler(Guid id, string name, decimal amount, int dueMonth, Guid bundlerMonthlyId) : base(id, name, amount, bundlerMonthlyId)
        {
            DueMonth = dueMonth;
        }

    }
}
