using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class Pontual : Item
    {
        public int Month { get; private set; }
        public int Year { get; private set; }

        public Pontual()
        {

        }

        public Pontual(Guid id, string name, decimal amount, int month, int year) : base(id, name, amount)
        {
            Month = month;
            Year = year;
        }

   
    }
}
