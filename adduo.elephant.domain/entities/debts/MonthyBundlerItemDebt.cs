using adduo.elephant.domain.entities.debts.bundlers;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts
{
    public class MonthyBundlerItemDebt : ItemDebt
    {
        public virtual List<BundlerItemDebt> BundlerItemDebts { get; set; }
    }
}
