using adduo.elephant.domain.dtos.debts;
using System;

namespace adduo.elephant.domain.dtos
{
    public class SpreadSheetItem 
    {
        public Guid Id { get; set; }
        public decimal CurrentAmount { get;  set; }
        public decimal PayedAmount { get;  set; }
        public int Status { get;  set; }
        public Debt Debt { get;  set; }
    }
}
