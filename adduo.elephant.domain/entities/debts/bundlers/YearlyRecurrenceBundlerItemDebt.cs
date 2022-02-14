using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public class YearlyRecurrenceBundlerItemDebt : BundlerItemDebt
    {
        public int DueMonth { get; private set; }

        public YearlyRecurrenceBundlerItemDebt(Guid id, string name, decimal amount, int dueMonth) : base(id, name, amount)
        {
            DueMonth = dueMonth;
        }

    }
}
