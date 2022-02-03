using System;

namespace adduo.elephant.domain.entities.debts
{
    public class YearlyRecurrenceItemDebt : ItemDebt
    {
        public int DueMonth { get; private set; }

        public YearlyRecurrenceItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status, int inComeId, int dueDay, int dueMonth) : base(id, name, value, categoryId, status, inComeId, dueDay)
        {
            DueMonth = dueMonth;
        }
    }
}
