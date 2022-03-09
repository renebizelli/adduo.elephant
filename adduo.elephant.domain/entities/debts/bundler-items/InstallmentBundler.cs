using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class InstallmentBundler : ItemAmountBundler
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
        public InstallmentBundler()
        {

        }

        public InstallmentBundler(Guid id, string name, decimal amount, Guid bundlerMonthlyId) : base(id, name, amount, bundlerMonthlyId)
        {
        }
    }
}
