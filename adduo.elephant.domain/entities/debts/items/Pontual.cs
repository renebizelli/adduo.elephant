using System;

namespace adduo.elephant.domain.entities.debts.items
{
    public class Pontual : ItemAmount
    {
        public int Month { get; private set; }
        public int Year { get; private set; }

        public Pontual()  
        {

        }

        public Pontual(Guid id, string name, decimal amount, int dueDay,  int inComeId, int month, int year) : base(id, name, amount, dueDay, inComeId)
        {
            Month = month;
            Year = year;
        }

    }
}
