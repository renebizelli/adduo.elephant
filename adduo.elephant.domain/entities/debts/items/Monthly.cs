using System;

namespace adduo.elephant.domain.entities.debts.items
{
    public class Monthly : ItemAmount
    {
        public Monthly()
        { 
        }

        public Monthly(Guid id, string name, decimal amount,  int dueDay, int inComeId) : base(id, name, amount, dueDay, inComeId)
        {
        }
    }
}
