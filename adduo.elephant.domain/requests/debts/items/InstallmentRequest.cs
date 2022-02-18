using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests.debts.items
{
    public class InstallmentRequest : ItemAmountRequest
    {
        public MonthEntry StartMonth { get; set; }
        public IntEntry StartYear { get; set; }
        public IntEntry Installments { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(StartMonth);
            AddEntry(StartYear);
            AddEntry(Installments);
        }

        public override void InitEntries()
        {
            base.InitEntries();

            StartMonth = new MonthEntry();
            StartYear = new IntEntry();
            Installments = new IntEntry();
        }

        public override void AddValidators()
        {
            base.AddValidators();

            StartYear.AddValidation(new IsAValueLessOrEqualToParamenter(DateTime.Now.Year - 1));
        }
    }
}
