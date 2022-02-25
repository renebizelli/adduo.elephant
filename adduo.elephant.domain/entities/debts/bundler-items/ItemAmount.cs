using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class ItemAmount : Item
    {
        public decimal Amount { get; set; }

        public ItemAmount()
        {

        }

        public ItemAmount(Guid id, string name, decimal amount, Guid bundlerMonthlyId) : base(id, name,  bundlerMonthlyId)
        {
            Amount = amount;
        }

    }
}
