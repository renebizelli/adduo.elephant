using System;

namespace adduo.elephant.domain.entities.debts
{
    public class PontualItemDebt : ItemDebt
    {
        public int Month { get; private set; }
        public int Year { get; private set; }

        public PontualItemDebt(): base()
        {

        }

        public PontualItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status, int inComeId, int dueDay, int month, int year) : base(id, name, value, categoryId, status, inComeId, dueDay)
        {
            Month = month;
            Year = year;
        }
    }
}
