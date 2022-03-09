using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class ItemAmountBundler : ItemBundler
    {
        public decimal Amount { get; set; }

        public ItemAmountBundler()
        {

        }

        public ItemAmountBundler(Guid id, string name, decimal amount, Guid bundlerMonthlyId) : base(id, name,  bundlerMonthlyId)
        {
            Amount = amount;
        }

    }
}
