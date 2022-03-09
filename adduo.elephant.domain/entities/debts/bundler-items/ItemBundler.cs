using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public abstract class ItemBundler : Debt
    {

        public virtual items.BundlerMonthly BundlerMonthly { get; set; }
        public Guid BundlerMonthlyId { get; set; }

        public ItemBundler()
        {

        }
        protected ItemBundler(Guid id, string name, Guid bundlerMonthlyId) : base(id, name)
        {
            BundlerMonthlyId = bundlerMonthlyId;
        }
    }
}
