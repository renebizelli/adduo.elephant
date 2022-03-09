using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts.items
{
    public class BundlerMonthly : Item
    {
        public virtual List<bundler_items.ItemBundler> Items { get; set; }

        public BundlerMonthly()
        {

        }

        public BundlerMonthly(Guid id, string name, decimal amount, int dueDay, int inComeId) : base(id, name, dueDay, inComeId)
        {
        }
    }
}
