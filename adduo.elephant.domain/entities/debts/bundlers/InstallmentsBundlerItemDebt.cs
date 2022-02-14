using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public class InstallmentsBundlerItemDebt : BundlerItemDebt
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }

        public InstallmentsBundlerItemDebt(Guid id, string name, decimal amount) : base(id, name, amount)
        {
        }
    }
}
