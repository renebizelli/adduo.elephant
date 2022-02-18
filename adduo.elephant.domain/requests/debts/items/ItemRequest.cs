using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.domain.requests.debts.items
{
    public class ItemRequest : DebtRequest
    {
        public DayEntry DueDayOfMonth { get; set; }
        public IntEntry InComeId { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(DueDayOfMonth);
            AddEntry(InComeId);
        }

        public override void InitEntries()
        {
            base.InitEntries();
         
            DueDayOfMonth = new DayEntry();
            InComeId = new IntEntry();
        }

        public override void AddValidators()
        {
            base.AddValidators();
         
            InComeId.AddValidation(new IntNotZero());
        }
    }
}
