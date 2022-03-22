using adduo.elephant.domain.contracts.entities;
using adduo.elephant.domain.extensions;

namespace adduo.elephant.domain.entities.debts_template
{
    public class InstallmentTemplate : DebtAmountTemplate, IInstallment
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
        public int StartPeriod { get; private set; }
        public int FinishPeriod { get; private set; }

        public InstallmentTemplate()
        {
            Type = enums.DebtType.installment;
        }

        public decimal GetInstallmentValue()
        {
            decimal value = 0;

            if(Installments > 0)
            {
                value = Amount / Installments;
            }

            return value;
        }

        public void SetPeriod()
        {
            StartPeriod = this.GetStartPeriod();
            FinishPeriod = this.GetFinishPeriod();
        }

    }
}
