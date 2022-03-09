using System.Collections.Generic;

namespace adduo.elephant.domain.dtos.debts.items
{
    public class BundlerMonthly : Item
    {
        public virtual List<bundler_items.ItemBundler> Items { get; set; }
    }
}
