using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts_template
{
    public class BundlerMonthlyTemplate : DebtTemplate
    {
        public virtual List<DebtTemplate> Debts { get; set; } = new List<DebtTemplate>();

        public BundlerMonthlyTemplate()
        {
            Type = enums.DebtType.bundlerMonthly;
        }
    }
}
