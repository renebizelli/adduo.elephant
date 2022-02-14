using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public class MonthlyRecurrenceBundlerItemDebt : BundlerItemDebt
    {
        public MonthlyRecurrenceBundlerItemDebt(Guid id, string name, decimal amount) : base(id, name, amount)
        {
        }
    }
}
