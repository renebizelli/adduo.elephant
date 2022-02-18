using System;

namespace adduo.elephant.domain.entities.debts.items
{
    public class Installment : ItemAmount
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }

        public Installment()
        {

        }

        public Installment(Guid id, string name, decimal amount, int dueDay, int inComeId, int startMonth, int startYear, int installments) : base(id, name, amount, dueDay, inComeId)
        {
            StartMonth = startMonth;
            StartYear = startYear;
            Installments = installments;
        }
            
    }
}
