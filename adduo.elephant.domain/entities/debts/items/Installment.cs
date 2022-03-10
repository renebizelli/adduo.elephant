using adduo.elephant.domain.contracts.entities;
using adduo.elephant.domain.extensions;
using System;

namespace adduo.elephant.domain.entities.debts.items
{
    public class Installment : ItemAmount, IInstallment
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
        public int StartPeriod { get; private set; }
        public int FinishPeriod { get; private set; }

        public Installment()
        {

        }

        public Installment(Guid id, string name, decimal amount, int dueDay, int inComeId, int startMonth, int startYear, int installments) : base(id, name, amount, dueDay, inComeId)
        {
            StartMonth = startMonth;
            StartYear = startYear;
            Installments = installments;
        }

        public void SetPeriod()
        {
            StartPeriod = this.GetStartPeriod();
            FinishPeriod = this.GetFinishPeriod();
        }
    }
}
