using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests.debts_template
{
    public class PontualTemplateRequest : DebtAmountTemplateRequest
    {
        public MonthEntry DueMonth { get; set; }
        public IntEntry DueYear { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(DueMonth);
            AddEntry(DueYear);
        }

        public override void InitEntries()
        {
            base.InitEntries();

            DueMonth = new MonthEntry();
            DueYear = new IntEntry();
        }

        public override void AddValidators()
        {
            base.AddValidators();
            DueYear.AddValidation(new IsAValueLessOrEqualToParamenter(DateTime.Now.Year - 1));
        }
    }
}
