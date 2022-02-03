using adduo.elephant.domain.entities.debts;
using System;

namespace adduo.elephant.domain.entities
{
    public class SpreadSheetItem
    {
        public Guid Id { get; set; }
        public double CurrentValue { get; private set; }
        public double PayedValue { get; private set; }
        public SpreadSheetItemStatuses Status { get; private set; }
        public Guid SpreadSheetId { get; private set; }
        public virtual SpreadSheet SpreadSheet { get; private set; }
        public Guid ItemDebtId { get; private set; }
        public virtual ItemDebt ItemDebt { get; private set; }
    }

    public enum SpreadSheetItemStatuses
    {
        Pending,
        Payed
    }
}
