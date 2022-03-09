using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests.debts.bundler_items
{
    public class PontualBundlerRequest : ItemAmountBundlerRequest
    {
        public MonthEntry Month { get; set; }
        public IntEntry Year { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(Month);
            AddEntry(Year);
        }

        public override void InitEntries()
        {
            base.InitEntries();

            Month = new MonthEntry();
            Year = new IntEntry();
        }

        public override void AddValidators()
        {
            base.AddValidators();
            Year.AddValidation(new IsAValueLessOrEqualToParamenter(DateTime.Now.Year - 1));
        }
    }
}
