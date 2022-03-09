using System;

namespace adduo.elephant.domain.dtos.debts.bundler_items
{
    public abstract class ItemBundler : Debt
    {

        public virtual items.BundlerMonthly BundlerMonthly { get; set; }
        public Guid BundlerMonthlyId { get; set; }
    }
}
