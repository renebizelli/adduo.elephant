using System;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public class InstallmentsBundlerItemDebt : BundlerItemDebt
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
        public InstallmentsBundlerItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status, int startMonth, int startYear, int installments) : base(id, name, value, categoryId, status)
        {
            StartMonth = startMonth;
            StartYear = startYear;
            Installments = installments;
        }
    }
}
