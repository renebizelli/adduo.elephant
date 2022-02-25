using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class Pontual : ItemAmount
    {
        public int Month { get; private set; }
        public int Year { get; private set; }

        public Pontual()
        {

        }

        public Pontual(Guid id, string name, decimal amount, int month, int year, Guid bundlerMonthlyId) : base(id, name, amount, bundlerMonthlyId)
        {
            Month = month;
            Year = year;
        }

   
    }
}
