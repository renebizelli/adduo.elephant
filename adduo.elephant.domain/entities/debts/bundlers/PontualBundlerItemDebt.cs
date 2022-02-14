using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public class PontualBundlerItemDebt : BundlerItemDebt
    {
        public int Month { get; private set; }
        public int Year { get; private set; }

        public PontualBundlerItemDebt(Guid id, string name, decimal amount, int month, int year) : base(id, name, amount)
        {
            Month = month;
            Year = year;
        }

   
    }
}
