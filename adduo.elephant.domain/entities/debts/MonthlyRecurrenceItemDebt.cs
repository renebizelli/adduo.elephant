using System;

namespace adduo.elephant.domain.entities.debts
{
    public class MonthlyRecurrenceItemDebt : ItemDebt
    {
        public MonthlyRecurrenceItemDebt() : base()
        {

        }

        public MonthlyRecurrenceItemDebt(Guid id, string name, decimal amount,  int dueDay, int inComeId) : base(id, name, amount, dueDay, inComeId)
        {
        }
    }
}
