using System;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public class YearlyRecurrenceBundlerItemDebt : BundlerItemDebt
    {
        public int DueMonth { get; private set; }

        public YearlyRecurrenceBundlerItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status, int dueMonth) : base(id, name, value, categoryId, status)
        {
            DueMonth = dueMonth;
        }
    }
}
