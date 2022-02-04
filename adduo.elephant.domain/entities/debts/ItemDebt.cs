using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts
{
    public class ItemDebt : Debt
    {
        public int DueDay { get; private set; }
        public virtual InCome InCome { get; private set; }
        public int InComeId { get; private set; }

        public virtual List<SpreadSheetItem> Items { get; private set; } = new List<SpreadSheetItem>();
    }
}
