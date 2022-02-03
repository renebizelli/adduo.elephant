using System;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public class MonthlyRecurrenceBundlerItemDebt : BundlerItemDebt
    {
        public MonthlyRecurrenceBundlerItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status) : base(id, name, value, categoryId, status)
        {
        }
    }
}
