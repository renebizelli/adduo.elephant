using System;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public class PontualBundlerItemDebt : BundlerItemDebt
    {
        public int Month { get; private set; }
        public int Year { get; private set; }
        public PontualBundlerItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status, int month, int year) : base(id, name, value, categoryId, status)
        {
            Month = month;
            Year = year;
        }

    }
}
