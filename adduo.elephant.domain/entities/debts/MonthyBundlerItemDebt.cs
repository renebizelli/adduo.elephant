using adduo.elephant.domain.entities.debts.bundlers;
using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts
{
    public class MonthyBundlerItemDebt : ItemDebt
    {
        public virtual List<BundlerItemDebt> BundlerItemDebts { get; set; }

        public MonthyBundlerItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status, int inComeId, int dueDay) : base(id, name, value, categoryId, status, inComeId, dueDay)
        {
        }
    }
}
