using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts
{
    public class YearlyRecurrenceItemDebt : ItemDebt
    {
        public int DueMonth { get; private set; }

        public YearlyRecurrenceItemDebt() : base()
        {

        }

        public YearlyRecurrenceItemDebt(Guid id, string name, decimal amount, int dueDay, int inComeId, int dueMonth) : base(id, name, amount, dueDay, inComeId)
        {
            DueMonth = dueMonth;
        }

    }
}
