using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class MonthlyBundler : ItemAmountBundler
    {
        public MonthlyBundler()
        {

        }

        public MonthlyBundler(Guid id, string name, decimal amount, Guid bundlerMonthlyId) : base(id, name, amount, bundlerMonthlyId)
        { }
    }
}
