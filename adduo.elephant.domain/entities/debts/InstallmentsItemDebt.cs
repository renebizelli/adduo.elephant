using System;

namespace adduo.elephant.domain.entities.debts
{
    public class InstallmentsItemDebt : ItemDebt
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }

        public InstallmentsItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status, int inComeId, int dueDay, int startMonth, int startYear, int installments) : base(id, name, value, categoryId, status, inComeId, dueDay)
        {
            StartMonth = startMonth;
            StartYear = startYear;
            Installments = installments;
        }

    }
}
