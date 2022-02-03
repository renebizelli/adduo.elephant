using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.requests
{
    public class ItemDebtRequest : DebtRequest
    {
        public Guid Id { get; set; }
        public String64Entry Name { get; set; }
        public DayEntry DueDay { get; set; }
        public IntEntry InComeId { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(Name);
            AddEntry(DueDay);
            AddEntry(InComeId);
        }

        public override void InitEntries()
        {
            base.InitEntries();

            Name = new String64Entry();
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
