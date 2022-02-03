using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.requests
{
    public class PontualItemDebtRequest : ItemDebtRequest
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
            Year.AddValidation(new IsAValueLessOrEqualToParamenter(2010));
        }
    }
}
