using adduo.elephant.domain.entities.debts.bundlers;
using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts
{
    public class MonthyBundlerItemDebt : ItemDebt
    {
        public virtual List<BundlerItemDebt> BundlerItemDebts { get; set; }

        public MonthyBundlerItemDebt(Guid id, string name, decimal amount,  int dueDay, int inComeId) : base(id, name, amount, dueDay, inComeId)
        {
        }
    }
}
