using adduo.elephant.domain.enums;
using System;

namespace adduo.elephant.domain.entities.debts_template
{
    public abstract class DebtTemplate : EntityItem<Guid>
    {
        public DateTime CreatedAt { get; set; }
        public int DueDay { get; set; }
        public DebtStatuses Status { get; set; }

        public DebtType Type { get; set; }

        public virtual Category Category { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual BundlerMonthlyTemplate BundlerMonthlyTemplate { get; set; }
        public virtual Guid? BundlerTemplateId { get; set; }

        //public virtual List<SpreadSheetItem> SpreadSheetItems { get;  set; } = new List<SpreadSheetItem>();

        public void Activate()
        {
            Status = DebtStatuses.Active;
        }

    }
}
