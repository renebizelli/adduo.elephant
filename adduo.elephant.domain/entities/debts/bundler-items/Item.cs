using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public abstract class Item : Debt
    {

        public virtual items.MonthlyBundler BundlerMonthly { get; set; }
        public Guid BundlerMonthlyId { get; set; }

        public Item()
        {

        }
        protected Item(Guid id, string name, Guid bundlerMonthlyId) : base(id, name)
        {
            BundlerMonthlyId = bundlerMonthlyId;
        }
    }
}
