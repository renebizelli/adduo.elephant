using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests
{
    public class ItemDebtRequest : DebtRequest
    {
        public DayEntry DueDay { get; set; }
        public IntEntry InComeId { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(DueDay);
            AddEntry(InComeId);
        }

        public override void InitEntries()
        {
            base.InitEntries();

            DueDay = new DayEntry();
            InComeId = new IntEntry();
        }

        public override void AddValidators()
        {
            base.AddValidators();

            InComeId.AddValidation(new IntNotZero());
        }
    }
}
