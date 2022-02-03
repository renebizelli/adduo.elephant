using System;

namespace adduo.elephant.domain.entities.debts
{
    public class MonthlyRecurrenceItemDebt : ItemDebt
    {
        public MonthlyRecurrenceItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status, int inComeId, int dueDay) : base(id, name, value, categoryId, status, inComeId, dueDay)
        {
        }
    }
}
