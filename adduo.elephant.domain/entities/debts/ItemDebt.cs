using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts
{
    public class ItemDebt : Debt
    {
        public int DueDay { get; private set; }
        public virtual InCome InCome { get; private set; }
        public int InComeId { get; private set; }

        public virtual List<SpreadSheetItem> Items { get; private set; } = new List<SpreadSheetItem>();

        public ItemDebt() : base()
        {

        }

        public ItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status, int inComeId, int dueDay) : base(id, name, value, categoryId, status)
        {
            InComeId = inComeId;
            DueDay = dueDay;
        }
    }
}
