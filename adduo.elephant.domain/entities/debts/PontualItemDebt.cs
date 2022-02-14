using System;

namespace adduo.elephant.domain.entities.debts
{
    public class PontualItemDebt : ItemDebt
    {
        public int Month { get; private set; }
        public int Year { get; private set; }

        public PontualItemDebt() : base()
        {

        }

        public PontualItemDebt(Guid id, string name, decimal amount, int dueDay,  int inComeId, int month, int year) : base(id, name, amount, dueDay, inComeId)
        {
            Month = month;
            Year = year;
        }

    }
}
