using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class PontualBundler : ItemAmountBundler
    {
        public int Month { get; private set; }
        public int Year { get; private set; }

        public PontualBundler()
        {

        }

        public PontualBundler(Guid id, string name, decimal amount, int month, int year, Guid bundlerMonthlyId) : base(id, name, amount, bundlerMonthlyId)
        {
            Month = month;
            Year = year;
        }

   
    }
}
