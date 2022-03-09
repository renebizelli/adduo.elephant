using adduo.elephant.domain.entities.debts;
using System;

namespace adduo.elephant.domain.entities
{
    public class SpreadSheetItem
    {
        public Guid Id { get; set; }
        public decimal CurrentAmount { get;  set; }
        public decimal PayedAmount { get;  set; }
        public SpreadSheetItemStatuses Status { get;  set; }
        public virtual Guid SpreadSheetId { get;  set; }
        public virtual SpreadSheet SpreadSheet { get;  set; }
        public virtual Guid DebtId { get;  set; }
        public virtual Debt Debt { get;  set; }

        public SpreadSheetItem(decimal currentAmount, decimal payedAmount)
        {
            CurrentAmount = currentAmount;
            PayedAmount = payedAmount;
            //DebtId = debt.Id;
            //Debt = debt;
        }
    }

    public enum SpreadSheetItemStatuses
    {
        Pending,
        Payed
    }
}
