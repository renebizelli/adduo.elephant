using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts.items
{
    public class MonthlyBundler : Item
    {
        public virtual List<bundler_items.Item> Items { get; set; }

        public MonthlyBundler()
        {

        }

        public MonthlyBundler(Guid id, string name, decimal amount, int dueDay, int inComeId) : base(id, name, dueDay, inComeId)
        {
        }
    }
}
