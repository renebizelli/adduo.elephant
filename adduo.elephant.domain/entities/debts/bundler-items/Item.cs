using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public abstract class Item : Debt
    {
        public decimal Amount { get; set; }

        public virtual items.MonthlyBundler BundlerMonthly { get; set; }
        public Guid BundlerMonthlyId { get; set; }

        public Item()
        {

        }
        protected Item(Guid id, string name, decimal amount, Guid bundlerMonthlyId) : base(id, name)
        {
            Amount = amount;
            BundlerMonthlyId = bundlerMonthlyId;
        }
    }
}
