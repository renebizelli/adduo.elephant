using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.domain.requests.debts.items
{
    public class ItemAmountRequest : ItemRequest
    {
        public DecimalEntry Value { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(Value);
        }

        public override void InitEntries()
        {
            base.InitEntries();
            
            Value = new DecimalEntry();
        }

        public override void AddValidators()
        {
            base.AddValidators();
            
            Value.AddValidation(new DecimalNotZero());
        }
    }
}
