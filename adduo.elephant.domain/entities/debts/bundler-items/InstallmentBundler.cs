using adduo.elephant.domain.contracts.entities;
using adduo.elephant.domain.extensions;
using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class InstallmentBundler : ItemAmountBundler, IInstallment
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
        public int StartPeriod { get; private set; }
        public int FinishPeriod { get; private set; }

        public InstallmentBundler()
        {

        }

        public InstallmentBundler(Guid id, string name, decimal amount, Guid bundlerMonthlyId, int startMonth, int startYear, int installments) : base(id, name, amount, bundlerMonthlyId)
        {
            StartMonth = startMonth;
            StartYear = startYear;
            Installments = installments;
        }

        public void SetPeriod()
        {
            StartPeriod = this.GetStartPeriod();
            FinishPeriod = this.GetFinishPeriod();
        }
    }
}
