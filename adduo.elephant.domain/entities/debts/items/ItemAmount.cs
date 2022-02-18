using System;

namespace adduo.elephant.domain.entities.debts.items
{
    public abstract class ItemAmount : Item
    {
        public decimal Amount { get; set; }

        public ItemAmount()
        {

        }

        public ItemAmount(Guid id, string name, decimal amount, int dueDay, int inComeId) : base(id, name, dueDay, inComeId)
        {
            Amount = amount;
        }
    }
}
