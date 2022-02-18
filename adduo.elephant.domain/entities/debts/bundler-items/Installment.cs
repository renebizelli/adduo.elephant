using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class Installment : Item
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
        public Installment()
        {

        }

        public Installment(Guid id, string name, decimal amount) : base(id, name, amount)
        {
        }
    }
}
